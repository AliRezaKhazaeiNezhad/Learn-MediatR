﻿using MediatR;

namespace KhN.Server.Commands
{
    /// <summary>
    /// Command
    /// Without Result
    /// ASync
    /// </summary>
    public class DoSomeCode2Command : IRequest
    {
        public DoSomeCode2Command()
        {

        }


        public string SomeProperty { get; set; }
    }
}
