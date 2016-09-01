using DemoConcurrency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoConcurrency.Helper
{
    public class DataInit : System.Data.Entity.DropCreateDatabaseIfModelChanges<DbTestContext>
    {
        protected override void Seed(DbTestContext context)
        {
            var accounts = new List<Account>
            {
                new Account{Name="Huy",Address= "MNL", PhoneNumber = "0123456789"},
                new Account{Name="Huy Nguyen Quang",Address= "MNL", PhoneNumber = "987654321"},
                new Account{Name="Hugo",Address= "MNL", PhoneNumber = "123498765"},
            };

            accounts.ForEach(s => context.Accounts.Add(s));
            context.SaveChanges();

            var banks = new List<Bank>
            {
                new Bank{Id=1, AccountId = 1, Balance = 0},
                new Bank{Id=2, AccountId = 2, Balance = 0},
                new Bank{Id=3, AccountId = 3, Balance = 0},
            };
            banks.ForEach(s => context.Banks.Add(s));
            context.SaveChanges();
        }
    }
}