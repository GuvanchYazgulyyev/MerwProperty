using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string? CommentNameSurname { get; set; }
        public string? CityName { get; set; }
        public string? Image { get; set; }
        public string? Comments { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? IsEnable { get; set; }
        public int? PublishingAdvertId { get; set; }

        public virtual PublishingAdvert? PublishingAdvert { get; set; }
    }
}
