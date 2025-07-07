// <copyright file="ClientPersistenceResponse.cs" company="APIMatic">
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
    /// ClientPersistenceResponse.
    /// </summary>
    public class ClientPersistenceResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPersistenceResponse"/> class.
        /// </summary>
        public ClientPersistenceResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPersistenceResponse"/> class.
        /// </summary>
        /// <param name="deviceId">DeviceID.</param>
        /// <param name="certificate">Certificate.</param>
        /// <param name="clientType">ClientType.</param>
        /// <param name="clientSubtype">ClientSubtype.</param>
        /// <param name="vendorId">VendorID.</param>
        public ClientPersistenceResponse(
            Guid? deviceId = null,
            Models.Certificate certificate = null,
            Models.EtxClientType? clientType = null,
            Models.ClientSubtype? clientSubtype = null,
            string vendorId = null)
        {
            this.DeviceId = deviceId;
            this.Certificate = certificate;
            this.ClientType = clientType;
            this.ClientSubtype = clientSubtype;
            this.VendorId = vendorId;
        }

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
        /// Structure for the credentials required to connect to the ETX MQTT Message Exchange.
        /// </summary>
        [JsonProperty("Certificate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Certificate Certificate { get; set; }

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
        [JsonProperty("ClientType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EtxClientType? ClientType { get; set; }

        /// <summary>
        /// The subtype or subgroup of the client type. This further specifies the client type. For example it will specify if the client is a passenger car or a truck. See the ClientType description for the supported Subtypes for each client type.
        /// </summary>
        [JsonProperty("ClientSubtype", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClientSubtype? ClientSubtype { get; set; }

        /// <summary>
        /// The ID the vendor wants its devices to be registered under. E.g. Verizon, GM, Ford, etc.
        /// </summary>
        [JsonProperty("VendorID", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ClientPersistenceResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ClientPersistenceResponse other &&
                (this.DeviceId == null && other.DeviceId == null ||
                 this.DeviceId?.Equals(other.DeviceId) == true) &&
                (this.Certificate == null && other.Certificate == null ||
                 this.Certificate?.Equals(other.Certificate) == true) &&
                (this.ClientType == null && other.ClientType == null ||
                 this.ClientType?.Equals(other.ClientType) == true) &&
                (this.ClientSubtype == null && other.ClientSubtype == null ||
                 this.ClientSubtype?.Equals(other.ClientSubtype) == true) &&
                (this.VendorId == null && other.VendorId == null ||
                 this.VendorId?.Equals(other.VendorId) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId.ToString())}");
            toStringOutput.Add($"Certificate = {(this.Certificate == null ? "null" : this.Certificate.ToString())}");
            toStringOutput.Add($"ClientType = {(this.ClientType == null ? "null" : this.ClientType.ToString())}");
            toStringOutput.Add($"ClientSubtype = {(this.ClientSubtype == null ? "null" : this.ClientSubtype.ToString())}");
            toStringOutput.Add($"VendorId = {this.VendorId ?? "null"}");
        }
    }
}