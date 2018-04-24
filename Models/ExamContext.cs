using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
 
namespace newexam.Models
{
    public class ExamContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public ExamContext(DbContextOptions<ExamContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
