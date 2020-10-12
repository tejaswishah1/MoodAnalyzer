using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;

namespace MoodAnalysisTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        ////If sad, return sad.
        public void Given_sad_string_return_sad()
        {
            //Arrange
            string expectedResult = "SAD";
            string message = "I am in a Sad mood".ToLower();
            MoodAnalyse analysismood = new MoodAnalyse(message);

            //Act
            string mood = analysismood.AnalyseMood();

            //Assert
            Assert.AreEqual(mood, expectedResult);


        }
        [TestMethod]
        public void Given_happy_string_return_happy()
        {
            //Arrange
            string expectedResult = "HAPPY";
            string message = "I am in a Happy mood";
            MoodAnalyse analysismood = new MoodAnalyse(message);

            //Act
            string mood = analysismood.AnalyseMood();

            //Assert
            Assert.AreEqual(mood, expectedResult);

        }
       
        [TestMethod] ////Null string, return exception
        public void Given_null_string_return_throw_custom_exception()
        {
            //Arrange
            try
            {
                string message = string.Empty;
                MoodAnalyse analysismood = new MoodAnalyse(message);

                //Act
                string mood = analysismood.AnalyseMood();
            }
            catch (MoodAnalyzerException exception)
            {
                //Assert
                Assert.AreEqual("Mood cannot be empty", exception.Message);
            }
        }
    }
}

