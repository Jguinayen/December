using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Petshopmvc.Models
{
    public class CalendarContext : DbContext
    {
        public CalendarContext()
            : base("SQLConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CalendarContext>());
        }
        public System.Data.Entity.DbSet<Petshopmvc.Models.Appointment> Appointments { get; set; }
    }
}

