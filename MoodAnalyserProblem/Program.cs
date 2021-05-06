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
        string Message;

        //parameterized constructor for initializing instance member
        public MoodAnalyser(string message)
        {
            Message = message;
        }

        //Analyser method to find mood
        public string Analyser() //check msg passing into the constructor is contain(happy) then written happy else sad
        {
            if (Message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return " sad";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Welcome To Mood Analyser----");
            Console.Read();
        }
    }

}
