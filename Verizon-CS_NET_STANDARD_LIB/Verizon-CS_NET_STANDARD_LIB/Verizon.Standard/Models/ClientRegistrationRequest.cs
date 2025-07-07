// <copyright file="ClientRegistrationRequest.cs" company="APIMatic">
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
    /// ClientRegistrationRequest.
    /// </summary>
    public class ClientRegistrationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRegistrationRequest"/> class.
        /// </summary>
        public ClientRegistrationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientRegistrationRequest"/> class.
        /// </summary>
        /// <param name="clientType">ClientType.</param>
        /// <param name="clientSubtype">ClientSubtype.</param>
        /// <param name="vendorId">VendorID.</param>
        /// <param name="deviceId">DeviceID.</param>
        /// <param name="imei">IMEI.</param>
        /// <param name="iccid">ICCID.</param>
        public ClientRegistrationRequest(
            Models.EtxClientType clientType,
            Models.ClientSubtype clientSubtype,
            string vendorId,
            Guid? deviceId = null,
            string imei = null,
            string iccid = null)
        {
            this.ClientType = clientType;
            this.ClientSubtype = clientSubtype;
            this.VendorId = vendorId;
            this.DeviceId = deviceId;
            this.Imei = imei;
            this.Iccid = iccid;
        }

        /// <summary>
        /// The type of the client that is to be registered. This is one of the major traffic participant groups considered in V2X communication. The system uses this value to define which topics the client will be able to publish and subscribe to.
        /// Values:
        /// - **Vehicle** - Vehicle with an enclosure around the passengers. (Subtypes: PassengerCar, Truck, Bus, EmergencyVehicle, SchoolBus, MaintenanceVehicle)
        /// - **VulnerableRoadUser** - Traffic participants without a protecting enclosure. (Subtypes: Motorcycle, Bicycle, Pedestrian, Scooter)
        /// - **TrafficLightController** - A Traffic light controller system. (Subtypes: NA)
        /// - **InfrastructureSensor** - Sensors that are deployed in the infrastructure. (Subtypes: RoadSideUnit, Camera, Lidar, Radar, InductiveLoop, MagneticSensor)
        /// - **OnboardSensor** - Sensors that are onboard on a vehicle(Subtypes: Camera, Lidar, Radar)
        /// - **Software** - A software system or application. (Subtypes: Platform, Application, NA)
        /// </summary>
        [JsonProperty("ClientType")]
        public Models.EtxClientType ClientType { get; set; }

        /// <summary>
        /// The subtype or subgroup of the client type. This further specifies the client type. For example it will specify if the client is a passenger car or a truck. See the ClientType description for the supported Subtypes for each client type.
        /// </summary>
        [JsonProperty("ClientSubtype")]
        public Models.ClientSubtype ClientSubtype { get; set; }

        /// <summary>
        /// The ID the vendor wants its devices to be registered under. E.g. Verizon, GM, Ford, etc.
        /// </summary>
        [JsonProperty("VendorID")]
        public string VendorId { get; set; }

        /// <summary>
        /// The generated ID (UUID v4) for the device. It can be used as:
        ///   - the MQTT Client ID when connecting to the Message Exchange system
        ///   - a parameter when asking for the connection endpoint
        ///   - a parameter when finishing the device registration
        ///   - a parameter when unregistering the device
        /// </summary>
        [JsonProperty("DeviceID", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DeviceId { get; set; }

        /// <summary>
        /// The IMEI number of the device.
        /// </summary>
        [JsonProperty("IMEI", NullValueHandling = NullValueHandling.Ignore)]
        public string Imei { get; set; }

        /// <summary>
        /// The ICCID number of the device.
        /// </summary>
        [JsonProperty("ICCID", NullValueHandling = NullValueHandling.Ignore)]
        public string Iccid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ClientRegistrationRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ClientRegistrationRequest other &&
                (this.ClientType.Equals(other.ClientType)) &&
                (this.ClientSubtype.Equals(other.ClientSubtype)) &&
                (this.VendorId == null && other.VendorId == null ||
                 this.VendorId?.Equals(other.VendorId) == true) &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.Imei == null && other.Imei == null ||
                 this.Imei?.Equals(other.Imei) == true) &&
                (this.Iccid == null && other.Iccid == null ||
                 this.Iccid?.Equals(other.Iccid) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ClientType = {this.ClientType}");
            toStringOutput.Add($"ClientSubtype = {this.ClientSubtype}");
            toStringOutput.Add($"VendorId = {this.VendorId ?? "null"}");
            toStringOutput.Add($"DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"Imei = {this.Imei ?? "null"}");
            toStringOutput.Add($"Iccid = {this.Iccid ?? "null"}");
        }
    }
}