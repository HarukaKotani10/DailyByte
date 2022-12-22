using DailyByte;
using System;
using Xunit;

namespace DailyByteTest
{
    public class UncommonWordsTest
    {
        [Theory]
        [InlineData("the quick", "brown fox", new string[] { "the", "quick", "brown", "fox" })]
        [InlineData("the tortoise beat the haire", "the tortoise lost to the haire", new string[] { "beat", "lost", "to" })]
        [InlineData("copper coffee pot", "hot coffee pot", new string[] { "copper", "hot" })]
        public void GetUncommonWordsWithSampleInput(string sentence1, string sentence2, string[] expected)
        {
            //arrange
            //act
            string[] result = UncommonWords.GetUncommonWords(sentence1, sentence2);

            // assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("the quick", "brown fox", new string[] { "the", "quick", "brown", "fox" })]
        [InlineData("the tortoise beat the haire", "the tortoise lost to the haire", new string[] { "beat", "lost", "to" })]
        [InlineData("copper coffee pot", "hot coffee pot", new string[] { "copper", "hot" })]
        public void GetUncommonWordsWithSampleInputOneLine(string sentence1, string sentence2, string[] expected)
        {
            //arrange
            //act
            string[] result = UncommonWords.GetUncommonWordsOneLine(sentence1, sentence2);

            // assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("the quick", "brown fox", new string[] { "the", "quick", "brown", "fox" })]
        [InlineData("the tortoise beat the haire", "the tortoise lost to the haire", new string[] { "beat", "lost", "to" })]
        [InlineData("copper coffee pot", "hot coffee pot", new string[] { "copper", "hot" })]
        public void GetUncommonWordsWithSampleInputConcat(string sentence1, string sentence2, string[] expected)
        {
            //arrange
            //act
            string[] result = UncommonWords.GetUncommonWordsConcat(sentence1, sentence2);

            // assert
            Assert.Equal(expected, result);
        }
    }
}
