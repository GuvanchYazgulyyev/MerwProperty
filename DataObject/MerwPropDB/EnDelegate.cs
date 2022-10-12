using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class EnDelegate
    {
        public int Id { get; set; }
        public string? TaskName { get; set; }
        public string? Image { get; set; }
        public string? NameSurname { get; set; }
        public string? TelNo { get; set; }
        public string? Email { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsEnable { get; set; }
    }
}
