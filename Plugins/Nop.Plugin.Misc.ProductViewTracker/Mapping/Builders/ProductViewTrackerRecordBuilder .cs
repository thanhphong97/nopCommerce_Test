using FluentMigrator.Builders.Create.Table;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Customers;
using Nop.Data.Mapping.Builders;
using Nop.Plugin.Misc.ProductViewTracker.Domains;
using Nop.Data.Extensions;
using System.Data;

namespace Nop.Plugin.Misc.ProductViewTracker.Mapping.Builders
{
    public class ProductViewTrackerRecordBuilder : NopEntityBuilder<ProductViewTrackerRecords>
    {
        #region Methods

        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            //map the primary key 
            table.WithColumn(nameof(ProductViewTrackerRecords.Id)).AsInt32().NotNullable().PrimaryKey().Identity()
           //map the additional properties as foreign keys
           .WithColumn(nameof(ProductViewTrackerRecords.ProductId)).AsInt32().ForeignKey<Product>(onDelete: Rule.Cascade)
            .WithColumn(nameof(ProductViewTrackerRecords.CustomerId)).AsInt32().ForeignKey<Customer>(onDelete: Rule.Cascade)
            //avoiding truncation/failure
            //so we set the same max length used in the product name
            .WithColumn(nameof(ProductViewTrackerRecords.ProductName)).AsString(400)
            .WithColumn(nameof(ProductViewTrackerRecords.IpAddress)).AsString()
            .WithColumn(nameof(ProductViewTrackerRecords.IsRegistered)).AsBoolean()
            .WithColumn(nameof(ProductViewTrackerRecords.logTime)).AsDateTime2();
        }

        #endregion
    }
}