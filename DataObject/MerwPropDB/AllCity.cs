using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class AllCity
    {
        public AllCity()
        {
            Categories = new HashSet<Category>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsEnable { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
