using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Story.Models
{
    public class Story
    {
        [Key] public int Id { get; set; }
        [Required] [DisplayName("Create Date")] public DateTime CreateDate { get; set; }
        [Required] [DisplayName("Update Date")] public DateTime UpdateDate { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Body { get; set; }
        [Required] public string Creator { get; set; }
        
        public List<Comment> Comments { get; set; }

        [Required] [DisplayName("Value Weight")] public int ValueWeightId { get; set; }
        public virtual ValueWeight ValueWeight { get; set; }

        [DisplayName("Effort Weight")] public int? EffortWeightId { get; set; }
        public virtual EffortWeight EffortWeight { get; set; }

        [Required] [DisplayName("Value Frequency")] public int ValueFrequencyId { get; set; }
        public virtual ValueFrequency ValueFrequency { get; set; }

        [Required] [DisplayName("Value Type")] public int ValueTypeId { get; set; }
        public virtual ValueType ValueType { get; set; }

        [Required] [DisplayName("Status")] public int StatusId { get; set; }
        public virtual Status Status { get; set; }

        [Required] [DisplayName("Group")] public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
