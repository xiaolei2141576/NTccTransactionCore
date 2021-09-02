using NTccTransaction.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTccTransaction.Http.Order.WebApi
{
    public interface IUserProxy
    {
        Task<string> Record(TransactionContext transactionContext);

    }

    public class UserProxy : IUserProxy, INTccTransactionService
    {
        private readonly IUserApi _userApi;
        public UserProxy(IUserApi userApi)
        {
            _userApi = userApi;
        }

        [Compensable(CancelMethod = "Record", ConfirmMethod = "Record", Propagation = Propagation.SUPPORTS)]
        public async Task<string> Record(TransactionContext transactionContext = null)
        {
            return await _userApi.Record(transactionContext);

        }
    }
}
