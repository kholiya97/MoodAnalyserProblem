using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserProblem;

namespace MsTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {/// <summary>
     /// TC3.1 Nullmood Using CustomException Return Null
     /// </summary>
        [TestMethod]
        public void Given_Nullmood_Using_CustomException_Return_Null()
        {
            //Arrange;
            MoodAnalyser mood = new MoodAnalyser(null);
            string expected = "Mood should not be null";
            try
            {
                //Act
                string actual = mood.Analyser();
            }
            catch (MoodAnalyserException exception)
            {
                //Asert
                Assert.AreEqual(expected, exception.Message);
            }
        }
        /// <summary>
        /// TC3.2 Emptymood Using CustomException Return empty
        /// </summary>
        [TestMethod]
        public void Given_Emptymood_Using_CustomException_Return_Empty()
        {
            //Arrange;
            MoodAnalyser mood = new MoodAnalyser("");
            string expected = "Mood should not be empty";
            try
            {
                //Act
                string actual = mood.Analyser();
            }
            catch (MoodAnalyserException exception)
            {
                //Asert
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}
 

