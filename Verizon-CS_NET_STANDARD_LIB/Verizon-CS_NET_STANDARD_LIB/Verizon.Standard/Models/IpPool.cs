// <copyright file="IpPool.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// IpPool.
    /// </summary>
    public class IpPool
    {
        [JsonExtensionData]
        private readonly IDictionary<string, JToken> additionalProperties;

        private readonly IEnumerable<string> propertyName;

        /// <summary>
        /// Get or set the value associated with the specified key in the AdditionalProperties dictionary.
        /// </summary>
        /// <param name="key">The key of the value to get or set. This must be a valid key that is not reserved for internal properties.</param>
        /// <returns>The object value associated with the specified key in the AdditionalProperties dictionary.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="key"/> is null or an empty string.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when the specified <paramref name="key"/> conflicts with an internal property of the object.
        /// </exception>
        /// <exception cref="KeyNotFoundException">
        /// Thrown when the specified <paramref name="key"/> does not exist in the AdditionalProperties dictionary.
        /// </exception>
        [IndexerName("AdditionalPropertiesIndexer")]
        public object this[string key]
        {
            get => additionalProperties.GetValue<object>(key);
            set => additionalProperties.SetValue(key, value, propertyName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IpPool"/> class.
        /// </summary>
        public IpPool()
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IpPool"/> class.
        /// </summary>
        /// <param name="poolName">poolName.</param>
        /// <param name="poolType">poolType.</param>
        /// <param name="isDefaultPool">isDefaultPool.</param>
        public IpPool(
            string poolName = null,
            string poolType = null,
            bool? isDefaultPool = null)
        {
            this.additionalProperties = new Dictionary<string, JToken>();
            this.propertyName = this.GetPropertyNames();
            this.PoolName = poolName;
            this.PoolType = poolType;
            this.IsDefaultPool = isDefaultPool;
        }

        /// <summary>
        /// The name of the IP pool.
        /// </summary>
        [JsonProperty("poolName", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolName { get; set; }

        /// <summary>
        /// The type of IP pool, such as “Static IP” or “Dynamic IP.”
        /// </summary>
        [JsonProperty("poolType", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolType { get; set; }

        /// <summary>
        /// True if this is the default IP pool for the account.
        /// </summary>
        [JsonProperty("isDefaultPool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefaultPool { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"IpPool : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is IpPool other &&
                (this.PoolName == null && other.PoolName == null ||
                 this.PoolName?.Equals(other.PoolName) == true) &&
                (this.PoolType == null && other.PoolType == null ||
                 this.PoolType?.Equals(other.PoolType) == true) &&
                (this.IsDefaultPool == null && other.IsDefaultPool == null ||
                 this.IsDefaultPool?.Equals(other.IsDefaultPool) == true) &&
                (this.additionalProperties == null && other.additionalProperties == null ||
                 this.additionalProperties?.Count == other.additionalProperties?.Count &&
                 this.additionalProperties?.All(kv =>
                     other.additionalProperties.TryGetValue(kv.Key, out var value) &&
                     JToken.DeepEquals(kv.Value, value)) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PoolName = {this.PoolName ?? "null"}");
            toStringOutput.Add($"PoolType = {this.PoolType ?? "null"}");
            toStringOutput.Add($"IsDefaultPool = {(this.IsDefaultPool == null ? "null" : this.IsDefaultPool.ToString())}");

            additionalProperties?
                .Select(kvp => $"[{kvp.Key}] = {kvp.Value.ToString(Formatting.None)}")
                .ToList()
                .ForEach(toStringOutput.Add);
        }
    }
}