using NTccTransaction.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTccTransaction.Http.User.WebApi
{
    public interface IUserService
    {
        Task<string> Record(TransactionContext transactionContext);
    }
}
