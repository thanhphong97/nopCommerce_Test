using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Core.Domain.VerifyCodes
{
    public partial class VerifyCode: BaseEntity
    {
        public string Email { get; set; }

        public string Code { get; set; }

        public bool isActive { get; set; }
    }
}
