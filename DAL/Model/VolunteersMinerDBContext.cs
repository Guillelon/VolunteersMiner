using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL.Model
{
    public class VolunteersMinerDBContext: DbContext
    {
        public DbSet<Poll> Poll { get; set; }
    }
}
