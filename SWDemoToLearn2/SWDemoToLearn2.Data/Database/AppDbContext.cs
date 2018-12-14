/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using Microsoft.EntityFrameworkCore;

namespace SWDemoToLearn2.Data.Database
{
    public class AppDbContext : BaseDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
