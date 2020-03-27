using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Story.Models
{
    public class ValueFrequency
    {
        [Key] public int Id { get; set; }
        [Required] public string Description { get; set; }
        [Required] public string Hint { get; set; }

        public List<Story> Stories { get; set; }
    }
}
