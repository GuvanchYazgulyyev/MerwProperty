using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class Category
    {
        public Category()
        {
            AllCities = new HashSet<AllCity>();
            PublishingAdverts = new HashSet<PublishingAdvert>();
        }

        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public int? CityId { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsEnable { get; set; }

        public virtual AllCity? City { get; set; }
        public virtual ICollection<AllCity> AllCities { get; set; }
        public virtual ICollection<PublishingAdvert> PublishingAdverts { get; set; }
    }
}
