﻿using Chat.BE.Contracts.DTO;
using Chat.BE.Contracts.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Chat.FE.Web.Controllers
{
    [Authorize]
    public class RoomsController : ApiController
    {
        
        public IEnumerable<RoomDTO> Get()
        {
            using (RoomServiceProxy proxy = new RoomServiceProxy())
            {
                var rooms = proxy.GetAll();
                return rooms.ToList();                
            }

                
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}