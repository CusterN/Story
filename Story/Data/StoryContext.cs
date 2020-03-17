using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Story.Models;

namespace Story.Data
{
    public class StoryContext : DbContext
    {
        public StoryContext (DbContextOptions<StoryContext> options)
            : base(options)
        {
        }

        public DbSet<Story.Models.Group> Group { get; set; }

        public DbSet<Story.Models.Story> Story { get; set; }

        public DbSet<Story.Models.Status> Status { get; set; }

        public DbSet<Story.Models.ValueFrequency> ValueFrequency { get; set; }

        public DbSet<Story.Models.ValueType> ValueType { get; set; }

        public DbSet<Story.Models.Comment> Comment { get; set; }

        public DbSet<Story.Models.ValueWeight> ValueWeight { get; set; }
    }
}
