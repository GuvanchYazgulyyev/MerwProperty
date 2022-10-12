using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class RuAllCity
    {
        public RuAllCity()
        {
            RuCategories = new HashSet<RuCategory>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsEnable { get; set; }

        public virtual RuCategory? Category { get; set; }
        public virtual ICollection<RuCategory> RuCategories { get; set; }
    }
}
