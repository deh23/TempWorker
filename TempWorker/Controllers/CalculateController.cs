using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TempWorker.Models;

namespace TempWorker.Controllers
{
    public class CalculateController : ApiController
    {

        // GET: api/Calculate/5
        [Route("{earnings}")]
        [HttpGet]
        public Calculations Get(string earnings)
        {
            var cals = new Calculations();
            var income = int.Parse(earnings);

            if (income > 8632)
            {
                cals.NationalInsurance = (income - 8632) * (decimal) 0.12;

                if (income > 12500)
                {
                    cals.Tax = (income - 12500) * (decimal)0.20;

                    if (income > 25725)
                    {
                        cals.StudentLoan = (income - 25725) * (decimal)0.09;
                    }
                }
            }

            return  cals;
        }
    }
}
