using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VideoStoreManagement.Models;

namespace VideoStoreManagement.Data
{
    public class VideoStoreManagementContext : DbContext
    {
        public VideoStoreManagementContext (DbContextOptions<VideoStoreManagementContext> options)
            : base(options)
        {
        }

        public DbSet<VideoStoreManagement.Models.Customer> Customer { get; set; }

        public DbSet<VideoStoreManagement.Models.Movie> Movie { get; set; }

        public DbSet<VideoStoreManagement.Models.MovieRental> MovieRental { get; set; }
    }
}
