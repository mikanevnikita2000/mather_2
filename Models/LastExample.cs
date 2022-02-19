using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mather_2.Models
{
    public class LastExample
    {
        public int lastResult = 0;
        public string lastVisibleExpression = "";

        public int GetLastResultFinite
        {
            get => lastResult;
            set => lastResult = value;
        }
        public string GetLastVisibleExpression
        {
            get => lastVisibleExpression;
            set => lastVisibleExpression = value;
        }
    }
}
