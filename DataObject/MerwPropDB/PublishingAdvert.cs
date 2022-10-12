using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class PublishingAdvert
    {
        public PublishingAdvert()
        {
            Comments = new HashSet<Comment>();
            Images = new HashSet<Image>();
        }

        public int? PublishingAdvertId { get; set; }
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

        public virtual Category? Categori { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
