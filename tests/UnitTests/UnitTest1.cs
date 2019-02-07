using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData("erujana")]
        [InlineData("anny")]
        [InlineData("emme")]
        public void StartingWithVowel(String n)
        {
            Assert.True(IsVowel(n));
        }

        bool IsVowel(String  n)
        {
            if (n[0] == 'a' || n[0] == 'e' || n[0] == 'i' || n[0] == 'o' || n[0] == 'u') {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        [Fact]
        public void checkingVowelwithWords()
        {
            bool expected = true;
            var str = "and";
   
            var actual = IsVowel(str);
            Assert.Equal(expected, actual);
        }
    }
}
