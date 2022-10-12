using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class EnContact
    {
        public int Id { get; set; }
        public string? AddressDescription { get; set; }
        public string? Tel { get; set; }
        public string? Mail { get; set; }
        public string? WorkingTimes { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsEnable { get; set; }
    }
}
