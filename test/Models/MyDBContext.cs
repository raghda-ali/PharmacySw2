using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class MyDBContext : DbContext{
        public MyDBContext() { }

        public System.Data.Entity.DbSet<test.Models.Pharmacist> pharmacists { get; set; }

    }
}