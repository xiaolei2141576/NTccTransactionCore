using Microsoft.Extensions.Logging;
using NTccTransaction.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTccTransaction.Http.User.WebApi
{
    public class UserService : IUserService, INTccTransactionService
    {
        private readonly ILogger<UserService> _logger;

        public UserService(ILogger<UserService> logger)
        {
            _logger = logger;
        }

        [Compensable(CancelMethod = "CancelRecord", ConfirmMethod = "ConfirmRecord")]
        public async Task<string> Record(TransactionContext transactionContext)
        {
            _logger.LogInformation("UserService.Record");

            return await Task.FromResult("User Return");
        }

        public void ConfirmRecord(TransactionContext transactionContext = null)
        {
            _logger.LogInformation("UserService.ConfirmRecord");
        }

        public void CancelRecord(TransactionContext transactionContext = null)
        {
            _logger.LogInformation("UserService.CancelRecord");
        }
    }
}
