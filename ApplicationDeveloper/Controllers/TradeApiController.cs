using ApplicationDeveloper.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApplicationDeveloper.Controllers
{
    public class TradeApiController : ApiController
    {
        // GET: TradeApi
        public IHttpActionResult Index()
        {
            var repo = new TradeRepository();
            var trades = repo.GetTrades();
            return Ok(trades);
        }
    }
}