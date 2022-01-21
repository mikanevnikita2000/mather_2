using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mather_2.Models
{
    class FeaturesExample
    {
        private static string example = "";
        private static int result = 0;

        public static void Example(string outputExample1, int result1)
        {
            example = outputExample1;
            result = result1;
            
        }
        public static int Answer()
        {
            return result;
        }

        public static string Back()
        {
            string outputExample = example;
            int outputresult = result;
            mather_2.Models.FeaturesExample.Example(outputExample, outputresult);
            return outputExample;
        }
    }
}
