using System;
using System.Collections.Generic;

namespace XayDung.Entities
{
    public partial class Category
    {
        public Category()
        {
            InverseCategoryNavigation = new HashSet<Category>();
            Topic = new HashSet<Topic>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsLocked { get; set; }
        public bool ModerateTopics { get; set; }
        public bool ModeratePosts { get; set; }
        public int SortOrder { get; set; }
        public DateTime DateCreated { get; set; }
        public string Slug { get; set; }
        public string PageTitle { get; set; }
        public string Path { get; set; }
        public string MetaDescription { get; set; }
        public string Colour { get; set; }
        public string Image { get; set; }
        public Guid? CategoryId { get; set; }

        public virtual Category CategoryNavigation { get; set; }
        public virtual ICollection<Category> InverseCategoryNavigation { get; set; }
        public virtual ICollection<Topic> Topic { get; set; }
    }
}
