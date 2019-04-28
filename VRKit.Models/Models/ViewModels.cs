using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRKit.Models.Models
{
    public class ViewModels
    {
    }

    public class DefaultViewModel
    {
        public int Id { get; set; }
        public decimal? LowerBound { get; set; }
        public decimal? HigherBound { get; set; }
        public decimal? DefaultStep { get; set; }
        public decimal? DefaultYears { get; set; }
    }

}
