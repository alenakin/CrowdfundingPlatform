using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace CrowdfundingPlatform.Models
{
    public class User : IdentityUser
    {
        public List<Project> Projects { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Contribution> Contributions { get; set; }

        public List<Rating> Ratings { get; set; }
    }
}
