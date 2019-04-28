using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRKit.Models.Models
{
    public class Read_Lookup_Defaults_Model
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public decimal? NumValue { get; set; }
        public string Type { get; set; }
        //public DateTime AlterDate { get; set; }
    }

    public class Read_Lookup_Defaults_List_Model: Root
    {
        public List<Read_Lookup_Defaults_Model> Lookup_List { get; set; }
    }
}
