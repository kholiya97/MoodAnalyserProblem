using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserProblem;

namespace MsTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// TC1.1:Given Iam in sad mood should Return sad.
        /// </summary>
        [TestMethod]
        public void Given_Sadmood_Expecting_Sad_Results()
        {
            //Arrange;
            MoodAnalyser mood = new MoodAnalyser("I am in sad mood");
            string expected = "sad";

            //Act
            string actual = mood.Analyser();

            //Asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given_Happymood_Expecting_Happy_Results()
        {
            //    //Arrange;
            MoodAnalyser mood = new MoodAnalyser("I am in happy mood");
            string expected = "happy";

            //    //Act
            string actual = mood.Analyser();

            //Asert
            Assert.AreEqual(expected, actual);
        }
    }

}

