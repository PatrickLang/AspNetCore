// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Routing;

namespace Microsoft.AspNetCore.Builder
{
    public static class CorsEndpointConventionBuilderExtensions
    {
        public static IEndpointConventionBuilder WithCorsPolicy(this IEndpointConventionBuilder builder, string policyName)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Apply(endpointBuilder =>
            {
                endpointBuilder.Metadata.Add(new EnableCorsAttribute(policyName));
            });
            return builder;
        }
    }
}
