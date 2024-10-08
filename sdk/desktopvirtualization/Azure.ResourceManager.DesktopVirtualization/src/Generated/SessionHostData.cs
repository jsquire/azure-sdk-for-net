// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing the SessionHost data model.
    /// Represents a SessionHost definition.
    /// </summary>
    public partial class SessionHostData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SessionHostData"/>. </summary>
        public SessionHostData()
        {
            SessionHostHealthCheckResults = new ChangeTrackingList<SessionHostHealthCheckReport>();
        }

        /// <summary> Initializes a new instance of <see cref="SessionHostData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="objectId"> ObjectId of SessionHost. (internal use). </param>
        /// <param name="lastHeartBeatOn"> Last heart beat from SessionHost. </param>
        /// <param name="sessions"> Number of sessions on SessionHost. </param>
        /// <param name="agentVersion"> Version of agent on SessionHost. </param>
        /// <param name="allowNewSession"> Allow a new session. </param>
        /// <param name="vmId"> Virtual Machine Id of SessionHost's underlying virtual machine. </param>
        /// <param name="resourceId"> Resource Id of SessionHost's underlying virtual machine. </param>
        /// <param name="assignedUser"> User assigned to SessionHost. </param>
        /// <param name="friendlyName"> Friendly name of SessionHost. </param>
        /// <param name="status"> Status for a SessionHost. </param>
        /// <param name="statusTimestamp"> The timestamp of the status. </param>
        /// <param name="osVersion"> The version of the OS on the session host. </param>
        /// <param name="sxsStackVersion"> The version of the side by side stack on the session host. </param>
        /// <param name="updateState"> Update state of a SessionHost. </param>
        /// <param name="lastUpdatedOn"> The timestamp of the last update. </param>
        /// <param name="updateErrorMessage"> The error message. </param>
        /// <param name="sessionHostHealthCheckResults"> List of SessionHostHealthCheckReports. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SessionHostData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string objectId, DateTimeOffset? lastHeartBeatOn, int? sessions, string agentVersion, bool? allowNewSession, string vmId, ResourceIdentifier resourceId, string assignedUser, string friendlyName, SessionHostStatus? status, DateTimeOffset? statusTimestamp, string osVersion, string sxsStackVersion, SessionHostUpdateState? updateState, DateTimeOffset? lastUpdatedOn, string updateErrorMessage, IReadOnlyList<SessionHostHealthCheckReport> sessionHostHealthCheckResults, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ObjectId = objectId;
            LastHeartBeatOn = lastHeartBeatOn;
            Sessions = sessions;
            AgentVersion = agentVersion;
            AllowNewSession = allowNewSession;
            VmId = vmId;
            ResourceId = resourceId;
            AssignedUser = assignedUser;
            FriendlyName = friendlyName;
            Status = status;
            StatusTimestamp = statusTimestamp;
            OSVersion = osVersion;
            SxsStackVersion = sxsStackVersion;
            UpdateState = updateState;
            LastUpdatedOn = lastUpdatedOn;
            UpdateErrorMessage = updateErrorMessage;
            SessionHostHealthCheckResults = sessionHostHealthCheckResults;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ObjectId of SessionHost. (internal use). </summary>
        [WirePath("properties.objectId")]
        public string ObjectId { get; }
        /// <summary> Last heart beat from SessionHost. </summary>
        [WirePath("properties.lastHeartBeat")]
        public DateTimeOffset? LastHeartBeatOn { get; set; }
        /// <summary> Number of sessions on SessionHost. </summary>
        [WirePath("properties.sessions")]
        public int? Sessions { get; set; }
        /// <summary> Version of agent on SessionHost. </summary>
        [WirePath("properties.agentVersion")]
        public string AgentVersion { get; set; }
        /// <summary> Allow a new session. </summary>
        [WirePath("properties.allowNewSession")]
        public bool? AllowNewSession { get; set; }
        /// <summary> Virtual Machine Id of SessionHost's underlying virtual machine. </summary>
        [WirePath("properties.virtualMachineId")]
        public string VmId { get; }
        /// <summary> Resource Id of SessionHost's underlying virtual machine. </summary>
        [WirePath("properties.resourceId")]
        public ResourceIdentifier ResourceId { get; }
        /// <summary> User assigned to SessionHost. </summary>
        [WirePath("properties.assignedUser")]
        public string AssignedUser { get; set; }
        /// <summary> Friendly name of SessionHost. </summary>
        [WirePath("properties.friendlyName")]
        public string FriendlyName { get; set; }
        /// <summary> Status for a SessionHost. </summary>
        [WirePath("properties.status")]
        public SessionHostStatus? Status { get; set; }
        /// <summary> The timestamp of the status. </summary>
        [WirePath("properties.statusTimestamp")]
        public DateTimeOffset? StatusTimestamp { get; }
        /// <summary> The version of the OS on the session host. </summary>
        [WirePath("properties.osVersion")]
        public string OSVersion { get; set; }
        /// <summary> The version of the side by side stack on the session host. </summary>
        [WirePath("properties.sxSStackVersion")]
        public string SxsStackVersion { get; set; }
        /// <summary> Update state of a SessionHost. </summary>
        [WirePath("properties.updateState")]
        public SessionHostUpdateState? UpdateState { get; set; }
        /// <summary> The timestamp of the last update. </summary>
        [WirePath("properties.lastUpdateTime")]
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> The error message. </summary>
        [WirePath("properties.updateErrorMessage")]
        public string UpdateErrorMessage { get; set; }
        /// <summary> List of SessionHostHealthCheckReports. </summary>
        [WirePath("properties.sessionHostHealthCheckResults")]
        public IReadOnlyList<SessionHostHealthCheckReport> SessionHostHealthCheckResults { get; }
    }
}
