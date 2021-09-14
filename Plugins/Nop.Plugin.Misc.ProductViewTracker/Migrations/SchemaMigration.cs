using FluentMigrator;
using Nop.Data.Mapping;
using Nop.Data.Migrations;
using Nop.Plugin.Misc.ProductViewTracker.Domains;
using Nop.Data.Extensions;

namespace Nop.Plugin.Misc.ProductViewTracker.Migrations
{
	[SkipMigrationOnUpdate]
	[NopMigration("2021/09/09 14:01:16:2551770", "create table ProductViewTrackerRecords")]
	public class SchemaMigration : AutoReversingMigration
	{
		private readonly IMigrationManager _migrationManager;

		public SchemaMigration(IMigrationManager migrationManager)
		{
			_migrationManager = migrationManager;
		}

		/// <summary>
		/// Collect the UP migration expressions
		/// </summary>
		public override void Up()
		{
			_migrationManager.BuildTable<ProductViewTrackerRecords>(Create);
		}
	}
}
