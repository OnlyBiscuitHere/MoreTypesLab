using System;
using System.Linq;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            if (input == "")
            { 
                for (int i = 0; i < num; i++)
                {
                    input = input + Convert.ToString(i);
                }
            }
            else
            {
                input = input.Trim().ToUpper();
                for (int i = 0; i < num; i++)
                {
                    input = input + Convert.ToString(i);
                }
            }
            return input;
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return Convert.ToString(number) + " " + street + ", " + city + " " + postcode + ".";
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            double percent = ((double)score / outOf)*100;
            return "You got " + score + " out of " + outOf + ": " + Math.Round(percent,1) + "%";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            if (Double.TryParse(numString, out double result))
            {
                return Convert.ToDouble(numString);
            }
            else
            {
                return -999;
            }
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int A = input.Count(f => f == 'A');
            int B = input.Count(f => f == 'B');
            int C = input.Count(f => f == 'C');
            int D = input.Count(f => f == 'D');

            return "A:" + A + " B:" + B + " C:" + C + " D:" + D;
        }
    }
}
