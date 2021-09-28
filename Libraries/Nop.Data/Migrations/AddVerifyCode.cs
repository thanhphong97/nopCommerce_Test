using FluentMigrator;
using Nop.Core.Domain.VerifyCodes;

namespace Nop.Data.Migrations
{
	[NopMigration("2021/09/28 09:00:16:2551770", "Add new table VerifyCode")]
	public class AddVerifyCode : AutoReversingMigration
	{
		//public override void Up()
		//{
		//	Create.Table(nameof(VerifyCode))
		//		.WithColumn(nameof(VerifyCode.Email)).AsString(1000).Nullable()
		//		.WithColumn(nameof(VerifyCode.Code)).AsString(400).Nullable()
		//		.WithColumn(nameof(VerifyCode.isActive)).AsBoolean().Nullable();
		//}

		protected IMigrationManager _migrationManager;

		public AddVerifyCode(IMigrationManager migrationManager)
		{
			_migrationManager = migrationManager;
		}

		public override void Up()
		{
			_migrationManager.BuildTable<VerifyCode>(Create);
		}
	}
}
