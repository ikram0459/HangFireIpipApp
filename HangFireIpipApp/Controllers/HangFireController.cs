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
        [HttpGet]
        public IActionResult Index()
        {
            //_myPersonalService.RunMyTask();

            RecurringJob.AddOrUpdate("IpipTestJob1", () => this._myPersonalService.RunMyTask(), Cron.Minutely);

            return Ok();
        }

        [Route("Api/HangFire2")]
        [HttpGet]
        public IActionResult HangFire2()
        {
            //_myPersonalService.RunMyTask();

            RecurringJob.AddOrUpdate("IpipTestJob2", () => this._myPersonalService.RunMyTask2(), Cron.Minutely);

            return Ok();
        }
    }
}
