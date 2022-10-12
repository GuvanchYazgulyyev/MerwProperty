using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class EnAllCity
    {
        public EnAllCity()
        {
            EnCategories = new HashSet<EnCategory>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsEnable { get; set; }

        public virtual EnCategory? Category { get; set; }
        public virtual ICollection<EnCategory> EnCategories { get; set; }
    }
}
