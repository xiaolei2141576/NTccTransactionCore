using Microsoft.EntityFrameworkCore;
using NTccTransaction.MySql;
using NTccTransaction;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class NTccTransactionOptionsExtensions
    {

        public static NTccTransactionOptions UseMySql(this NTccTransactionOptions options, Action<MySqlOptions> configure)
        {
            if (configure == null)
            {
                throw new ArgumentNullException(nameof(configure));
            }

            options.RegisterExtension(new MySqlNTccTransactionOptionsExtension(x =>
            {
                configure(x);
            }));

            return options;
        }

    }
}