using Microsoft.EntityFrameworkCore;

namespace Budget_Tracker.Data
{
    public class BudgetTrackerDbContext : DbContext
    {
        public BudgetTrackerDbContext(DbContextOptions<BudgetTrackerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BudgetTransaction> BudgetTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BudgetTransaction>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("integer");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.TransactionAmount)
                    .IsRequired()
                    .HasColumnName("transaction_amount")
                    .HasColumnType("integer");

                entity.Property(e => e.CreateDate)
                    .IsRequired()
                    .HasColumnName("create_date")
                    .HasColumnType("timestamp without time zone");

                entity.ToTable("budget_transactions_tbl");
            });
        }
    }
}
