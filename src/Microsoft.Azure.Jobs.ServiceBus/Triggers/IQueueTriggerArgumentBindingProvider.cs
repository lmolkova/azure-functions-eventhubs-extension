﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Reflection;
using Microsoft.Azure.Jobs.Host.Bindings;
using Microsoft.ServiceBus.Messaging;

namespace Microsoft.Azure.Jobs.ServiceBus.Triggers
{
    internal interface IQueueTriggerArgumentBindingProvider
    {
        IArgumentBinding<BrokeredMessage> TryCreate(ParameterInfo parameter);
    }
}