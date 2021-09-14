using FluentMigrator;
using Nop.Core.Domain.Catalog;

namespace Nop.Data.Migrations
{
	[NopMigration("2021/09/06 21:00:16:2551770", "Product. Add Release Date")]
	public class AddRealeaseDate : AutoReversingMigration
	{
		public override void Up()
		{
			//Create.Column(nameof(Product.ReleaseDate))
			//	.OnTable(nameof(Product))
			//	.AsDateTime()
			//	.Nullable();

			//Alter.Table(nameof([Product]).AlterColumn(nameof(Product.ReleaseDates).)
			
		}
	}
}
