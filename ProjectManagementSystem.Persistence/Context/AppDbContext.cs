using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectManagementSystem.Domain.Entities;

namespace ProjectManagementSystem.Persistence.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Project> Projects { get; set; }

    public DbSet<TaskItem> Tasks { get; set; }

    public DbSet<Notification> Notifications { get; set; }
}
