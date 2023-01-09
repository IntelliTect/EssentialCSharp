// Build Action set to none.
using AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_21;
using System;
using System.Diagnostics.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Table07_03;

public class PaternMatchingExamples
{
    static object? GetObjectById(string id)
    {
        if(id is "92e80a67-d453-4998-8d85-f430fa02d6c7")
        {
            return new Employee("Inigo", "Montoay", "2e80a67-d453-4998-8d85-f430fa02d6c7");
        }
        return null;
    }

    public class Person
    {
        #region EXCLUDE
        public Person(string firstName, string lastName)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }
        public string FirstName { get; }
        public string LastName { get; }
        #endregion EXCLUDE

        #region HIGHLIGHT
        public void Deconstruct(out string firstName, out string lastName) =>
            (firstName, lastName) = (FirstName, LastName);
        #endregion HIGHLIGHT
    }

    class Employee : Person
    {
        public Employee(string firstName, string lastName, string id) : base(firstName, lastName)
        {
        }
    }

// 1. Declaration Pattern
    // is Operator
    public void TypePatternMatching()
    {

        void Display(Employee employee)
        {
            throw new NotImplementedException();
        }
        void ReportError(string message)
        {
            throw new NotImplementedException();
        }

        #region INCLUDE
        // ...
        string id =
            "92e80a67-d453-4998-8d85-f430fa02d6c7";
        if (GetObjectById(id) is Employee person)
        {
            Display(person);
        }
        else
        {
            ReportError($"Employee id, {id} is invalid.");
        }
        #endregion INCLUDE
    }

    // switch Expression
    #region INCLUDE
    public static TimeOnly GetTime(
            object input) =>
        input switch
        {
            DateTime datetime
                => TimeOnly.FromDateTime(datetime),
            DateTimeOffset datetimeOffset
                    => TimeOnly.FromDateTime(datetimeOffset.DateTime),
            string dateText => TimeOnly.Parse(
                dateText),
            _ => throw new ArgumentException(
                $"Invalid type - {input.GetType().FullName}")
        };
    #endregion INCLUDE



    // 2. Constant Patterns

    // is Operator
    public static bool IsSolstice(
        DateTime date)
    {
        if ((decimal)date.Day is 21m)
        {
            if (date.Month is 12)
            {
                return true;
            }
            if (date.Month is 6)
            {
                return true;
            }
        }
        return false;
    }

    // switch expression
    public static bool TryGetSolstice(
        DateTime date, 
        [NotNullWhen(true)] out string? solstice
    )
    {
        if ((decimal)date.Day is 21m)
        {
            if ((solstice = date.Month switch
            {
                12 => "Winter Solistice",
                6 => "Summer Solistice",
                _ => null
            }) is not null) return true;
        }
        solstice = null;
        return false;
    }

    // Listing 5.18 leverages constant patterns but in a switch statement.
    
    // switch statement
    public static bool TryGetSolstice2(
        DateTime date,
        [NotNullWhen(true)] out string? solstice
    )
    {
        if ((decimal)date.Day is 21m)
        {
            switch (date.Month)
            {
                case 12:
                    solstice = "Winter Solistice";
                    return true;
                case 6:
                    solstice = "Summer Solistice";
                    return true;
            };
        }
        solstice = null;
        return false;
    }





    // 3. Relational Pattern Mathing
    public bool IsDeveloperWorkHours(
        TimeOnly time) =>
            time.Hour is > 10 &&
                time.Hour is < 24;


    public string GetPeriodOfDay(TimeOnly time) =>
        time.Hour switch
        {
            < 6 => "Dawn",
            < 12 => "Morning",
            < 18 => "Afternoon",
            < 24 => "Evening",
            int hour => throw new InvalidOperationException(
                $"The time has an invalid Hour value of {hour}.")
        };

    // 4. Logical Patterns
    public bool IsStandardWorkHours(
        TimeOnly time) =>
            time.Hour is > 8 
                and < 17
                and not 12; // lunch

    public bool IsOutsideOfStandardWorkHours(
        TimeOnly time) =>
            time.Hour is not 
                (> 8 and < 17 and not 12); // Parentbhesis Pattern - C# 10.

    static bool TryGetPhoneButton(
        char character, 
        [NotNullWhen(true)] out char? button)
    {
        return (button = char.ToLower(character) switch
        {
            '1' => '1',
            '2' or >= 'a' and <= 'c' => '2',
            // not operator and parethesis example (C# 10)
            '3' or not (< 'd' or > 'f') => '3',
            '4' or >= 'g' and <= 'i' => '4',
            '5' or >= 'j' and <= 'l' => '5',
            '6' or >= 'm' and <= 'o' => '6',
            '7' or >= 'p' and <= 's' => '7',
            '8' or >= 't' and <= 'v' => '8',
            '9' or >= 'w' and <= 'z' => '9',
            '0' or '+' => '0',
            _ => null,// Set the button to indicate an invalid value
        }) is not null;
    }

    // 5. Property Patterns

}
