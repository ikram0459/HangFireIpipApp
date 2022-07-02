using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using PersonalService;

namespace HangFireIpipApp.Controllers
{
    public class HangFireController : ControllerBase
    {
        private readonly IMyPersonalService _myPersonalService;
        public HangFireController(IMyPersonalService myPersonalService)
        {
            _myPersonalService = myPersonalService;
        }

        [Route("Api/HangFire")]
        public IActionResult Index()
        {
            //_myPersonalService.RunMyTask();

            RecurringJob.AddOrUpdate("IpipTestJob1", () => this._myPersonalService.RunMyTask(), Cron.Minutely);

            return Ok();
        }
    }
}
