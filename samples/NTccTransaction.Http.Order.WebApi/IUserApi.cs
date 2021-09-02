using NTccTransaction.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClientCore;
using WebApiClientCore.Attributes;

namespace NTccTransaction.Http.Order.WebApi
{
    public interface IUserApi: IHttpApi
    {
        [HttpPost("User/Record")]
        Task<string> Record([JsonContent] TransactionContext transactionContext = null);
    }
}
