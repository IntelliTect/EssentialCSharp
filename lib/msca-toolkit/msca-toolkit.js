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
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.MscaAction = void 0;
const path = __importStar(require("path"));
const process = __importStar(require("process"));
const core = __importStar(require("@actions/core"));
const exec = __importStar(require("@actions/exec"));
const msca_installer_1 = require("./msca-installer");
class MscaAction {
    constructor() {
        this.cliVersion = '0.*';
    }
    setupEnvironment() {
        return __awaiter(this, void 0, void 0, function* () {
            console.log('------------------------------------------------------------------------------');
            if (!process.env.MSCA_FILEPATH) {
                let cliVersion = this.resolveCliVersion();
                let mscaInstaller = new msca_installer_1.MscaInstaller();
                yield mscaInstaller.install(cliVersion);
            }
            console.log('------------------------------------------------------------------------------');
        });
    }
    resolveCliVersion() {
        let cliVersion = this.cliVersion;
        if (process.env.MSCA_VERSION) {
            cliVersion = process.env.MSCA_VERSION;
        }
        return cliVersion;
    }
    isNullOrWhiteSpace(value) {
        return !value || !value.trim();
    }
    init() {
        return __awaiter(this, void 0, void 0, function* () {
            let cliFilePath = process.env.MSCA_FILEPATH;
            core.debug(`cliFilePath = ${cliFilePath}`);
            try {
                yield exec.exec(cliFilePath, ['init', '--force']);
            }
            catch (error) {
                core.debug(error.Message);
            }
        });
    }
    run(inputArgs) {
        return __awaiter(this, void 0, void 0, function* () {
            yield this.setupEnvironment();
            yield this.init();
            let cliFilePath = process.env.MSCA_FILEPATH;
            core.debug(`cliFilePath = ${cliFilePath}`);
            let args = ['run'];
            if (inputArgs != null) {
                for (let i = 0; i < inputArgs.length; i++) {
                    args.push(inputArgs[i]);
                }
            }
            if (core.isDebug()) {
                args.push('--logger-level');
                args.push('trace');
            }
            let sarifFile = path.join(process.env.GITHUB_WORKSPACE, '.gdn', 'analysis_results.sarif');
            core.debug(`sarifFile = ${sarifFile}`);
            // Write it as a GitHub Action variable for follow up tasks to consume
            core.exportVariable('ANALYSIS_RESULTS_SARIF_FILE', sarifFile);
            core.setOutput('sarifFile', sarifFile);
            args.push('--export-breaking-results-to-file');
            args.push(`${sarifFile}`);
            core.debug('Running Microsoft Security Code Analysis...');
            try {
                yield exec.exec(cliFilePath, args);
            }
            catch (error) {
                core.setFailed(error.Message);
            }
        });
    }
}
exports.MscaAction = MscaAction;
