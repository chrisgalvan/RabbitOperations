﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitOperations.Domain.Configuration
{
    public class KeyMappingConfigurationDocument
    {
        public int Id { get; set; }
        public IList<MessageTypeHandling> MessageHandlingInstructions { get; set; }
    }
}