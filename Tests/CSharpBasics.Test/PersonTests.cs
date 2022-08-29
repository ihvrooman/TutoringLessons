namespace CSharpBasics.Test
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void WhenCreatingPersonWithNameConstructor_NameShouldBeSetToValue()
        {
            //Arrange
            var name = "Ken";

            //Act
            var personToTest = new Person(name);

            //Assert
            Assert.AreEqual(name, personToTest.Name);
        }
    }
}