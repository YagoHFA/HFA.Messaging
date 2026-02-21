using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HFA.Messaging.Contracts
{
    public record MessageEnvelope<T>(
        T Payload,
        Guid MessageId,
        DateTime CreatedAt,
        string CorrelationId
    );
}