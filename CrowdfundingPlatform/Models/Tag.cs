using System.Collections.Generic;

namespace CrowdfundingPlatform.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public List<ProjectTag> ProjectTags { get; set; }

        public Tag()
        {
            ProjectTags = new List<ProjectTag>();
        }
    }
}
