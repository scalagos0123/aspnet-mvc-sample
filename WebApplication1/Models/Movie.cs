using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "Movie Name")]
        public string Movie_Name { get; set; }
    }

    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}