// <copyright file="DtoExpandedDeviceResponse.cs" company="APIMatic">
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
    /// DtoExpandedDeviceResponse.
    /// </summary>
    public class DtoExpandedDeviceResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DtoExpandedDeviceResponse"/> class.
        /// </summary>
        public DtoExpandedDeviceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DtoExpandedDeviceResponse"/> class.
        /// </summary>
        /// <param name="createdon">createdon.</param>
        /// <param name="foreignid">foreignid.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="state">state.</param>
        /// <param name="versionid">versionid.</param>
        /// <param name="accountclientid">accountclientid.</param>
        /// <param name="billingaccountid">billingaccountid.</param>
        /// <param name="chipset">chipset.</param>
        /// <param name="commands">commands.</param>
        /// <param name="customdata">customdata.</param>
        /// <param name="description">description.</param>
        /// <param name="esn">esn.</param>
        /// <param name="fields">fields.</param>
        /// <param name="hardwareversion">hardwareversion.</param>
        /// <param name="iccid">iccid.</param>
        /// <param name="id">id.</param>
        /// <param name="imei">imei.</param>
        /// <param name="imsi">imsi.</param>
        /// <param name="licenses">licenses.</param>
        /// <param name="mac">mac.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="meid">meid.</param>
        /// <param name="modelmetadata">modelmetadata.</param>
        /// <param name="msisdn">msisdn.</param>
        /// <param name="name">name.</param>
        /// <param name="parentdeviceid">parentdeviceid.</param>
        /// <param name="productmodel">productmodel.</param>
        /// <param name="providerid">providerid.</param>
        /// <param name="qrcode">qrcode.</param>
        /// <param name="refid">refid.</param>
        /// <param name="refidtype">refidtype.</param>
        /// <param name="serial">serial.</param>
        /// <param name="services">services.</param>
        /// <param name="sku">sku.</param>
        /// <param name="softwareversion">softwareversion.</param>
        /// <param name="version">version.</param>
        public DtoExpandedDeviceResponse(
            DateTime createdon,
            string foreignid,
            DateTime lastupdated,
            string state,
            string versionid,
            string accountclientid = null,
            string billingaccountid = null,
            string chipset = null,
            object commands = null,
            object customdata = null,
            string description = null,
            int? esn = null,
            Models.DtoFields fields = null,
            string hardwareversion = null,
            string iccid = null,
            string id = null,
            int? imei = null,
            int? imsi = null,
            List<string> licenses = null,
            string mac = null,
            string manufacturer = null,
            string meid = null,
            object modelmetadata = null,
            string msisdn = null,
            string name = null,
            string parentdeviceid = null,
            string productmodel = null,
            string providerid = null,
            string qrcode = null,
            string refid = null,
            string refidtype = null,
            string serial = null,
            List<string> services = null,
            string sku = null,
            string softwareversion = null,
            string version = null)
        {
            this.Accountclientid = accountclientid;
            this.Billingaccountid = billingaccountid;
            this.Chipset = chipset;
            this.Commands = commands;
            this.Createdon = createdon;
            this.Customdata = customdata;
            this.Description = description;
            this.Esn = esn;
            this.Fields = fields;
            this.Foreignid = foreignid;
            this.Hardwareversion = hardwareversion;
            this.Iccid = iccid;
            this.Id = id;
            this.Imei = imei;
            this.Imsi = imsi;
            this.Lastupdated = lastupdated;
            this.Licenses = licenses;
            this.Mac = mac;
            this.Manufacturer = manufacturer;
            this.Meid = meid;
            this.Modelmetadata = modelmetadata;
            this.Msisdn = msisdn;
            this.Name = name;
            this.Parentdeviceid = parentdeviceid;
            this.Productmodel = productmodel;
            this.Providerid = providerid;
            this.Qrcode = qrcode;
            this.Refid = refid;
            this.Refidtype = refidtype;
            this.Serial = serial;
            this.Services = services;
            this.Sku = sku;
            this.Softwareversion = softwareversion;
            this.State = state;
            this.Version = version;
            this.Versionid = versionid;
        }

        /// <summary>
        /// Not used in this release, future functionality
        /// </summary>
        [JsonProperty("accountclientid", NullValueHandling = NullValueHandling.Ignore)]
        public string Accountclientid { get; set; }

        /// <summary>
        /// The billing account ID. This is the same value as the Account ID
        /// </summary>
        [JsonProperty("billingaccountid", NullValueHandling = NullValueHandling.Ignore)]
        public string Billingaccountid { get; set; }

        /// <summary>
        /// The Identifier of chipset used by the device
        /// </summary>
        [JsonProperty("chipset", NullValueHandling = NullValueHandling.Ignore)]
        public string Chipset { get; set; }

        /// <summary>
        /// Gets or sets Commands.
        /// </summary>
        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore)]
        public object Commands { get; set; }

        /// <summary>
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdon")]
        public DateTime Createdon { get; set; }

        /// <summary>
        /// Name/value pair, where the value is client defined.  The purpose is to keep track of current state per device action.
        /// </summary>
        [JsonProperty("customdata", NullValueHandling = NullValueHandling.Ignore)]
        public object Customdata { get; set; }

        /// <summary>
        /// a short description
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// The Electronic Serial Number (ESN) of the device
        /// </summary>
        [JsonProperty("esn", NullValueHandling = NullValueHandling.Ignore)]
        public int? Esn { get; set; }

        /// <summary>
        /// Fields to return needed by search
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DtoFields Fields { get; set; }

        /// <summary>
        /// UUID of the ECPD account the user belongs to
        /// </summary>
        [JsonProperty("foreignid")]
        public string Foreignid { get; set; }

        /// <summary>
        /// The manufacturer's hardware version of the device
        /// </summary>
        [JsonProperty("hardwareversion", NullValueHandling = NullValueHandling.Ignore)]
        public string Hardwareversion { get; set; }

        /// <summary>
        /// The 20-digit Integrated Circuit Card ID (SIM card ID)
        /// </summary>
        [JsonProperty("iccid", NullValueHandling = NullValueHandling.Ignore)]
        public string Iccid { get; set; }

        /// <summary>
        /// UUID of the user record, assigned at creation
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

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
        /// Timestamp of the record
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastupdated")]
        public DateTime Lastupdated { get; set; }

        /// <summary>
        /// licenses assigned to the device
        /// </summary>
        [JsonProperty("licenses", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Licenses { get; set; }

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
        /// Detail
        /// </summary>
        [JsonProperty("modelmetadata", NullValueHandling = NullValueHandling.Ignore)]
        public object Modelmetadata { get; set; }

        /// <summary>
        /// The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number
        /// </summary>
        [JsonProperty("msisdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Msisdn { get; set; }

        /// <summary>
        /// User defined name of the record
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// this field is applicable for BLE sensors. This represents the value of parent gateway device
        /// </summary>
        [JsonProperty("parentdeviceid", NullValueHandling = NullValueHandling.Ignore)]
        public string Parentdeviceid { get; set; }

        /// <summary>
        /// The device model name
        /// </summary>
        [JsonProperty("productmodel", NullValueHandling = NullValueHandling.Ignore)]
        public string Productmodel { get; set; }

        /// <summary>
        /// The id of the provider who is responible for talking to the device
        /// </summary>
        [JsonProperty("providerid", NullValueHandling = NullValueHandling.Ignore)]
        public string Providerid { get; set; }

        /// <summary>
        /// The numeric value of the Quick Response (QR) code
        /// </summary>
        [JsonProperty("qrcode", NullValueHandling = NullValueHandling.Ignore)]
        public string Qrcode { get; set; }

        /// <summary>
        /// The device reference ID
        /// </summary>
        [JsonProperty("refid", NullValueHandling = NullValueHandling.Ignore)]
        public string Refid { get; set; }

        /// <summary>
        /// The type of value represented by `refid`
        /// </summary>
        [JsonProperty("refidtype", NullValueHandling = NullValueHandling.Ignore)]
        public string Refidtype { get; set; }

        /// <summary>
        /// The device's serial number
        /// </summary>
        [JsonProperty("serial", NullValueHandling = NullValueHandling.Ignore)]
        public string Serial { get; set; }

        /// <summary>
        /// Gets or sets Services.
        /// </summary>
        [JsonProperty("services", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Services { get; set; }

        /// <summary>
        /// The Stock Keeping Unit (SKU) number of the device
        /// </summary>
        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        public string Sku { get; set; }

        /// <summary>
        /// the current device software version
        /// </summary>
        [JsonProperty("softwareversion", NullValueHandling = NullValueHandling.Ignore)]
        public string Softwareversion { get; set; }

        /// <summary>
        /// The current status of the device or transaction and will be `success` or `failed`
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The resource version
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// The UUID of the resource version
        /// </summary>
        [JsonProperty("versionid")]
        public string Versionid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"DtoExpandedDeviceResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is DtoExpandedDeviceResponse other &&
                (this.Accountclientid == null && other.Accountclientid == null ||
                 this.Accountclientid?.Equals(other.Accountclientid) == true) &&
                (this.Billingaccountid == null && other.Billingaccountid == null ||
                 this.Billingaccountid?.Equals(other.Billingaccountid) == true) &&
                (this.Chipset == null && other.Chipset == null ||
                 this.Chipset?.Equals(other.Chipset) == true) &&
                (this.Commands == null && other.Commands == null ||
                 this.Commands?.Equals(other.Commands) == true) &&
                (this.Createdon.Equals(other.Createdon)) &&
                (this.Customdata == null && other.Customdata == null ||
                 this.Customdata?.Equals(other.Customdata) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Esn == null && other.Esn == null ||
                 this.Esn?.Equals(other.Esn) == true) &&
                (this.Fields == null && other.Fields == null ||
                 this.Fields?.Equals(other.Fields) == true) &&
                (this.Foreignid == null && other.Foreignid == null ||
                 this.Foreignid?.Equals(other.Foreignid) == true) &&
                (this.Hardwareversion == null && other.Hardwareversion == null ||
                 this.Hardwareversion?.Equals(other.Hardwareversion) == true) &&
                (this.Iccid == null && other.Iccid == null ||
                 this.Iccid?.Equals(other.Iccid) == true) &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Imei == null && other.Imei == null ||
                 this.Imei?.Equals(other.Imei) == true) &&
                (this.Imsi == null && other.Imsi == null ||
                 this.Imsi?.Equals(other.Imsi) == true) &&
                (this.Lastupdated.Equals(other.Lastupdated)) &&
                (this.Licenses == null && other.Licenses == null ||
                 this.Licenses?.Equals(other.Licenses) == true) &&
                (this.Mac == null && other.Mac == null ||
                 this.Mac?.Equals(other.Mac) == true) &&
                (this.Manufacturer == null && other.Manufacturer == null ||
                 this.Manufacturer?.Equals(other.Manufacturer) == true) &&
                (this.Meid == null && other.Meid == null ||
                 this.Meid?.Equals(other.Meid) == true) &&
                (this.Modelmetadata == null && other.Modelmetadata == null ||
                 this.Modelmetadata?.Equals(other.Modelmetadata) == true) &&
                (this.Msisdn == null && other.Msisdn == null ||
                 this.Msisdn?.Equals(other.Msisdn) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Parentdeviceid == null && other.Parentdeviceid == null ||
                 this.Parentdeviceid?.Equals(other.Parentdeviceid) == true) &&
                (this.Productmodel == null && other.Productmodel == null ||
                 this.Productmodel?.Equals(other.Productmodel) == true) &&
                (this.Providerid == null && other.Providerid == null ||
                 this.Providerid?.Equals(other.Providerid) == true) &&
                (this.Qrcode == null && other.Qrcode == null ||
                 this.Qrcode?.Equals(other.Qrcode) == true) &&
                (this.Refid == null && other.Refid == null ||
                 this.Refid?.Equals(other.Refid) == true) &&
                (this.Refidtype == null && other.Refidtype == null ||
                 this.Refidtype?.Equals(other.Refidtype) == true) &&
                (this.Serial == null && other.Serial == null ||
                 this.Serial?.Equals(other.Serial) == true) &&
                (this.Services == null && other.Services == null ||
                 this.Services?.Equals(other.Services) == true) &&
                (this.Sku == null && other.Sku == null ||
                 this.Sku?.Equals(other.Sku) == true) &&
                (this.Softwareversion == null && other.Softwareversion == null ||
                 this.Softwareversion?.Equals(other.Softwareversion) == true) &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
                (this.Version == null && other.Version == null ||
                 this.Version?.Equals(other.Version) == true) &&
                (this.Versionid == null && other.Versionid == null ||
                 this.Versionid?.Equals(other.Versionid) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accountclientid = {this.Accountclientid ?? "null"}");
            toStringOutput.Add($"Billingaccountid = {this.Billingaccountid ?? "null"}");
            toStringOutput.Add($"Chipset = {this.Chipset ?? "null"}");
            toStringOutput.Add($"Commands = {(this.Commands == null ? "null" : this.Commands.ToString())}");
            toStringOutput.Add($"Createdon = {this.Createdon}");
            toStringOutput.Add($"Customdata = {(this.Customdata == null ? "null" : this.Customdata.ToString())}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Esn = {(this.Esn == null ? "null" : this.Esn.ToString())}");
            toStringOutput.Add($"Fields = {(this.Fields == null ? "null" : this.Fields.ToString())}");
            toStringOutput.Add($"Foreignid = {this.Foreignid ?? "null"}");
            toStringOutput.Add($"Hardwareversion = {this.Hardwareversion ?? "null"}");
            toStringOutput.Add($"Iccid = {this.Iccid ?? "null"}");
            toStringOutput.Add($"Id = {this.Id ?? "null"}");
            toStringOutput.Add($"Imei = {(this.Imei == null ? "null" : this.Imei.ToString())}");
            toStringOutput.Add($"Imsi = {(this.Imsi == null ? "null" : this.Imsi.ToString())}");
            toStringOutput.Add($"Lastupdated = {this.Lastupdated}");
            toStringOutput.Add($"Licenses = {(this.Licenses == null ? "null" : $"[{string.Join(", ", this.Licenses)} ]")}");
            toStringOutput.Add($"Mac = {this.Mac ?? "null"}");
            toStringOutput.Add($"Manufacturer = {this.Manufacturer ?? "null"}");
            toStringOutput.Add($"Meid = {this.Meid ?? "null"}");
            toStringOutput.Add($"Modelmetadata = {(this.Modelmetadata == null ? "null" : this.Modelmetadata.ToString())}");
            toStringOutput.Add($"Msisdn = {this.Msisdn ?? "null"}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Parentdeviceid = {this.Parentdeviceid ?? "null"}");
            toStringOutput.Add($"Productmodel = {this.Productmodel ?? "null"}");
            toStringOutput.Add($"Providerid = {this.Providerid ?? "null"}");
            toStringOutput.Add($"Qrcode = {this.Qrcode ?? "null"}");
            toStringOutput.Add($"Refid = {this.Refid ?? "null"}");
            toStringOutput.Add($"Refidtype = {this.Refidtype ?? "null"}");
            toStringOutput.Add($"Serial = {this.Serial ?? "null"}");
            toStringOutput.Add($"Services = {(this.Services == null ? "null" : $"[{string.Join(", ", this.Services)} ]")}");
            toStringOutput.Add($"Sku = {this.Sku ?? "null"}");
            toStringOutput.Add($"Softwareversion = {this.Softwareversion ?? "null"}");
            toStringOutput.Add($"State = {this.State ?? "null"}");
            toStringOutput.Add($"Version = {this.Version ?? "null"}");
            toStringOutput.Add($"Versionid = {this.Versionid ?? "null"}");
        }
    }
}