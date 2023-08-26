namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_30;


#region INCLUDE
public record class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }

    public Employee(int id, string name, string role) =>
        (Id, Name, Role) = (id, name, role);
}


public class ExpenseItem
{
    public int Id { get; set; }
    public string ItemName { get; set; }
    public decimal CostAmount { get; set; }
    public DateTime ExpenseDate { get; set; }
    public Employee Employee { get; set; }

    public ExpenseItem(
        int id, string name, decimal amount, DateTime date, 
            Employee employee) =>
                (Id, Employee, ItemName, CostAmount, ExpenseDate) = 
                (id, employee, name, amount, date);

    public static bool ValidateExpenseItem(ExpenseItem expenseItem) =>
        expenseItem switch
        {
            // Note: A property pattern checks that the input value is not null
            // Expanded Property Pattern
            { ItemName.Length: > 0, Employee.Role: "Admin" } => true,
            #pragma warning disable IDE0170 // Property pattern can be simplified
            // Property Pattern
            { ItemName: { Length: > 0 }, Employee: {Role: "Manager" }, 
                ExpenseDate: DateTime date } 
            #pragma warning restore IDE0170 // Property pattern can be simplified
                when date >= DateTime.Now.AddDays(-30) => true,
            { ItemName.Length: > 0,  Employee.Name.Length: > 0, 
                CostAmount: <= 1000, ExpenseDate: DateTime date }
                when date >= DateTime.Now.AddDays(-30) => true,
            { } => false, // This not null check can be eliminated.
            _ => false
        };
}
#endregion INCLUDE

