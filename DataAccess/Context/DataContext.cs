﻿using Business.Entities;
using DataAccess.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryFeatureOptions> CategoryFeatureOptions { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandModel> BrandModels { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestDetail> RequestDetails { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<CourierContact> CourierContactss { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().Property(p => p.Name).IsRequired();
            builder.Entity<Product>().Property(p => p.CategoryId).IsRequired();
            builder.Entity<Product>().Property(p => p.Quantity).IsRequired();
            builder.Entity<Product>().Property(p => p.IsAvailable).HasDefaultValue(true);
            builder.Entity<Product>().Property(p => p.IsDeleted).HasDefaultValue(false);
            builder.Entity<Product>().Property(p => p.UnitsInStock).HasDefaultValue(0);
            builder.Entity<Product>().Property(p => p.UnitsOnOrder).HasDefaultValue(0);
            builder.Entity<Product>().Property(p => p.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Entity<Product>().HasIndex(p => p.Name);
            builder.Entity<Product>().HasOne(p => p.Parent).WithMany(p => p.Variants).OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Category>().Property(p => p.Name).IsRequired();
            builder.Entity<Category>().HasIndex(p => p.Name);
            builder.Entity<Category>().Property(p => p.IsDeleted).HasDefaultValue(false);

            builder.Entity<Brand>().Property(p => p.Name).IsRequired();
            builder.Entity<Brand>().HasIndex(p => p.Name);
            builder.Entity<Brand>().Property(p => p.IsDeleted).HasDefaultValue(false);

            builder.Entity<Request>().Property(p => p.RequesterId).IsRequired();
            builder.Entity<Request>().Property(p => p.RequestNumber).IsRequired();
            builder.Entity<Request>().HasIndex(p => p.RequestNumber);


            builder.Entity<RequestDetail>().Property(p => p.ProductId).IsRequired();
            builder.Entity<RequestDetail>().Property(p => p.RequestId).IsRequired();

            #region conversions
            var stringValueConverter = new StringListToStringValueConverter();
            var contactTypeValueConverter = new EnumToStringValueConverted();

            builder.Entity<BrandModel>().Property(e => e.Features).HasConversion(stringValueConverter);

            builder.Entity<CategoryFeatureOptions>().Property(e => e.Options).HasConversion(stringValueConverter);

            builder.Entity<CourierContact>().Property(e => e.Type).HasConversion(contactTypeValueConverter);
            #endregion conversions

            //builder.Entity<>
        }
    }
}
