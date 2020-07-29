﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Neurotech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeuroTechController : ControllerBase
    {
        // GET: api/<NeuroTechController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<NeuroTechController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NeuroTechController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NeuroTechController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NeuroTechController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}