using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NTccTransaction.Abstractions;
using NTccTransaction.Http.User.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTccTransaction.Http.Users.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IUserService _UserService;

        public UserController(ILogger<UserController> logger, IUserService UserService)
        {
            _logger = logger;
            _UserService = UserService;
        }

        [HttpPost("[action]")]
        public async Task<string> RecordAsync(TransactionContext transactionContext)
        {
            return await _UserService.Record(transactionContext);
        }

        [HttpGet]
        public async Task<string> get()
        {
            return await Task.FromResult("test");
        }
    }
}
