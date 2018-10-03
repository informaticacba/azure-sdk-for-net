// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.GuestConfiguration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Report for the guest configuration assignment. Report contains
    /// information such as compliance status, reason, and more.
    /// </summary>
    public partial class GuestConfigurationAssignmentReportProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GuestConfigurationAssignmentReportProperties class.
        /// </summary>
        public GuestConfigurationAssignmentReportProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GuestConfigurationAssignmentReportProperties class.
        /// </summary>
        /// <param name="complianceStatus">A value indicating compliance status
        /// of the virtual machine for the assigned guest configuration.
        /// Possible values include: 'Compliant', 'NonCompliant',
        /// 'Pending'</param>
        /// <param name="reportId">GUID that identifies the guest configuration
        /// assignment report under a subscription, resource group.</param>
        /// <param name="assignment">Configuration details of the guest
        /// configuration assignment.</param>
        /// <param name="vm">Information about the VM.</param>
        /// <param name="details">Details of the assignment report.</param>
        public GuestConfigurationAssignmentReportProperties(string complianceStatus = default(string), string reportId = default(string), AssignmentInfo assignment = default(AssignmentInfo), VMInfo vm = default(VMInfo), AssignmentReportDetails details = default(AssignmentReportDetails))
        {
            ComplianceStatus = complianceStatus;
            ReportId = reportId;
            Assignment = assignment;
            Vm = vm;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a value indicating compliance status of the virtual machine
        /// for the assigned guest configuration. Possible values include:
        /// 'Compliant', 'NonCompliant', 'Pending'
        /// </summary>
        [JsonProperty(PropertyName = "complianceStatus")]
        public string ComplianceStatus { get; private set; }

        /// <summary>
        /// Gets GUID that identifies the guest configuration assignment report
        /// under a subscription, resource group.
        /// </summary>
        [JsonProperty(PropertyName = "reportId")]
        public string ReportId { get; private set; }

        /// <summary>
        /// Gets or sets configuration details of the guest configuration
        /// assignment.
        /// </summary>
        [JsonProperty(PropertyName = "assignment")]
        public AssignmentInfo Assignment { get; set; }

        /// <summary>
        /// Gets or sets information about the VM.
        /// </summary>
        [JsonProperty(PropertyName = "vm")]
        public VMInfo Vm { get; set; }

        /// <summary>
        /// Gets or sets details of the assignment report.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public AssignmentReportDetails Details { get; set; }

    }
}
