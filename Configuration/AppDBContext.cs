using System;
using LOAN_MANAGEMENT_API.Model;
using Microsoft.EntityFrameworkCore;
using Namespace;

namespace LOAN_MANAGEMENT_API.Configuration
{
	public class AppDBContext : DbContext
	{ 
		public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
		{
		}

		public DbSet<LoanType>? loanTypes { get; set; }
		public DbSet<LoanSchedule>? loanSchedules { get; set; }
		public DbSet<Payment>? payments { get; set; }
		public DbSet<Borrow>? borrows { get; set; }
		public DbSet<Loan>? loans { get; set; }
		public DbSet<LoanPlan>? loanPlans { get; set; }
		public DbSet<User>? users { get; set; }
	}
}

