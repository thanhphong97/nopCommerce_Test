using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nop.Web.Models.VerifyCode
{
    public partial record VerifyCodeModel: BaseNopModel
    {
        #region Properties
        [NopResourceDisplayName("Account.Login.VerifyCode.Email")]
        public string Email { get; set; }

        [NopResourceDisplayName("Account.Login.VerifyCode.Code")]
        public string Code { get; set; }

        [NopResourceDisplayName("Account.Login.VerifyCode.isActive")]
        public bool isActive { get; set; }
        #endregion
    }
}
