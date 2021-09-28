using System;
using System.Data;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.VerifyCodes;
using Nop.Data.Extensions;
using FluentMigrator.Builders.Create.Table;

namespace Nop.Data.Mapping.Builders.VerifyCodes
{
    public partial class VerifyCodeBuilder : NopEntityBuilder<VerifyCode>
    {
        /// <summary>
        /// Apply entity configuration
        /// </summary>
        /// <param name="table">Create table expression builder</param>
        public override void MapEntity(CreateTableExpressionBuilder table)
        {
            table
               .WithColumn(nameof(VerifyCode.Email)).AsString(1000).Nullable()
               .WithColumn(nameof(VerifyCode.Code)).AsString(400).Nullable()
               .WithColumn(nameof(VerifyCode.isActive)).AsInt32().Nullable();
        }
    }
}
