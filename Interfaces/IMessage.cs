using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HFA.Messaging.Interfaces
{
    public interface IMessage
    {
        Guid MessageId { get; }
        DateTime CreatedAt { get; }
        string CorrelationId { get; }
    }
}