﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitOperations.Collector.MessageParser.Interfaces;
using RabbitOperations.Domain;

namespace RabbitOperations.Collector.MessageRetry.Interfaces
{
    public interface ISendMessages
    {
        /// <summary>
        /// Sends a message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="queueName"></param>
        /// <param name="applicationId"></param>
        /// <param name="basicProperties"></param>
        /// <returns>Null on success or the text of an error message</returns>
        string Send(IRawMessage message, string queueName, string applicationId, IBasicProperties basicProperties);
    }
}
