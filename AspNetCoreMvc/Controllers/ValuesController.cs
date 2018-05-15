﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNetCoreMvc.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/Values 
        [HttpGet]
        public int Get([FromQuery] int a, [FromQuery] int b)
        {
            return a + b;
        }

        // GET api/Values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
