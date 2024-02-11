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

        [Fact]
        public void RemoveWhiteSpace()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            string result = strOperations.RemoveWhitespace("Hello Platzi");

            // Assert
            Assert.NotEmpty(result);
            Assert.NotNull(result);
            Assert.Equal("HelloPlatzi", result);
        }

        [Fact]
        public void QuantityInWords()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            string result = strOperations.QuantintyInWords("perro", 12);

            // Assert
            Assert.NotEmpty(result);
            Assert.NotNull(result);

            Assert.StartsWith("doce", result);
            Assert.Contains("perros", result);
            //Assert.Equal("doce perros", result);
        }

        [Fact]
        public void GetStringLength_Exception()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Assert
            Assert.ThrowsAny<ArgumentNullException>(() => strOperations.GetStringLength(null));
        }

        [Fact]
        public void GetStringLength()
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            int result = strOperations.GetStringLength("Hello Platzi");

            // Assert
            Assert.Equal(12, result);
        }
    }
}
