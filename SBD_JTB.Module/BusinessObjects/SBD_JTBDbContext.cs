using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;

namespace SBD_JTB.Module.BusinessObjects {
	public class SBD_JTBDbContext : DbContext {
		public SBD_JTBDbContext(String connectionString)
			: base(connectionString) {
		}
		public SBD_JTBDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public SBD_JTBDbContext()
			: base("name=ConnectionString") {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
	}
}