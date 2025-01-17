// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> A domain name that a service is reached at, including details of the current connection status. </summary>
    public partial class EndpointDependency
    {
        /// <summary> Initializes a new instance of EndpointDependency. </summary>
        public EndpointDependency()
        {
            EndpointDetails = new ChangeTrackingList<EndpointDetail>();
        }

        /// <summary> Initializes a new instance of EndpointDependency. </summary>
        /// <param name="domainName"> The domain name of the dependency. </param>
        /// <param name="endpointDetails"> The ports used when connecting to DomainName. </param>
        internal EndpointDependency(string domainName, IList<EndpointDetail> endpointDetails)
        {
            DomainName = domainName;
            EndpointDetails = endpointDetails;
        }

        /// <summary> The domain name of the dependency. </summary>
        public string DomainName { get; set; }
        /// <summary> The ports used when connecting to DomainName. </summary>
        public IList<EndpointDetail> EndpointDetails { get; }
    }
}
