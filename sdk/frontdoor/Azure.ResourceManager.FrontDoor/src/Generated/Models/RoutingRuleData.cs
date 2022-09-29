// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> A routing rule represents a specification for traffic to treat and where to send it, along with health probe information. </summary>
    public partial class RoutingRuleData : FrontDoorResourceData
    {
        /// <summary> Initializes a new instance of RoutingRuleData. </summary>
        public RoutingRuleData()
        {
            FrontendEndpoints = new ChangeTrackingList<SubResource>();
            AcceptedProtocols = new ChangeTrackingList<FrontDoorProtocol>();
            PatternsToMatch = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of RoutingRuleData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="frontendEndpoints"> Frontend endpoints associated with this rule. </param>
        /// <param name="acceptedProtocols"> Protocol schemes to match for this rule. </param>
        /// <param name="patternsToMatch"> The route patterns of the rule. </param>
        /// <param name="enabledState"> Whether to enable use of this rule. Permitted values are &apos;Enabled&apos; or &apos;Disabled&apos;. </param>
        /// <param name="routeConfiguration">
        /// A reference to the routing configuration.
        /// Please note <see cref="RouteConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ForwardingConfiguration"/> and <see cref="RedirectConfiguration"/>.
        /// </param>
        /// <param name="rulesEngine"> A reference to a specific Rules Engine Configuration to apply to this route. </param>
        /// <param name="webApplicationFirewallPolicyLink"> Defines the Web Application Firewall policy for each routing rule (if applicable). </param>
        /// <param name="resourceState"> Resource status. </param>
        internal RoutingRuleData(ResourceIdentifier id, string name, ResourceType? resourceType, IList<SubResource> frontendEndpoints, IList<FrontDoorProtocol> acceptedProtocols, IList<string> patternsToMatch, RoutingRuleEnabledState? enabledState, RouteConfiguration routeConfiguration, SubResource rulesEngine, RoutingRuleUpdateParametersWebApplicationFirewallPolicyLink webApplicationFirewallPolicyLink, FrontDoorResourceState? resourceState) : base(id, name, resourceType)
        {
            FrontendEndpoints = frontendEndpoints;
            AcceptedProtocols = acceptedProtocols;
            PatternsToMatch = patternsToMatch;
            EnabledState = enabledState;
            RouteConfiguration = routeConfiguration;
            RulesEngine = rulesEngine;
            WebApplicationFirewallPolicyLink = webApplicationFirewallPolicyLink;
            ResourceState = resourceState;
        }

        /// <summary> Frontend endpoints associated with this rule. </summary>
        public IList<SubResource> FrontendEndpoints { get; }
        /// <summary> Protocol schemes to match for this rule. </summary>
        public IList<FrontDoorProtocol> AcceptedProtocols { get; }
        /// <summary> The route patterns of the rule. </summary>
        public IList<string> PatternsToMatch { get; }
        /// <summary> Whether to enable use of this rule. Permitted values are &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public RoutingRuleEnabledState? EnabledState { get; set; }
        /// <summary>
        /// A reference to the routing configuration.
        /// Please note <see cref="RouteConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ForwardingConfiguration"/> and <see cref="RedirectConfiguration"/>.
        /// </summary>
        public RouteConfiguration RouteConfiguration { get; set; }
        /// <summary> A reference to a specific Rules Engine Configuration to apply to this route. </summary>
        internal SubResource RulesEngine { get; set; }
        /// <summary> Resource ID. </summary>
        public string RulesEngineId
        {
            get => RulesEngine is null ? default : RulesEngine.Id;
            set
            {
                if (RulesEngine is null)
                    RulesEngine = new SubResource();
                RulesEngine.Id = value;
            }
        }

        /// <summary> Defines the Web Application Firewall policy for each routing rule (if applicable). </summary>
        internal RoutingRuleUpdateParametersWebApplicationFirewallPolicyLink WebApplicationFirewallPolicyLink { get; set; }
        /// <summary> Resource ID. </summary>
        public string WebApplicationFirewallPolicyLinkId
        {
            get => WebApplicationFirewallPolicyLink is null ? default : WebApplicationFirewallPolicyLink.Id;
            set
            {
                if (WebApplicationFirewallPolicyLink is null)
                    WebApplicationFirewallPolicyLink = new RoutingRuleUpdateParametersWebApplicationFirewallPolicyLink();
                WebApplicationFirewallPolicyLink.Id = value;
            }
        }

        /// <summary> Resource status. </summary>
        public FrontDoorResourceState? ResourceState { get; }
    }
}
