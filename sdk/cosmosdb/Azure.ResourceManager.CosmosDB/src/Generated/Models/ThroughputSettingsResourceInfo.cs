// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB resource throughput object. Either throughput is required or autoscaleSettings is required, but not both. </summary>
    public partial class ThroughputSettingsResourceInfo
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ThroughputSettingsResourceInfo"/>. </summary>
        public ThroughputSettingsResourceInfo()
        {
            ThroughputBuckets = new ChangeTrackingList<ThroughputBucketResource>();
        }

        /// <summary> Initializes a new instance of <see cref="ThroughputSettingsResourceInfo"/>. </summary>
        /// <param name="throughput"> Value of the Cosmos DB resource throughput. Either throughput is required or autoscaleSettings is required, but not both. </param>
        /// <param name="autoscaleSettings"> Cosmos DB resource for autoscale settings. Either throughput is required or autoscaleSettings is required, but not both. </param>
        /// <param name="minimumThroughput"> The minimum throughput of the resource. </param>
        /// <param name="offerReplacePending"> The throughput replace is pending. </param>
        /// <param name="instantMaximumThroughput"> The offer throughput value to instantly scale up without triggering splits. </param>
        /// <param name="softAllowedMaximumThroughput"> The maximum throughput value or the maximum maxThroughput value (for autoscale) that can be specified. </param>
        /// <param name="throughputBuckets"> Array of Throughput Bucket limits to be applied to the Cosmos DB container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThroughputSettingsResourceInfo(int? throughput, AutoscaleSettingsResourceInfo autoscaleSettings, string minimumThroughput, string offerReplacePending, string instantMaximumThroughput, string softAllowedMaximumThroughput, IList<ThroughputBucketResource> throughputBuckets, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Throughput = throughput;
            AutoscaleSettings = autoscaleSettings;
            MinimumThroughput = minimumThroughput;
            OfferReplacePending = offerReplacePending;
            InstantMaximumThroughput = instantMaximumThroughput;
            SoftAllowedMaximumThroughput = softAllowedMaximumThroughput;
            ThroughputBuckets = throughputBuckets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Value of the Cosmos DB resource throughput. Either throughput is required or autoscaleSettings is required, but not both. </summary>
        [WirePath("throughput")]
        public int? Throughput { get; set; }
        /// <summary> Cosmos DB resource for autoscale settings. Either throughput is required or autoscaleSettings is required, but not both. </summary>
        [WirePath("autoscaleSettings")]
        public AutoscaleSettingsResourceInfo AutoscaleSettings { get; set; }
        /// <summary> The minimum throughput of the resource. </summary>
        [WirePath("minimumThroughput")]
        public string MinimumThroughput { get; }
        /// <summary> The throughput replace is pending. </summary>
        [WirePath("offerReplacePending")]
        public string OfferReplacePending { get; }
        /// <summary> The offer throughput value to instantly scale up without triggering splits. </summary>
        [WirePath("instantMaximumThroughput")]
        public string InstantMaximumThroughput { get; }
        /// <summary> The maximum throughput value or the maximum maxThroughput value (for autoscale) that can be specified. </summary>
        [WirePath("softAllowedMaximumThroughput")]
        public string SoftAllowedMaximumThroughput { get; }
        /// <summary> Array of Throughput Bucket limits to be applied to the Cosmos DB container. </summary>
        [WirePath("throughputBuckets")]
        public IList<ThroughputBucketResource> ThroughputBuckets { get; }
    }
}
