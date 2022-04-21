using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findCharAmount
{
    public class FindFreq
    {
        public List<int> getCharNum(string input)
        {
            List<int> outputList = new List<int>();
            input = input.ToLower().Replace(" ", string.Empty);
            while (input.Length > 0)
            {

               int charCount = 0;
               Console.Write("{0}=", input[0]);
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[0] == input[i])
                    {
                        charCount++;
                    }
                }

                Console.WriteLine("{0}", charCount);
                input = input.Replace(input[0].ToString(), string.Empty);
                outputList.Add(charCount);
                
            }
            return outputList;
        }
    }
}
