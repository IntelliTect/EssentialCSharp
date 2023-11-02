
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_30.Tests;

[TestClass]
public class ProgramTests
{
    const bool IsValid = true;
    const bool NotValid = false;
    [TestMethod]
    [DataRow(IsValid, 42, "Starwars Lego set", 239.99, 7, 490, "Inigo Montoya", "Admin")]
    [DataRow(IsValid, 42, "Starwars Lego set", 239.99, -42, 490, "Inigo Montoya", "Admin")]
    [DataRow(IsValid, 42, "Starwars Lego set", 1001, 7, 490, "Inigo Montoya", "Manager")]
    [DataRow(IsValid, 42, "Starwars Lego set", 1001, 7, 490, "Inigo Montoya", "Manager")]
    [DataRow(NotValid, 42, "Starwars Lego set", 1001, 42, 490, "Inigo Montoya", "Manager")]
    [DataRow(NotValid, 42, "Starwars Lego set", 1001, 7, 490, "Inigo Montoya", "Employee")]
    [DataRow(NotValid, 42, "Starwars Lego set", 100, 42, 490, "Inigo Montoya", "Employee")]
    [DataRow(IsValid, 42, "Starwars Lego set", 100, 7, 490, "Inigo Montoya", "Employee")]
    public void ValidateExpenseItemTest(
        bool expectedResult,
        int itemId, string itemName, double amount, int daysPassed,
        int employeeId, string employeeName, string role
        )
    {
        Assert.AreEqual(expectedResult, ExpenseItem.ValidateExpenseItem(
                new ExpenseItem(itemId, itemName,
                    (decimal)amount, DateTime.Now.AddDays(-daysPassed), 
                    new Employee(employeeId, employeeName, role))
                ));
    }

    [TestMethod]
    public void ValidateExpenseItem_GivenNull_Fasle()
    {
        Assert.IsFalse(ExpenseItem.ValidateExpenseItem(null!));
    }
}
