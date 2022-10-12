using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class RuCategory
    {
        public RuCategory()
        {
            RuAllCities = new HashSet<RuAllCity>();
            RuPublishingAdverts = new HashSet<RuPublishingAdvert>();
        }

        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public int? CityId { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsEnable { get; set; }

        public virtual RuAllCity? City { get; set; }
        public virtual ICollection<RuAllCity> RuAllCities { get; set; }
        public virtual ICollection<RuPublishingAdvert> RuPublishingAdverts { get; set; }
    }
}
