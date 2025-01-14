// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers.SipRouting
{
    /// <summary>
    /// Represents a SIP configuration.
    /// 
    /// When a call is being routed the routes are applied in the same order as in the routes list.
    /// 
    /// A route is matched by its number pattern.
    /// 
    /// Call is then directed into route&apos;s first available trunk, based on the order in the route&apos;s trunks list.
    /// </summary>
    internal partial class SipConfiguration
    {

        /// <summary> Initializes a new instance of SipConfiguration. </summary>
        /// <param name="trunks">
        /// SIP trunks for routing calls.
        /// 
        /// Map key is trunk&apos;s FQDN (1-249 characters).
        /// </param>
        /// <param name="routes"> Trunk routes for routing calls. </param>
        internal SipConfiguration(IReadOnlyDictionary<string, SipTrunk> trunks, IReadOnlyList<SipTrunkRoute> routes)
        {
            Trunks = trunks;
            Routes = routes;
        }
    }
}
