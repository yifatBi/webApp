
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;

namespace proj.Models
{
    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
       
    }
    public class Class1Db : System.Data.Entity.DbContext
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public System.Data.Entity.DbSet<proj.Models.Class1> Class1 { get; set; }
    }
}