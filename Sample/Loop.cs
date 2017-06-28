using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_Samples.Sample
{
    public class Loop
    {
        /// <summary>
        /// Return He is aweomse when Foreachloop value = "Ching"
        /// </summary>
        /// <param name="arrValue"></param>
        /// <returns></returns>
        private string ForeachLoop(string[] arrValue)
        {
            //loop thru each of the value in the array
            foreach (string sValue in arrValue)
            {
                //if value is ching
                if (sValue.Equals("Ching"))
                {
                    //return he is awesome
                    return "He is awesome";
                }
            }
            return "";
        }

        /// <summary>
        /// Start from number 1 and return all the value divisible by 5
        /// </summary>
        /// <returns></returns>
        private string ForLoop()
        {
            //initilize return value
            string rValue = "";

            //loop thru numbers from 1 to 100
            for (int i = 1; i < 100; i++)
            {
                //if the remainder of the number equal 0
                if ((i % 5).Equals(0))
                {
                    //return the values
                    rValue = rValue += i.ToString() + ",";
                }
            }

            //if length of the value is greater than 0
            if (rValue.Length > 0)
            {
                //remove the last comma
                rValue = rValue.Substring(0, rValue.Length - 1);
            }

            //return value
            return rValue;
        }
    }
}