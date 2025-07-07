// <copyright file="DtoDeviceResourceIdentifier1.cs" company="APIMatic">
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
    /// DtoDeviceResourceIdentifier1.
    /// </summary>
    public class DtoDeviceResourceIdentifier1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoDeviceResourceIdentifier1"/> class.
        /// </summary>
        public DtoDeviceResourceIdentifier1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoDeviceResourceIdentifier1"/> class.
        /// </summary>
        /// <param name="deveui">deveui.</param>
        /// <param name="deviceid">deviceid.</param>
        /// <param name="esn">esn.</param>
        /// <param name="iccid">iccid.</param>
        /// <param name="imei">imei.</param>
        /// <param name="imsi">imsi.</param>
        /// <param name="mac">mac.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="meid">meid.</param>
        /// <param name="msisdn">msisdn.</param>
        /// <param name="nodeUuid">node_uuid.</param>
        /// <param name="qrcode">qrcode.</param>
        /// <param name="serial">serial.</param>
        /// <param name="id">id.</param>
        public DtoDeviceResourceIdentifier1(
            string deveui = null,
            string deviceid = null,
            int? esn = null,
            string iccid = null,
            int? imei = null,
            int? imsi = null,
            string mac = null,
            string manufacturer = null,
            string meid = null,
            string msisdn = null,
            string nodeUuid = null,
            string qrcode = null,
            string serial = null,
            string id = null)
        {
            this.Deveui = deveui;
            this.Deviceid = deviceid;
            this.Esn = esn;
            this.Iccid = iccid;
            this.Imei = imei;
            this.Imsi = imsi;
            this.Mac = mac;
            this.Manufacturer = manufacturer;
            this.Meid = meid;
            this.Msisdn = msisdn;
            this.NodeUuid = nodeUuid;
            this.Qrcode = qrcode;
            this.Serial = serial;
            this.Id = id;
        }

        /// <summary>
        /// the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer
        /// </summary>
        [JsonProperty("deveui", NullValueHandling = NullValueHandling.Ignore)]
        public string Deveui { get; set; }

        /// <summary>
        /// This is a UUID value of the device created when the device is onboarded
        /// </summary>
        [JsonProperty("deviceid", NullValueHandling = NullValueHandling.Ignore)]
        public string Deviceid { get; set; }

        /// <summary>
        /// The Electronic Serial Number (ESN) of the device
        /// </summary>
        [JsonProperty("esn", NullValueHandling = NullValueHandling.Ignore)]
        public int? Esn { get; set; }

        /// <summary>
        /// The 20-digit Integrated Circuit Card ID (SIM card ID)
        /// </summary>
        [JsonProperty("iccid", NullValueHandling = NullValueHandling.Ignore)]
        public string Iccid { get; set; }

        /// <summary>
        /// The 15-digit International Mobile Equipment ID
        /// </summary>
        [JsonProperty("imei", NullValueHandling = NullValueHandling.Ignore)]
        public int? Imei { get; set; }

        /// <summary>
        /// The 64-bit International Mobile Subscriber Identity
        /// </summary>
        [JsonProperty("imsi", NullValueHandling = NullValueHandling.Ignore)]
        public int? Imsi { get; set; }

        /// <summary>
        /// The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX
        /// </summary>
        [JsonProperty("mac", NullValueHandling = NullValueHandling.Ignore)]
        public string Mac { get; set; }

        /// <summary>
        /// The manufacturer of the device
        /// </summary>
        [JsonProperty("manufacturer", NullValueHandling = NullValueHandling.Ignore)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// The 56-bit Mobile Equipment ID
        /// </summary>
        [JsonProperty("meid", NullValueHandling = NullValueHandling.Ignore)]
        public string Meid { get; set; }

        /// <summary>
        /// The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number
        /// </summary>
        [JsonProperty("msisdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Msisdn { get; set; }

        /// <summary>
        /// The UUID of the node the device is associated with
        /// </summary>
        [JsonProperty("node_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeUuid { get; set; }

        /// <summary>
        /// The numeric value of the Quick Response (QR) code
        /// </summary>
        [JsonProperty("qrcode", NullValueHandling = NullValueHandling.Ignore)]
        public string Qrcode { get; set; }

        /// <summary>
        /// The device's serial number
        /// </summary>
        [JsonProperty("serial", NullValueHandling = NullValueHandling.Ignore)]
        public string Serial { get; set; }

        /// <summary>
        /// UUID of the user record, assigned at creation
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoDeviceResourceIdentifier1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoDeviceResourceIdentifier1 other &&
                (this.Deveui == null && other.Deveui == null ||
                 this.Deveui?.Equals(other.Deveui) == true) &&
                (this.Deviceid == null && other.Deviceid == null ||
                 this.Deviceid?.Equals(other.Deviceid) == true) &&
                (this.Esn == null && other.Esn == null ||
                 this.Esn?.Equals(other.Esn) == true) &&
                (this.Iccid == null && other.Iccid == null ||
                 this.Iccid?.Equals(other.Iccid) == true) &&
                (this.Imei == null && other.Imei == null ||
                 this.Imei?.Equals(other.Imei) == true) &&
                (this.Imsi == null && other.Imsi == null ||
                 this.Imsi?.Equals(other.Imsi) == true) &&
                (this.Mac == null && other.Mac == null ||
                 this.Mac?.Equals(other.Mac) == true) &&
                (this.Manufacturer == null && other.Manufacturer == null ||
                 this.Manufacturer?.Equals(other.Manufacturer) == true) &&
                (this.Meid == null && other.Meid == null ||
                 this.Meid?.Equals(other.Meid) == true) &&
                (this.Msisdn == null && other.Msisdn == null ||
                 this.Msisdn?.Equals(other.Msisdn) == true) &&
                (this.NodeUuid == null && other.NodeUuid == null ||
                 this.NodeUuid?.Equals(other.NodeUuid) == true) &&
                (this.Qrcode == null && other.Qrcode == null ||
                 this.Qrcode?.Equals(other.Qrcode) == true) &&
                (this.Serial == null && other.Serial == null ||
                 this.Serial?.Equals(other.Serial) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Deveui = {this.Deveui ?? "null"}");
            toStringOutput.Add($"Deviceid = {this.Deviceid ?? "null"}");
            toStringOutput.Add($"Esn = {(this.Esn == null ? "null" : this.Esn.ToString())}");
            toStringOutput.Add($"Iccid = {this.Iccid ?? "null"}");
            toStringOutput.Add($"Imei = {(this.Imei == null ? "null" : this.Imei.ToString())}");
            toStringOutput.Add($"Imsi = {(this.Imsi == null ? "null" : this.Imsi.ToString())}");
            toStringOutput.Add($"Mac = {this.Mac ?? "null"}");
            toStringOutput.Add($"Manufacturer = {this.Manufacturer ?? "null"}");
            toStringOutput.Add($"Meid = {this.Meid ?? "null"}");
            toStringOutput.Add($"Msisdn = {this.Msisdn ?? "null"}");
            toStringOutput.Add($"NodeUuid = {this.NodeUuid ?? "null"}");
            toStringOutput.Add($"Qrcode = {this.Qrcode ?? "null"}");
            toStringOutput.Add($"Serial = {this.Serial ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
        }
    }
}