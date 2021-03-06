﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.BE.Contracts.DTO;
using System.ServiceModel.Channels;
using System.ServiceModel;
using Chat.BE.Contracts.Faults;

namespace Chat.BE.Contracts.Proxies
{
    public class RoomServiceProxy : ClientBase<IRoomService>, IRoomService
    {
        //private readonly ChannelFactory<IRoomService> _factory;
        //private readonly IRoomService _proxy;

        public RoomServiceProxy(): base("cliConf")
        {
            //_factory = new ChannelFactory<IRoomService>("cliConf");
            
            //_proxy = _factory.CreateChannel();
            
            
        }

        public void Add(RoomDTO room)
        {
            try
            {
                this.Channel.Add(room);
            }
            catch(FaultException<FaultDataContract> exc)
            {
                //TODO: Logger
            }
        }

        public IEnumerable<RoomDTO> GetAll()
        {
            try
            {
                var data = this.Channel.GetAll();
                return data;
            }
            catch(FaultException<FaultDataContract> exc)
            {
                //TODO logger
                return null;
            }
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
           
        }
    }
}
