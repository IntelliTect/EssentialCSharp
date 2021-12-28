"use strict";
var __createBinding = (this && this.__createBinding) || (Object.create ? (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    Object.defineProperty(o, k2, { enumerable: true, get: function() { return m[k]; } });
}) : (function(o, m, k, k2) {
    if (k2 === undefined) k2 = k;
    o[k2] = m[k];
}));
var __setModuleDefault = (this && this.__setModuleDefault) || (Object.create ? (function(o, v) {
    Object.defineProperty(o, "default", { enumerable: true, value: v });
}) : function(o, v) {
    o["default"] = v;
});
var __importStar = (this && this.__importStar) || function (mod) {
    if (mod && mod.__esModule) return mod;
    var result = {};
    if (mod != null) for (var k in mod) if (k !== "default" && Object.prototype.hasOwnProperty.call(mod, k)) __createBinding(result, mod, k);
    __setModuleDefault(result, mod);
    return result;
};
Object.defineProperty(exports, "__esModule", { value: true });
const core = __importStar(require("@actions/core"));
const msca_toolkit_1 = require("./msca-toolkit/msca-toolkit");
const path = __importStar(require("path"));
const fs = __importStar(require("fs"));
function getAnalysisLevelArgumentFromInput(analysisLevelName) {
    let analysisLevelInput = core.getInput(analysisLevelName.toLowerCase());
    if (action.isNullOrWhiteSpace(analysisLevelInput)) {
        return '';
    }
    let analysisLevel;
    let analysisMode;
    let separator = analysisLevelInput.lastIndexOf('-');
    if (separator > 0) {
        analysisLevel = analysisLevelInput.substring(0, separator);
        analysisMode = analysisLevelInput.substring(separator + 1);
    }
    else {
        switch (analysisLevelInput.toLowerCase()) {
            case 'none':
            case 'default':
            case 'minimum':
            case 'recommended':
            case 'all':
            case 'allenabledbydefault':
            case 'alldisabledbydefault':
                analysisMode = analysisLevelInput;
                analysisLevel = 'latest';
                break;
            default:
                analysisLevel = analysisLevelInput;
                analysisMode = 'minimum';
                break;
        }
    }
    let newArg;
    if (analysisLevelName == 'all-categories') {
        newArg = `/p:AnalysisLevel=${analysisLevel} /p:AnalysisMode=${analysisMode} `;
    }
    else {
        newArg = `/p:AnalysisLevel${analysisLevelName}=${analysisLevel} /p:AnalysisMode${analysisLevelName}=${analysisMode} `;
    }
    return newArg;
}
function appendToProjectsOrSolutions(inputVariableName, projectsOrSolutions) {
    let input = core.getInput(inputVariableName);
    if (!action.isNullOrWhiteSpace(input)) {
        if (!action.isNullOrWhiteSpace(projectsOrSolutions)) {
            projectsOrSolutions += ';';
        }
        projectsOrSolutions += input;
    }
    return projectsOrSolutions;
}
let action = new msca_toolkit_1.MscaAction();
// Process core analysis-level
let analysisArgs = getAnalysisLevelArgumentFromInput('all-categories');
// Process category specific analysis levels
analysisArgs += getAnalysisLevelArgumentFromInput('Style');
analysisArgs += getAnalysisLevelArgumentFromInput('Design');
analysisArgs += getAnalysisLevelArgumentFromInput('Documentation');
analysisArgs += getAnalysisLevelArgumentFromInput('Globalization');
analysisArgs += getAnalysisLevelArgumentFromInput('Interoperability');
analysisArgs += getAnalysisLevelArgumentFromInput('Maintainability');
analysisArgs += getAnalysisLevelArgumentFromInput('Naming');
analysisArgs += getAnalysisLevelArgumentFromInput('Performance');
analysisArgs += getAnalysisLevelArgumentFromInput('Reliability');
analysisArgs += getAnalysisLevelArgumentFromInput('Security');
analysisArgs += getAnalysisLevelArgumentFromInput('Usage');
let buildBreakingArg = core.getInput('build-breaking');
let warnAsError = action.isNullOrWhiteSpace(buildBreakingArg) || buildBreakingArg.toLowerCase() != 'false';
let projectsOrSolutions = '';
projectsOrSolutions = appendToProjectsOrSolutions('solution', projectsOrSolutions);
projectsOrSolutions = appendToProjectsOrSolutions('solutions', projectsOrSolutions);
projectsOrSolutions = appendToProjectsOrSolutions('project', projectsOrSolutions);
projectsOrSolutions = appendToProjectsOrSolutions('projects', projectsOrSolutions);
var buildCommandLines = "";
var first = true;
if (action.isNullOrWhiteSpace(projectsOrSolutions)) {
    buildCommandLines += `msbuild.exe ${analysisArgs}`;
}
else {
    projectsOrSolutions.split(";").forEach(function (project) {
        if (!first) {
            buildCommandLines += " ; ";
            first = false;
        }
        buildCommandLines += `msbuild.exe ${analysisArgs}${project}`;
    });
}
var configContent = {
    "fileVersion": "1.12.0",
    "tools": [
        {
            "fileVersion": "1.12.0",
            "tool": {
                "name": "RoslynAnalyzers",
                "version": "1.12.0"
            },
            "arguments": {
                "CopyLogsOnly": false,
                "SourcesDirectory": "$(Folders.SourceRepo)",
                "MSBuildVersion": "16.0",
                "CodeAnalysisAssemblyVersion": "3.8.0",
                "SetupCommandlines": "\\\"$(VisualStudioInstallDirectory)\\Common7\\Tools\\VsMSBuildCmd.bat\\\"",
                "BuildArchitecture": "amd64",
                "BuildCommandlines": buildCommandLines,
                "NetAnalyzersRootDirectory": "$(Packages.Microsoft.CodeAnalysis.NetAnalyzers)",
                "CSharpCodeStyleAnalyzersRootDirectory": "$(Packages.Microsoft.CodeAnalysis.CSharp.CodeStyle)",
                "FxCopAnalyzersRootDirectory": "",
                "RulesetPath": "",
                "SdlRulesetVersion": "",
                "TreatWarningsAsErrors": warnAsError,
                "LoggerLevel": "Warning",
                "ForceSuccess": true // Pass force success flag so MSBuild exit code 1 on analyzer errors does not lead to non-graceful failure.
            },
            "outputExtension": "sarif",
            "successfulExitCodes": [
                0
            ]
        }
    ]
};
const actionDirectory = path.resolve(__dirname);
core.debug(`actionDirectory = ${actionDirectory}`);
let data = JSON.stringify(configContent);
let gdnConfigFilePath = path.join(actionDirectory, '../', 'roslynanalyzers.gdnconfig');
core.debug(`gdnConfigFilePath = ${gdnConfigFilePath}`);
try {
    fs.writeFileSync(gdnConfigFilePath, data);
    data = fs.readFileSync(gdnConfigFilePath, "utf8");
    core.info(data);
}
catch (err) {
    throw Error(err);
}
let args = [];
args.push('-c');
args.push(gdnConfigFilePath);
args.push('--no-policy');
// Set logger level to only display warnings and errors
args.push('--logger-level');
args.push('Warning');
if (!warnAsError) {
    args.push('--not-break-on-detections');
}
core.info("------------------------------------------------------------------------------");
core.info("Installing and running analyzers...");
core.info("Warnings and errors will be displayed once the analysis completes.");
action.run(args);
