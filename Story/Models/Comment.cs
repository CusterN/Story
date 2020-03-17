using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Story.Models
{
    public class Comment
    {
        [Key] public int Id { get; set; }
        [Required] public DateTime CreateDate { get; set; }
        [Required] public string Creator { get; set; }
        [Required] public string Body { get; set; }
        [Required] public Boolean Visible { get; set; }

        [Required] public int StoryId { get; set; }
        public virtual Story Story { get; set; }
    }
}
