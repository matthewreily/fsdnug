using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TrafficLight.Web.Models;

namespace TrafficLight.Web.Controllers
{
    public class TrafficLightConfigurationsApiController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/TrafficLightConfigurationsApi
        public TrafficLightConfiguration GetTrafficLightConfigurations()
        {
            return db.TrafficLightConfigurations.Any() ? db.TrafficLightConfigurations.First() : new TrafficLightConfiguration(){MaintenanceMode = true};
        }
    }
}