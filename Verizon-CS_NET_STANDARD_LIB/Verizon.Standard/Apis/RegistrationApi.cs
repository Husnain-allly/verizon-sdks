// <copyright file="RegistrationApi.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using System.Net.Http;
using Verizon.Standard;
using Verizon.Standard.Exceptions;
using Verizon.Standard.Http.Client;
using Verizon.Standard.Http.Response;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Apis
{
    /// <summary>
    /// RegistrationApi.
    /// </summary>
    public class RegistrationApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationApi"/> class.
        /// </summary>
        internal RegistrationApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// With this API call the user (client) registers its device or software service to the ETX system. Therefore, when a connection is initiated from the device or software service to the ETX system along with the credential provided by this registration call, then the connection will be authorized.
        /// - The user can register multiple devices or software services, which can all be used at the same time.
        /// - There rules set in the system that limit the type and subtype of the clients that are allowed to be registered under the VendorID. The rules are created based ont he agreement between the Vendor and Verizon.
        /// - The user will only be able to register a limited number of devices or software services under the same VendorID. This registration limit is specified by the agreement between the Vendor and Verizon.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.ClientRegistrationResponse response from the API call.</returns>
        public ApiResponse<Models.ClientRegistrationResponse> RegisterEtxDevice(
                Models.ClientRegistrationRequest body)
            => CoreHelper.RunTask(RegisterEtxDeviceAsync(body));

        /// <summary>
        /// With this API call the user (client) registers its device or software service to the ETX system. Therefore, when a connection is initiated from the device or software service to the ETX system along with the credential provided by this registration call, then the connection will be authorized.
        /// - The user can register multiple devices or software services, which can all be used at the same time.
        /// - There rules set in the system that limit the type and subtype of the clients that are allowed to be registered under the VendorID. The rules are created based ont he agreement between the Vendor and Verizon.
        /// - The user will only be able to register a limited number of devices or software services under the same VendorID. This registration limit is specified by the agreement between the Vendor and Verizon.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="body">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ClientRegistrationResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ClientRegistrationResponse>> RegisterEtxDeviceAsync(
                Models.ClientRegistrationRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClientRegistrationResponse>()
              .Server(Server.ImpServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v2/clients/registration")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("SessionToken")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid Request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized Request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden Request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Requests", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Internal Server Error", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Forbidden", (_reason, _context) => new EtxResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// With this API call the user (client) can:.
        /// - renew the certificate of a device or software service in the ETX system if the original certificate has expired. If the client's certificate expired or going to expire within 30 days and new certificate will be issued. If the certificate expires more than 30 days, the current certificate will be returned to the client.
        /// - complete its device or software service registration to the ETX system if the original registration request was not successful because of a pending certificate generation. Whenever the user receives a "client registration is pending" response (HTTP 202) from POST /clients/registration call. The client should initiate this PUT API call to finish the registration process and get the required certificate.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="deviceId">Required parameter: .</param>
        /// <param name="vendorId">Required parameter: The VendorID set during the Vendor registration call..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.ClientRegistrationResponse response from the API call.</returns>
        public ApiResponse<Models.ClientRegistrationResponse> RenewEtxDevice(
                Guid deviceId,
                string vendorId,
                object body = null)
            => CoreHelper.RunTask(RenewEtxDeviceAsync(deviceId, vendorId, body));

        /// <summary>
        /// With this API call the user (client) can:.
        /// - renew the certificate of a device or software service in the ETX system if the original certificate has expired. If the client's certificate expired or going to expire within 30 days and new certificate will be issued. If the certificate expires more than 30 days, the current certificate will be returned to the client.
        /// - complete its device or software service registration to the ETX system if the original registration request was not successful because of a pending certificate generation. Whenever the user receives a "client registration is pending" response (HTTP 202) from POST /clients/registration call. The client should initiate this PUT API call to finish the registration process and get the required certificate.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="deviceId">Required parameter: .</param>
        /// <param name="vendorId">Required parameter: The VendorID set during the Vendor registration call..</param>
        /// <param name="body">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ClientRegistrationResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ClientRegistrationResponse>> RenewEtxDeviceAsync(
                Guid deviceId,
                string vendorId,
                object body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClientRegistrationResponse>()
              .Server(Server.ImpServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Put, "/api/v2/clients/registration")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("SessionToken")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("DeviceID", deviceId))
                      .Header(_header => _header.Setup("VendorID", vendorId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid Request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized Request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden Request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Requests", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Internal Server Error", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Forbidden", (_reason, _context) => new EtxResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// With this API call the user (client) can unregister its devices and software services from the ETX system. The unregistered devices and services will no longer be able to use the ETX Message Exchange.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The VendorID set during the Vendor registration call..</param>
        /// <param name="deviceIDs">Required parameter: The list of device IDs and software service IDs to be unregistered.</param>
        public void UnregisterEtxDevice(
                string vendorId,
                List<Guid> deviceIDs)
            => CoreHelper.RunVoidTask(UnregisterEtxDeviceAsync(vendorId, deviceIDs));

        /// <summary>
        /// With this API call the user (client) can unregister its devices and software services from the ETX system. The unregistered devices and services will no longer be able to use the ETX Message Exchange.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The VendorID set during the Vendor registration call..</param>
        /// <param name="deviceIDs">Required parameter: The list of device IDs and software service IDs to be unregistered.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task UnregisterEtxDeviceAsync(
                string vendorId,
                List<Guid> deviceIDs,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.ImpServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/api/v2/clients/registration")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("SessionToken")
                  )
                  .Parameters(_parameters => _parameters
                      .Header(_header => _header.Setup("VendorID", vendorId).Required())
                      .Query(_query => _query.Setup("DeviceIDs", deviceIDs).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid Request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized Request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden Request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Requests", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Internal Server Error", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Forbidden", (_reason, _context) => new EtxResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// With this API call the user can check the certificate of the device. At least one of the DeviceID, IMEI or ICCID is required to make the call.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="deviceId">Optional parameter: .</param>
        /// <param name="imei">Optional parameter: .</param>
        /// <param name="iccid">Optional parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.ClientPersistenceResponse response from the API call.</returns>
        public ApiResponse<Models.ClientPersistenceResponse> GetEtxDeviceCertificate(
                Guid? deviceId = null,
                string imei = null,
                string iccid = null)
            => CoreHelper.RunTask(GetEtxDeviceCertificateAsync(deviceId, imei, iccid));

        /// <summary>
        /// With this API call the user can check the certificate of the device. At least one of the DeviceID, IMEI or ICCID is required to make the call.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="deviceId">Optional parameter: .</param>
        /// <param name="imei">Optional parameter: .</param>
        /// <param name="iccid">Optional parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ClientPersistenceResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ClientPersistenceResponse>> GetEtxDeviceCertificateAsync(
                Guid? deviceId = null,
                string imei = null,
                string iccid = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ClientPersistenceResponse>()
              .Server(Server.ImpServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api/v2/clients/registration")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("SessionToken")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("DeviceID", deviceId))
                      .Query(_query => _query.Setup("IMEI", imei))
                      .Query(_query => _query.Setup("ICCID", iccid))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden Request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Requests", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server Error", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Forbidden", (_reason, _context) => new EtxResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// With this API call the device or software service requests the MQTT URL for the location that it needs to connect. To determine the proper URL the device or software service needs to provide its ID (the one that was provided in the registration request), location (GPS coordinates), and whether it is on the Verizon cellular network or not.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The VendorID set during the Vendor registration call..</param>
        /// <param name="body">Required parameter: .</param>
        /// <returns>Returns the ApiResponse of Models.ConnectionResponse response from the API call.</returns>
        public ApiResponse<Models.ConnectionResponse> RetrieveMqtturl(
                string vendorId,
                Models.ConnectionRequest body)
            => CoreHelper.RunTask(RetrieveMqtturlAsync(vendorId, body));

        /// <summary>
        /// With this API call the device or software service requests the MQTT URL for the location that it needs to connect. To determine the proper URL the device or software service needs to provide its ID (the one that was provided in the registration request), location (GPS coordinates), and whether it is on the Verizon cellular network or not.
        /// Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
        /// </summary>
        /// <param name="vendorId">Required parameter: The VendorID set during the Vendor registration call..</param>
        /// <param name="body">Required parameter: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ConnectionResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ConnectionResponse>> RetrieveMqtturlAsync(
                string vendorId,
                Models.ConnectionRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ConnectionResponse>()
              .Server(Server.ImpServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v2/clients/connection")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("SessionToken")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("VendorID", vendorId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Invalid request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden Request", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too Many Requests", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("503", CreateErrorCase("Internal server Error", (_reason, _context) => new EtxResponseErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Forbidden", (_reason, _context) => new EtxResponseErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}