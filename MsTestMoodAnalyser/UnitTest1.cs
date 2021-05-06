using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserProblem;

namespace MsTestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {/// <summary>
     /// TC2.1 nullmood should return happy
     /// </summary>
        [TestMethod]
        public void Given_nullmood_Expecting_Happy_Results()
        {
            //Arrange;
            MoodAnalyser mood = new MoodAnalyser(null);
            string expected = "happy";

            //Act
            string actual = mood.Analyser();

            //Asert
            Assert.AreEqual(expected, actual);
        }
    }
}

