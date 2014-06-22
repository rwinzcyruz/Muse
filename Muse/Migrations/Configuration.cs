namespace Muse.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using Muse.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<RestoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RestoContext context)
        {            
            var now = DateTime.Now;

            context.Users.AddOrUpdate(
                i => i.Name,
                new User { Name = "Admin", Email = "admin@muse.com", Username = "admin", Password = "admin", Address = "Jl. Asia, Medan", Phone = "0878-0011-1100", CreatedAt = now, UpdatedAt = now },
                new User { Name = "User", Email = "user@muse.com", Username = "user", Password = "user", Address = "Jl. Gatot Subroto, Medan", Phone = "0878-0088-8800", CreatedAt = now, UpdatedAt = now }
            );

            context.Products.AddOrUpdate(
                i => i.Name,
                new Product { Name = "Nasi Goreng Ayam", Description = "Nasi Goreng Ayam", Price = 20000, CreatedAt = now, UpdatedAt = now },
                new Product { Name = "Soto Medan", Description = "Soto Medan", Price = 25000, CreatedAt = now, UpdatedAt = now },
                new Product { Name = "Sate Padang Special", Description = "Sate Padang Special", Price = 10000, CreatedAt = now, UpdatedAt = now }
            );

            context.Customers.AddOrUpdate(
                i => i.Name,
                new Customer { Name = "Aiden", Email = "aiden@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Liam", Email = "liam@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Lucas", Email = "lucas@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Noah", Email = "noah@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Mason", Email = "mason@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Female, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Jayden", Email = "jayden@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Female, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Ethan", Email = "ethan@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Jacob", Email = "jacob@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Jack", Email = "jack@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Caden", Email = "caden@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Female, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Logan", Email = "logan@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Benjamin", Email = "benjamin@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Michael", Email = "michael@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Caleb", Email = "caleb@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Ryan", Email = "ryan@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Alexander", Email = "alexander@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Elijah", Email = "elijah@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Unknown, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "James", Email = "james@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "William", Email = "william@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Oliver", Email = "oliver@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Female, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Connor", Email = "connor@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Matthew", Email = "matthew@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Daniel", Email = "daniel@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Luke", Email = "luke@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Female, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Brayden", Email = "brayden@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Jayce", Email = "jayce@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Henry", Email = "henry@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Carter", Email = "carter@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now },
                new Customer { Name = "Dylan", Email = "dylan@gmail.com", Address = "Jl. Wahidin, Medan", Phone = "0878-1234-5679", Gender = Gender.Male, CreatedAt = now, UpdatedAt = now }
            );
        }
    }
}
