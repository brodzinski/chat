﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.BE.Infrastructure.CQRS
{
    public interface ICommandDispatcher
        
    {
        IStatusResult Execute<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
