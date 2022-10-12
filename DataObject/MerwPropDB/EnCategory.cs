using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class EnCategory
    {
        public EnCategory()
        {
            EnAllCities = new HashSet<EnAllCity>();
        }

        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public int? CityId { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsEnable { get; set; }

        public virtual EnAllCity? City { get; set; }
        public virtual ICollection<EnAllCity> EnAllCities { get; set; }
    }
}
