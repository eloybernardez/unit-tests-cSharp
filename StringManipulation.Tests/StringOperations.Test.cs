namespace StringManipulation.Tests
{
    public class StringOperationsTests
    {
        [Fact(Skip = "Esta prueba no es válida en este momento. Hacer un ticket para justificar")]
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

        [Theory]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("X", 10)]
        public void FromRomanToNumber(string romanNumber, int expected)
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            var result = strOperations.FromRomanToNumber(romanNumber);

            // Assert
            Assert.Equal(expected, result);
        }

        // Rehaciendo test con Thery e InlineData
        [Theory]
        [InlineData("oso")]
        [InlineData("carro")]
        public void IsPalindrome(string word)
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            bool result = strOperations.IsPalindrome(word);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("gato", 15)]
        public void QuantityInWordsTheory(string word, int amount)
        {
            // Arrange
            var strOperations = new StringOperations();

            // Act
            string result = strOperations.QuantintyInWords(word, amount);

            // Assert
            Assert.Equal("quince gatos", result);
        }
    }
}
