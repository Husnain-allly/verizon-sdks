// <copyright file="SensorInsightsUsersApi.cs" company="APIMatic">
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
    /// SensorInsightsUsersApi.
    /// </summary>
    public class SensorInsightsUsersApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorInsightsUsersApi"/> class.
        /// </summary>
        internal SensorInsightsUsersApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// SensorInsightsCreateUserRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Create a user profile.</param>
        /// <returns>Returns the ApiResponse of Models.ResourceUser response from the API call.</returns>
        public ApiResponse<Models.ResourceUser> SensorInsightsCreateUserRequest(
                Models.DtoCreateUserRequest body)
            => CoreHelper.RunTask(SensorInsightsCreateUserRequestAsync(body));

        /// <summary>
        /// SensorInsightsCreateUserRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Create a user profile.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ResourceUser response from the API call.</returns>
        public async Task<ApiResponse<Models.ResourceUser>> SensorInsightsCreateUserRequestAsync(
                Models.DtoCreateUserRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ResourceUser>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/users")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new M400ManagementErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("UnAuthorized", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new M403ManagementErrorException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Not Acceptable", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new M500ManagementErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error", (_reason, _context) => new ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// SensorInsightsDeleteUser EndPoint.
        /// </summary>
        /// <param name="deleterequestpayload">Required parameter: Payload for the delete user request..</param>
        public void SensorInsightsDeleteUser(
                Models.DtoDeleteUserRequest deleterequestpayload)
            => CoreHelper.RunVoidTask(SensorInsightsDeleteUserAsync(deleterequestpayload));

        /// <summary>
        /// SensorInsightsDeleteUser EndPoint.
        /// </summary>
        /// <param name="deleterequestpayload">Required parameter: Payload for the delete user request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task SensorInsightsDeleteUserAsync(
                Models.DtoDeleteUserRequest deleterequestpayload,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/dm/v1/users")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("deleterequestpayload", deleterequestpayload).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new M400ManagementErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("UnAuthorized", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new M403ManagementErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new M404ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// SensorInsightsUpdateUserRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Partially update a user profile.</param>
        /// <returns>Returns the ApiResponse of Models.ResourceUser response from the API call.</returns>
        public ApiResponse<Models.ResourceUser> SensorInsightsUpdateUserRequest(
                Models.DtoUpdateUserRequest body)
            => CoreHelper.RunTask(SensorInsightsUpdateUserRequestAsync(body));

        /// <summary>
        /// SensorInsightsUpdateUserRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Partially update a user profile.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ResourceUser response from the API call.</returns>
        public async Task<ApiResponse<Models.ResourceUser>> SensorInsightsUpdateUserRequestAsync(
                Models.DtoUpdateUserRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ResourceUser>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/dm/v1/users")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new M400ManagementErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("UnAuthorized", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new M403ManagementErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new M404ManagementErrorException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Not Acceptable", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new M500ManagementErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error", (_reason, _context) => new ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// SensorInsightsListUserRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: A summary of user profile records on an account.</param>
        /// <returns>Returns the ApiResponse of List of Models.ResourceUser response from the API call.</returns>
        public ApiResponse<List<Models.ResourceUser>> SensorInsightsListUserRequest(
                Models.DtoListUserRequest body)
            => CoreHelper.RunTask(SensorInsightsListUserRequestAsync(body));

        /// <summary>
        /// SensorInsightsListUserRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: A summary of user profile records on an account.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.ResourceUser response from the API call.</returns>
        public async Task<ApiResponse<List<Models.ResourceUser>>> SensorInsightsListUserRequestAsync(
                Models.DtoListUserRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.ResourceUser>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/users/actions/query")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new M400ManagementErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("UnAuthorized", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new M403ManagementErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new M404ManagementErrorException(_reason, _context)))
                  .ErrorCase("406", CreateErrorCase("Not Acceptable", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("415", CreateErrorCase("Unsupported media type", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("429", CreateErrorCase("Too many requests", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Internal server error.", (_reason, _context) => new M500ManagementErrorException(_reason, _context)))
                  .ErrorCase("0", CreateErrorCase("Unexpected error", (_reason, _context) => new ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}