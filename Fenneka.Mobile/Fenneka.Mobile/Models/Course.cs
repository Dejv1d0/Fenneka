using System;
using System.Collections.Generic;
using System.Text;

namespace Fenneka.Mobile.Models
{
    public class Course
    {
        public int id { get; set; }
        public string image { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        //public string description { get; set; } = string.Empty;
        public string date { get; set; } = string.Empty;
        public string hour { get; set; } = string.Empty;
        public string localization { get; set; } = string.Empty;
        public string teacher { get; set; } = string.Empty;

    }
}
