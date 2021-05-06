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
                if (this.message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "no mood";
                }
            }
            catch
            {
                return "happy";
            }
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
