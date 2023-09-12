using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankingWebApi.Models;

namespace BankingWebApi.Data
{
    public class BankingWebApiContext : DbContext
    {
        public BankingWebApiContext (DbContextOptions<BankingWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Account> Accounts { get; set; } = default!;
    }
}
