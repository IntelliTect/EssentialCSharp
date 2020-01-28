using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_23.Tests
{
    [TestClass]
    public class EntityDictionaryTests
    {
        [TestMethod]
        public void CreateEntityDictionary_Success()
        {
#pragma warning disable CS8714 // The type cannot be used as type parameter in the generic type or method. Nullability of type argument doesn't match 'notnull' constraint.
            _ = new EntityDictionary<string?, EntityBase>();
#pragma warning restore CS8714 // The type cannot be used as type parameter in the generic type or method. Nullability of type argument doesn't match 'notnull' constraint.
        }
    }
}
