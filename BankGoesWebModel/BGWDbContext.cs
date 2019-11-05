using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;    

namespace BankGoesWebModel
{
    public class BGWDbContext : DbContext
    {
        public BGWDbContext(DbContextOptions<BGWDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
