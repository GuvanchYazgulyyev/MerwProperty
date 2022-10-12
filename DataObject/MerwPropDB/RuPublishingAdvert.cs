using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class RuPublishingAdvert
    {
        public RuPublishingAdvert()
        {
            RuComments = new HashSet<RuComment>();
            RuImages = new HashSet<RuImage>();
        }

        public int Id { get; set; }
        public string? PublishName { get; set; }
        public string? AdvertNo { get; set; }
        public string? Address { get; set; }
        public string? Price { get; set; }
        public string? Description { get; set; }
        public string? BathRoom { get; set; }
        public string? RoomCount { get; set; }
        public string? PublishStatus { get; set; }
        public string? BedCount { get; set; }
        public string? YearsOfStatus { get; set; }
        public string? Garage { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsEnable { get; set; }
        public int? CategoriId { get; set; }

        public virtual RuCategory? Categori { get; set; }
        public virtual ICollection<RuComment> RuComments { get; set; }
        public virtual ICollection<RuImage> RuImages { get; set; }
    }
}
