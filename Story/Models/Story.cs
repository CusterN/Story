using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Story.Models
{
    public class Story
    {
        [Key] public int Id { get; set; }
        [Required] public DateTime CreateDate { get; set; }
        [Required] public DateTime UpdateDate { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Body { get; set; }
        [Required] public string Creator { get; set; }
        [Required] public Boolean Visible { get; set; }

        public List<Comment> Comments { get; set; }

        [Required] public int ValueWeightId { get; set; }
        public virtual ValueWeight ValueWeight { get; set; }

        [Required] public int ValueFrequencyId { get; set; }
        public virtual ValueFrequency ValueFrequency { get; set; }

        [Required] public int ValueTypeId { get; set; }
        public virtual ValueType ValueType { get; set; }

        [Required] public int StatusId { get; set; }
        public virtual Status Status { get; set; }

        [Required] public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
