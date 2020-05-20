using survey_demo_api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace survey_demo_api.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDbContext>());
        }
        public DbSet<Survey> Survey { get; set; }
    }
}