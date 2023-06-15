namespace UnitTests1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, "", false)]
        [InlineData(10, "a1B2C3#$110", false)]
        [InlineData(10, "G00dL3n&th", true)]
        [InlineData(10, "m1ssupp$r", false)]
        [InlineData(10, "M!SSL0WER", false)]
        [InlineData(20, "MissCharacter1", false)]
        [InlineData(10, "MissDigit$", false)]
        [InlineData(30, "  BeginWithWhiteSpace1!", false)]
        [InlineData(30, "Middle  WhiteSpace1!", false)]
        [InlineData(30, "EndWithWhiteSpace1!  ", false)]
        public void Regex_IsMatch_ValidResult(int maxLength, string data, bool expectedResult)
        {
            // arrange & act
            var result = UseCase10.Program.IsMatch(maxLength, data);

            // assert
            Assert.Equal(expectedResult, result);
        }
    }
}