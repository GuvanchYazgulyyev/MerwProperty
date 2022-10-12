using System;
using System.Collections.Generic;

namespace DataObject.MerwPropDB
{
    public partial class EnImage
    {
        public int Id { get; set; }
        public string? ImageName { get; set; }
        public string? Url { get; set; }
        public int? PublishingAdvertId { get; set; }
    }
}
