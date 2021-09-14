using FluentMigrator;
using Nop.Core.Domain.Catalog;

namespace Nop.Data.Migrations
{
	[NopMigration("2021/09/06 22:00:16:2551770", "Product. Add Release Dates")]
	public class AddRealeaseDates : AutoReversingMigration
	{
		public override void Up()
		{
				Create.Column(nameof(Product.ReleaseDates))
				.OnTable(nameof(Product))
				.AsDateTime()
				.WithDefaultValue(System.DateTime.Now);
		}
	}
}
