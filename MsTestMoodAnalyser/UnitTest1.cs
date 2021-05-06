using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserProblem;

namespace MsTestMoodAnalyser
{
    [TestClass]

    public class UnitTest1
    {
        //Tc5.1Given MoodAnalyser When Proper Return MoodAnalyser Object

        [TestMethod]
        public void Given_MoodAnalyser_When_Proper_Return_MoodAnalyser_Object()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreatedMoodAnalyserUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyser", "MoodAnalyser", "HAPPY");
            expected.Equals(obj);
        }

        [TestMethod]
        //Tc5.2 Given Class Name When Improper Should Throw MoodAnalysisException

        public void Given_ClassName_WhenImproper_Should_Throw_MoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserFactory.CreatedMoodAnalyserUsingParameterizedConstructor("MoodAnalyzer.sampleClass", "MoodAnalyser", "HAPPY");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        // <summary>
        /// This test case is for
        /// TC 5.3 Given Invalid constructor name should throw MoodAnalyserException.
        /// </summary>
        [TestMethod]
        public void GivenInvalidConstructorName_ShouldThrow_MoodAnalyserException_Of_ParameterizedConstructor()
        {
            string expected = "Constructor is not found";
            try
            {
                object obj = MoodAnalyserFactory.CreatedMoodAnalyserUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyser", "sampleClass", "HAPPY");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }



        /// Test Case 6.1 Given Happy Message Using Reflection When Proper Should Return HAPPY Mood 

        [TestMethod]
        public void GivenHappyMessage_UsingReflection_Should_ReturnHappy()
        {
            string message = MoodAnalyserFactory.InvokeMethod("MoodAnalyzer.MoodAnalyser", "GetMood", "HAPPY");
            Assert.AreEqual("HAPPY", message);
        }

        /// <summary>
        /// Test Case 6.2 
        /// Given Happy message when improper method should throw MoodAnalyserException
        /// </summary>
        [TestMethod]
        public void GivenHappyMessage_UsingReflection_WhenIncorrectMethod_shouldThrow_MoodAnayserException()
        {
            try
            {
                string message = MoodAnalyserFactory.InvokeMethod("MoodAnalyzer.MoodAnalyser", "getMethod", "HAPPY");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.INVALID_INPUT, e.Message);
            }
        }
    }
}