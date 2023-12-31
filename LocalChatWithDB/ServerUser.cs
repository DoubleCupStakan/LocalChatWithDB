﻿using System.ServiceModel;

namespace LocalChatWithDB
{
    internal class ServerUser
    {
        public int ID { get; set; }

        public string Password { get; set; } 

        public string Name { get; set; }

        public OperationContext operationContext { get; set; }
    }
}
