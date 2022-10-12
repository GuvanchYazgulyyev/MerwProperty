using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class RuAboutU
    {
        public int Id { get; set; }
        public string? AboutUs { get; set; }
        public string? Description { get; set; }
        public string? Video { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsEnable { get; set; }
    }
}
