// <copyright file="DtoFilter.cs" company="APIMatic">
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
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// DtoFilter.
    /// </summary>
    public class DtoFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoFilter"/> class.
        /// </summary>
        public DtoFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoFilter"/> class.
        /// </summary>
        /// <param name="mExpand">$expand.</param>
        /// <param name="mLimitnumber">$limitnumber.</param>
        /// <param name="mNopagination">$nopagination.</param>
        /// <param name="mPage">$page.</param>
        /// <param name="mPagenumber">$pagenumber.</param>
        /// <param name="mProjection">$projection.</param>
        /// <param name="mSelection">$selection.</param>
        public DtoFilter(
            string mExpand = null,
            int? mLimitnumber = null,
            bool? mNopagination = null,
            string mPage = null,
            int? mPagenumber = null,
            List<string> mProjection = null,
            object mSelection = null)
        {
            this.MExpand = mExpand;
            this.MLimitnumber = mLimitnumber;
            this.MNopagination = mNopagination;
            this.MPage = mPage;
            this.MPagenumber = mPagenumber;
            this.MProjection = mProjection;
            this.MSelection = mSelection;
        }

        /// <summary>
        /// Use to provide device details for alerts specific to a device
        /// </summary>
        [JsonProperty("$expand", NullValueHandling = NullValueHandling.Ignore)]
        public string MExpand { get; set; }

        /// <summary>
        /// Limit the number of results returned
        /// </summary>
        [JsonProperty("$limitnumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? MLimitnumber { get; set; }

        /// <summary>
        /// A flag set to show if pagination requested (false) or not (true)
        /// </summary>
        [JsonProperty("$nopagination", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MNopagination { get; set; }

        /// <summary>
        /// Gets or sets MPage.
        /// </summary>
        [JsonProperty("$page", NullValueHandling = NullValueHandling.Ignore)]
        public string MPage { get; set; }

        /// <summary>
        /// Gets or sets MPagenumber.
        /// </summary>
        [JsonProperty("$pagenumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? MPagenumber { get; set; }

        /// <summary>
        /// Limits the fields of the device that the user is interested in rather than all of the fields
        /// </summary>
        [JsonProperty("$projection", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MProjection { get; set; }

        /// <summary>
        /// Filters results based on user defined criteria
        /// </summary>
        [JsonProperty("$selection", NullValueHandling = NullValueHandling.Ignore)]
        public object MSelection { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoFilter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoFilter other &&
                (this.MExpand == null && other.MExpand == null ||
                 this.MExpand?.Equals(other.MExpand) == true) &&
                (this.MLimitnumber == null && other.MLimitnumber == null ||
                 this.MLimitnumber?.Equals(other.MLimitnumber) == true) &&
                (this.MNopagination == null && other.MNopagination == null ||
                 this.MNopagination?.Equals(other.MNopagination) == true) &&
                (this.MPage == null && other.MPage == null ||
                 this.MPage?.Equals(other.MPage) == true) &&
                (this.MPagenumber == null && other.MPagenumber == null ||
                 this.MPagenumber?.Equals(other.MPagenumber) == true) &&
                (this.MProjection == null && other.MProjection == null ||
                 this.MProjection?.Equals(other.MProjection) == true) &&
                (this.MSelection == null && other.MSelection == null ||
                 this.MSelection?.Equals(other.MSelection) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MExpand = {this.MExpand ?? "null"}");
            toStringOutput.Add($"MLimitnumber = {(this.MLimitnumber == null ? "null" : this.MLimitnumber.ToString())}");
            toStringOutput.Add($"MNopagination = {(this.MNopagination == null ? "null" : this.MNopagination.ToString())}");
            toStringOutput.Add($"MPage = {this.MPage ?? "null"}");
            toStringOutput.Add($"MPagenumber = {(this.MPagenumber == null ? "null" : this.MPagenumber.ToString())}");
            toStringOutput.Add($"MProjection = {(this.MProjection == null ? "null" : $"[{string.Join(", ", this.MProjection)} ]")}");
            toStringOutput.Add($"MSelection = {(this.MSelection == null ? "null" : this.MSelection.ToString())}");
        }
    }
}