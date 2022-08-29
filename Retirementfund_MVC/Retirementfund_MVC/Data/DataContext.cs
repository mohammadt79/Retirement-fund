using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  Microsoft.EntityFrameworkCore;
namespace Retirementfund_MVC.Data
{
    public class DataContext :DbContext
    {
        public  DataContext(DbContextOptions<DataContext> options):base(options){}
        public DbSet<Models.Users> Users { get; set; }
        public DbSet<Models.FundModel> Fund { get; set; }
        public DbSet<Models.Request> Request { get; set; }
        public DbSet<Models.TheConferenceModel> TheConference  { get; set; }
        public DbSet<Models.AspUserLoginModel> AspUserLogin { get; set; }

    }
}
