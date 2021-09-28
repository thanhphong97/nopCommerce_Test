using Nop.Core.Caching;
using Nop.Core.Domain.VerifyCodes;
using Nop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Services.VerifyCodes
{
    public partial class VerifyCodeService : IVerifyCodeService
    {
        #region Fields
        private readonly IRepository<VerifyCode> _verifyCodeRepository;
        #endregion

        #region Ctor
        public VerifyCodeService(IRepository<VerifyCode> verifyCodeRepository)
        {
            _verifyCodeRepository = verifyCodeRepository;
        }
        #endregion

        #region Method

        /// <summary>
        /// Gets a verify code
        /// </summary>
        /// <param name="email">The custom email</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the order
        /// </returns>
        public async Task<VerifyCode> GetVerifyCodeByEmailAsync(string email)
        {
            if (string.IsNullOrEmpty(email))
                return null;

            var query = from c in _verifyCodeRepository.Table
                        orderby c.Id
                        where c.Email == email
                        select c;
            var verifyCode = await query.FirstOrDefaultAsync();

            return verifyCode;
        }

        /// <summary>
        /// insert a verify code
        /// </summary>
        /// <param name="verifyCode">The verification code</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the order
        /// </returns>
        public async Task InsertVerifyCodeAsync(VerifyCode verifyCode)
        {
            if (verifyCode == null)
            {
                throw new ArgumentNullException(nameof(verifyCode));
            }

            await _verifyCodeRepository.InsertAsync(verifyCode);
        }

        /// <summary>
        /// update a verify code
        /// </summary>
        /// <param name="verifyCode">The verification code</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the order
        /// </returns>
        public async Task UpdateVerifyCodeAsync(VerifyCode verifyCode)
        {
            if (verifyCode == null)
            {
                throw new ArgumentNullException(nameof(verifyCode));
            }

            await _verifyCodeRepository.UpdateAsync(verifyCode);
        }
        #endregion

    }
}
