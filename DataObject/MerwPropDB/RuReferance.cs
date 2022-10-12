using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class RuReferance
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsEnable { get; set; }
    }
}
