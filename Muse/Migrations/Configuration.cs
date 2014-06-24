namespace Muse.Migrations
{
    using Muse.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<RestoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RestoContext context)
        {
            var now = DateTime.Now;
            var rand = new Random();
            var genders = Enum.GetValues(typeof(Gender));
            int i;

            var users = new List<User>();
            var products = new List<Product>();
            var customers = new List<Customer>();
            var bills = new List<Bill>();
            var orders = new List<Order>();

            var accounts = new[] { "Admin", "User" };
            var names = new[]
            {
                "Jackson", "Aiden", "Liam", "Lucas", "Noah", "Mason", "Jayden", "Ethan", "Jacob", "Jack",
                "Caden", "Logan", "Benjamin", "Michael", "Caleb", "Sophia", "Emma", "Olivia", "Isabella", "Mia",
                "Ava", "Lily", "Zoe", "Emily", "Chloe", "Layla", "Madison", "Madelyn", "Abigail", "Aubrey"
            };
            var menus = new[] { "Nasi Goreng Ayam", "Soto Medan", "Sate Padang Special", "Lontong Sayur", "Pecel Lele", "Nasi Kangkung Belacan" };
            var addresses = new[]
            {
                "Wahidin", "Gatot Subroto", "Yos Sudarso", "Asia", "Thamrin", "Aksara", "Guru Patimpus", "Bakaran Batu", "Krakatau", "Sutomo",
                "Iskandar Muda", "Jamin Ginting", "Katamso", "Yos Rizal", "Sudirman", "Multatuli", "Diponegoro", "Gajah Mada", "Irian Barat", "Pemuda"
            };

            i = 0;
            foreach (var account in accounts)
            {
                var lower = account.ToLower();
                users.Add(new User
                {
                    Id = ++i,
                    Name = account,
                    Email = lower + "@muse.com",
                    Username = lower,
                    Password = Utility.SHA1Digest(lower),
                    Address = "Jl. " + addresses[rand.Next(addresses.Length)] + ", Medan",
                    Phone = String.Format("0878-{0}-{1}", rand.Next(1000, 10000), rand.Next(1000, 10000)),
                    Gender = (Gender)genders.GetValue(rand.Next(genders.Length)),
                    CreatedAt = now,
                    UpdatedAt = now
                });
            }

            i = 0;
            foreach (var menu in menus)
            {
                products.Add(new Product
                {
                    Id = ++i,
                    Name = menu,
                    Description = menu,
                    Price = rand.Next(10, 100) * 1000,
                    CreatedAt = now,
                    UpdatedAt = now
                });
            }

            i = 0;
            foreach (var name in names)
            {
                customers.Add(new Customer
                {
                    Id = ++i,
                    Name = name,
                    Email = name.ToLower() + "@gmail.com",
                    Address = "Jl. " + addresses[rand.Next(addresses.Length)] + ", Medan",
                    Phone = String.Format("0878-{0}-{1}", rand.Next(1000, 10000), rand.Next(1000, 10000)),
                    Gender = (Gender)genders.GetValue(rand.Next(genders.Length)),
                    CreatedAt = now,
                    UpdatedAt = now
                });
            }

            i = 0;
            customers.ForEach(customer =>
            {
                bills.Add(new Bill
                {
                    Id = ++i,
                    CustomerId = customer.Id,
                    Paid = rand.NextDouble() < 0.5,
                    Tax = rand.NextDouble() < 0.5 ? 0.1 : 0,
                    CreatedAt = now,
                    UpdatedAt = now
                });
            });

            bills.ForEach(bill =>
            {
                orders.Add(new Order
                {
                    BillId = bill.Id,
                    ProductId = products[rand.Next(products.Count)].Id,
                    Quantity = rand.Next(1, 10),
                    CreatedAt = now,
                    UpdatedAt = now
                });
            });

            context.Users.AddOrUpdate(x => x.Name, users.ToArray());
            context.Products.AddOrUpdate(x => x.Name, products.ToArray());
            context.Customers.AddOrUpdate(x => x.Name, customers.ToArray());
            context.Bills.AddOrUpdate(x => x.CustomerId, bills.ToArray());
            context.Orders.AddOrUpdate(x => new { x.BillId, x.ProductId }, orders.ToArray());
        }
    }
}