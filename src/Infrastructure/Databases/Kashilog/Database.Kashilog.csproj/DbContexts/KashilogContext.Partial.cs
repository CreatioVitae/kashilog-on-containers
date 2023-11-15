using Microsoft.EntityFrameworkCore;
using System;

namespace Database.Kashilog.DbContexts;

public partial class KashilogContext {
    readonly string _connectionString;

    readonly bool _consoleLogIsRequired;

    public KashilogContext() { }

    public KashilogContext(string connectionString, bool consoleLogIsRequired = false) =>
        (_connectionString, _consoleLogIsRequired) = (connectionString, consoleLogIsRequired);

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer(_connectionString);

        if (_consoleLogIsRequired) {
            optionsBuilder
                .LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
        }
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder) {
        // Setting Points : Add EDM Patches.
    }
}
