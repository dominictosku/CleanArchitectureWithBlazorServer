﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace CleanArchitecture.Blazor.Domain.Events;

    public class ProductDeletedEvent : DomainEvent
    {
        public ProductDeletedEvent(Product item)
        {
            Item = item;
        }

        public Product Item { get; }
    }
