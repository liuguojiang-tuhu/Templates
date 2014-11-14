﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Petshop.Data
{
    public partial class PetshopContext
        : System.Data.Entity.DbContext
    {
        public PetshopContext()
            :base("Name=PetshopContext")
        {
            InitializeContext();
        }

        public PetshopContext(System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base("Name=PetshopContext", model)
        {
            InitializeContext();
        }

        public PetshopContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            InitializeContext();
        }

        public PetshopContext(string nameOrConnectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(nameOrConnectionString, model)
        {
            InitializeContext();
        }

        public PetshopContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializeContext();
        }

        public PetshopContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializeContext();
        }

        public System.Data.Entity.DbSet<Petshop.Data.Entities.Account> Accounts { get; set; }
        public System.Data.Entity.DbSet<Petshop.Data.Entities.BannerData> BannerDatas { get; set; }
        public System.Data.Entity.DbSet<Petshop.Data.Entities.Category> Categories { get; set; }
        public System.Data.Entity.DbSet<Petshop.Data.Entities.Inventory> Inventories { get; set; }
        public System.Data.Entity.DbSet<Petshop.Data.Entities.Item> Items { get; set; }
        public System.Data.Entity.DbSet<Petshop.Data.Entities.Product> Products { get; set; }
        public System.Data.Entity.DbSet<Petshop.Data.Entities.Supplier> Suppliers { get; set; }
        public System.Data.Entity.DbSet<Petshop.Data.Entities.LineItem> LineItems { get; set; }
        public System.Data.Entity.DbSet<Petshop.Data.Entities.Orders> Orders { get; set; }
        public System.Data.Entity.DbSet<Petshop.Data.Entities.OrderStatus> OrderStatuses { get; set; }
        public System.Data.Entity.DbSet<Petshop.Data.Entities.Profile> Profiles { get; set; }
        public System.Data.Entity.DbSet<Petshop.Data.Entities.SignOn> SignOns { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Petshop.Data.Mapping.AccountMap());
            modelBuilder.Configurations.Add(new Petshop.Data.Mapping.BannerDataMap());
            modelBuilder.Configurations.Add(new Petshop.Data.Mapping.CategoryMap());
            modelBuilder.Configurations.Add(new Petshop.Data.Mapping.InventoryMap());
            modelBuilder.Configurations.Add(new Petshop.Data.Mapping.ItemMap());
            modelBuilder.Configurations.Add(new Petshop.Data.Mapping.ProductMap());
            modelBuilder.Configurations.Add(new Petshop.Data.Mapping.SupplierMap());
            modelBuilder.Configurations.Add(new Petshop.Data.Mapping.LineItemMap());
            modelBuilder.Configurations.Add(new Petshop.Data.Mapping.OrdersMap());
            modelBuilder.Configurations.Add(new Petshop.Data.Mapping.OrderStatusMap());
            modelBuilder.Configurations.Add(new Petshop.Data.Mapping.ProfileMap());
            modelBuilder.Configurations.Add(new Petshop.Data.Mapping.SignOnMap());

            InitializeMapping(modelBuilder);
        }

        partial void InitializeContext();
        partial void InitializeMapping(System.Data.Entity.DbModelBuilder modelBuilder);
    }
}