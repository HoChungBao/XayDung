using System;
using System.Collections.Generic;

namespace XayDung.Entities
{
    public partial class Topic
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Solved { get; set; }
        public bool? SolvedReminderSent { get; set; }
        public string Slug { get; set; }
        public int? Views { get; set; }
        public bool IsSticky { get; set; }
        public bool IsLocked { get; set; }
        public bool? Pending { get; set; }
        public string Status { get; set; }
        public Guid CategoryId { get; set; }
        public string MembershipUserId { get; set; }
        public string MetaSeo { get; set; }
        public string LinkImage { get; set; }
        public int TypeTopic { get; set; }
        public string CaptionShort { get; set; }
        public DateTime? DateApprove { get; set; }
        public string BannerLink { get; set; }
        public string RelatedSubject { get; set; }
        public string LinkVideoAudio { get; set; }
        public string Channel { get; set; }
        public bool IsInterested { get; set; }
        public string CateSub { get; set; }
        public string Author { get; set; }
        public int? OrderBySection { get; set; }

        public virtual Category Category { get; set; }
        public virtual AspNetUsers MembershipUser { get; set; }
    }
}
