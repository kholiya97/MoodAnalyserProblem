using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {

        //instance variable
        string message;

        //parameterized constructor for initializing instance member
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        //Analyser method to find mood
        public string Analyser() //check msg passing into the constructor 
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                if (this.message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                //return ex.Message;
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
            }
        }
    }
    public class MoodAnalyserException : Exception
    {
        /// <summary>
        /// Enum of exception type.
        /// </summary>
        /// creating type variable of type ExceptionType
        ExceptionType type;
        public enum ExceptionType
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION
        }
        /// <summary>
        /// parameterized contructor sets the Exception Type and message.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("----Welcome To Mood Analyser----");
            //Console.Read();
        }
    }
}
