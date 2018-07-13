using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpotHub.Data
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public virtual ApplicationUser Manager { get; set; }
        public virtual ICollection<ApplicationUser> Team { get; set; }
    }
}