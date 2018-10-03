// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The JobResourceUpdateParameter.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class JobResourceUpdateParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobResourceUpdateParameter class.
        /// </summary>
        public JobResourceUpdateParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobResourceUpdateParameter class.
        /// </summary>
        /// <param name="details">Details of a job to be updated.</param>
        /// <param name="destinationAccountDetails">Destination account
        /// details.</param>
        /// <param name="tags">The list of key value pairs that describe the
        /// resource. These tags can be used in viewing and grouping this
        /// resource (across resource groups).</param>
        public JobResourceUpdateParameter(UpdateJobDetails details = default(UpdateJobDetails), IList<DestinationAccountDetails> destinationAccountDetails = default(IList<DestinationAccountDetails>), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Details = details;
            DestinationAccountDetails = destinationAccountDetails;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets details of a job to be updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.details")]
        public UpdateJobDetails Details { get; set; }

        /// <summary>
        /// Gets or sets destination account details.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destinationAccountDetails")]
        public IList<DestinationAccountDetails> DestinationAccountDetails { get; set; }

        /// <summary>
        /// Gets or sets the list of key value pairs that describe the
        /// resource. These tags can be used in viewing and grouping this
        /// resource (across resource groups).
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Details != null)
            {
                Details.Validate();
            }
            if (DestinationAccountDetails != null)
            {
                foreach (var element in DestinationAccountDetails)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
