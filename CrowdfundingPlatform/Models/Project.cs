using System;
using System.Collections.Generic;

namespace CrowdfundingPlatform.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        //public string ImageUrl { get; set; }
        public decimal Target { get; set; }
        public decimal CurrentSum { get; set; }

        public List<Rating> Ratings { get; set; }

        public List<ProjectTag> ProjectTags { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Contribution> Contributions { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public Project()
        {
            ProjectTags = new List<ProjectTag>();
        }
    }
}
