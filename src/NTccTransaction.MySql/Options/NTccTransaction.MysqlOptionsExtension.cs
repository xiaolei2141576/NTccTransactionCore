using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using NTccTransaction;
using NTccTransaction.Abstractions;
using System;

namespace NTccTransaction.MySql
{
    internal class MySqlNTccTransactionOptionsExtension : INTccTransactionOptionsExtension
    {
        private readonly Action<MySqlOptions> _configure;

        public MySqlNTccTransactionOptionsExtension(Action<MySqlOptions> configure)
        {
            _configure = configure;
        }

        public void AddServices(IServiceCollection services)
        {
            services.AddTransient<ITransactionRepository, TransactionRepository>();
            
            services.Configure(_configure);

            services.AddTransient<TransactionDbContext>();
            services.TryAddTransient(DbContextOptionsFactory.Create<TransactionDbContext>);
        }


    }
}