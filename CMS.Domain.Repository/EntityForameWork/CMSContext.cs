using CMS.Demain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Domain.Repository.EntityForameWork
{

    public class CMSContext:DbContext
    {
        public CMSContext():base("con")
        {
        }
        public virtual DbSet<Sys_Functions> Sys_Functions { get; set; }
        public virtual DbSet<Sys_RoleFunc> Sys_RoleFunc { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Sys_RoleFunc>().HasRequired(a=>a.Sys_Functions);
            base.OnModelCreating(modelBuilder);
        }
    }
}
