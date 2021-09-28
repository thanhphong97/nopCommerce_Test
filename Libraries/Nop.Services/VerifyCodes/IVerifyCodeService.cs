using Nop.Core.Domain.VerifyCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Services.VerifyCodes
{
    public partial interface IVerifyCodeService
    {
        /// <summary>
        /// Gets a verify code
        /// </summary>
        /// <param name="email">The custom order number</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the order
        /// </returns>
        Task<VerifyCode> GetVerifyCodeByEmailAsync(string email);

        /// <summary>
        /// update a verify code
        /// </summary>
        /// <param name="verifyCode">The verification code</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the order
        /// </returns>
        Task UpdateVerifyCodeAsync(VerifyCode verifyCode);

        /// <summary>
        /// insert a verify code
        /// </summary>
        /// <param name="verifyCode">The verification code</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the order
        /// </returns>
        Task InsertVerifyCodeAsync(VerifyCode verifyCode);

    }
}
