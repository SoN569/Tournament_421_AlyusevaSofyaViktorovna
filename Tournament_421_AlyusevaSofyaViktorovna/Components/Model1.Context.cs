﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_421_AlyusevaSofyaViktorovna.Components
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TournamentDB_421_AlyusevaSofyaEntities : DbContext
    {
        public TournamentDB_421_AlyusevaSofyaEntities()
            : base("name=TournamentDB_421_AlyusevaSofyaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GroupRole> GroupRole { get; set; }
        public virtual DbSet<GroupUser> GroupUser { get; set; }
        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Stats> Stats { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TournamentStatus> TournamentStatus { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Tournaments> Tournaments { get; set; }
    }
}
