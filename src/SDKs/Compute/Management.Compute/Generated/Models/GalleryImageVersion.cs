// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the gallery Image Version that you want to
    /// create or update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class GalleryImageVersion : Resource
    {
        /// <summary>
        /// Initializes a new instance of the GalleryImageVersion class.
        /// </summary>
        public GalleryImageVersion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryImageVersion class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="provisioningState">The current state of the gallery
        /// Image Version.</param>
        public GalleryImageVersion(string location, GalleryImageVersionPublishingProfile publishingProfile, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), GalleryImageVersionStorageProfile storageProfile = default(GalleryImageVersionStorageProfile), ReplicationStatus replicationStatus = default(ReplicationStatus))
            : base(location, id, name, type, tags)
        {
            PublishingProfile = publishingProfile;
            ProvisioningState = provisioningState;
            StorageProfile = storageProfile;
            ReplicationStatus = replicationStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingProfile")]
        public GalleryImageVersionPublishingProfile PublishingProfile { get; set; }

        /// <summary>
        /// Gets the current state of the gallery Image Version.
        /// </summary>
        /// <remarks>
        /// The provisioning state, which only appears in the response.
        /// Possible values include: 'Creating', 'Updating', 'Failed',
        /// 'Succeeded', 'Deleting', 'Migrating'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageProfile")]
        public GalleryImageVersionStorageProfile StorageProfile { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.replicationStatus")]
        public ReplicationStatus ReplicationStatus { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (PublishingProfile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PublishingProfile");
            }
            if (PublishingProfile != null)
            {
                PublishingProfile.Validate();
            }
        }
    }
}
