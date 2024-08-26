using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Models;
using System.Reflection.Emit;

namespace Contexts
{
    public class GerenciadorTarefasDbContext : DbContext
    {
       public GerenciadorTarefasDbContext(DbContextOptions<GerenciadorTarefasDbContext> configuracoes) : base(configuracoes)
       {} 

       public DbSet<TaskModel> Tasks {get; set;}
       public DbSet<User> Users {get; set;}


        protected override void OnModelCreating(ModelBuilder DatabaseConstructor)
        {
            base.OnModelCreating(DatabaseConstructor);

            DatabaseConstructor.Entity<TaskModel>()
                .HasOne(t => t.User)
                .WithMany()
                .HasForeignKey(x => x.IdUser);
           
        }
    }
}

