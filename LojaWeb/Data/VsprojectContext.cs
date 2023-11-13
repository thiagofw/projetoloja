using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LojaWeb.Data;

public partial class VsprojectContext : DbContext
{
    public VsprojectContext()
    {
    }

    public VsprojectContext(DbContextOptions<VsprojectContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
