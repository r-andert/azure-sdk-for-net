// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.Rooms
{
    /// <summary> Participants to be updated in a room. </summary>
    internal partial class UpdateParticipantsRequest
    {
        /// <summary> Initializes a new instance of UpdateParticipantsRequest. </summary>
        /// <param name="participants"> Participants to update in a room. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="participants"/> is null. </exception>
        public UpdateParticipantsRequest(IEnumerable<RoomParticipantInternal> participants)
        {
            Argument.AssertNotNull(participants, nameof(participants));

            Participants = participants.ToList();
        }

        /// <summary> Participants to update in a room. </summary>
        public IList<RoomParticipantInternal> Participants { get; }
    }
}
