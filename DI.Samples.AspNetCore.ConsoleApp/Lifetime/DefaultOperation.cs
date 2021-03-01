﻿using System;

namespace DI.Samples.AspNetCore.ConsoleApp.Lifetime
{
    public class DefaultOperation :
        ITransientOperation,
        IScopedOperation,
        IAnotherScopedOperation,
        ISingletonOperation
    {
        public string OperationId { get; } = Guid.NewGuid().ToString()[^4..];

        public DefaultOperation(Guid operationId)
        {
            OperationId = operationId.ToString()[^4..];
        }

        public DefaultOperation()
        {

        }
    }
}
