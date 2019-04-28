using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRKit.Models
{
    public class Class1
    {
    }

    public class Root
    {
        public int status { get; set; }
        public string response { get; set; }
    }

    public enum Responses {

        Success = 1,
        Failed = 0,
        Error = -1
    }

    public enum Defaults {

        LowerBound = 1,
        HigherBound = 2,
        DefaultStep = 3,
        DefaultYears = 4
    }
}
