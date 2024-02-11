namespace StringManipulation.Tests
{
    public class StringOperationsTests
    {
        [Fact]
        public void ConcatenateStrings()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            string result = strOperations.ConcatenateStrings("Hello", "Platzi");

            // Assert
            // Comprobamos que el valor no sea nulo
            Assert.NotNull(result);

            // Comprobamos que el valor no esté vacío
            Assert.NotEmpty(result);

            // Comprobamos que el valor sea el esperado
            Assert.Equal("Hello Platzi", result);
        }

        [Fact]
        public void IsPalindrome_True()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            bool result = strOperations.IsPalindrome("oso");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_False()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            bool result = strOperations.IsPalindrome("carro");

            // Assert
            Assert.False(result);
        }
    }
}
