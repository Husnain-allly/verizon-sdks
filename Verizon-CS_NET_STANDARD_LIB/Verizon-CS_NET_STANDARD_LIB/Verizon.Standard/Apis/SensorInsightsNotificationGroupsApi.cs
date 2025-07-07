// <copyright file="SensorInsightsNotificationGroupsApi.cs" company="APIMatic">
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
    /// SensorInsightsNotificationGroupsApi.
    /// </summary>
    public class SensorInsightsNotificationGroupsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorInsightsNotificationGroupsApi"/> class.
        /// </summary>
        internal SensorInsightsNotificationGroupsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// SensorInsightsListNotificationGroupRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Retrieve a notification group.</param>
        /// <returns>Returns the ApiResponse of List of Models.DtoNotificationGroupResponseEntity response from the API call.</returns>
        public ApiResponse<List<Models.DtoNotificationGroupResponseEntity>> SensorInsightsListNotificationGroupRequest(
                Models.DtoListNotificationGroupRequest body)
            => CoreHelper.RunTask(SensorInsightsListNotificationGroupRequestAsync(body));

        /// <summary>
        /// SensorInsightsListNotificationGroupRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Retrieve a notification group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of List of Models.DtoNotificationGroupResponseEntity response from the API call.</returns>
        public async Task<ApiResponse<List<Models.DtoNotificationGroupResponseEntity>>> SensorInsightsListNotificationGroupRequestAsync(
                Models.DtoListNotificationGroupRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<List<Models.DtoNotificationGroupResponseEntity>>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/notificationGroups/actions/query")
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
        /// SensorInsightsUpdateNotificationGroupRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Partially update a notification group.</param>
        /// <returns>Returns the ApiResponse of Models.DtoNotificationGroupResponseEntity response from the API call.</returns>
        public ApiResponse<Models.DtoNotificationGroupResponseEntity> SensorInsightsUpdateNotificationGroupRequest(
                Models.DtoUpdateNotificationGroupRequest body)
            => CoreHelper.RunTask(SensorInsightsUpdateNotificationGroupRequestAsync(body));

        /// <summary>
        /// SensorInsightsUpdateNotificationGroupRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Partially update a notification group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DtoNotificationGroupResponseEntity response from the API call.</returns>
        public async Task<ApiResponse<Models.DtoNotificationGroupResponseEntity>> SensorInsightsUpdateNotificationGroupRequestAsync(
                Models.DtoUpdateNotificationGroupRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DtoNotificationGroupResponseEntity>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/dm/v1/notificationGroups")
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
        /// SensorInsightsCreateNotificationGroupRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Create a notification group.</param>
        /// <returns>Returns the ApiResponse of Models.DtoNotificationGroupResponseEntity response from the API call.</returns>
        public ApiResponse<Models.DtoNotificationGroupResponseEntity> SensorInsightsCreateNotificationGroupRequest(
                Models.DtoCreateNotificationGroupRequest body)
            => CoreHelper.RunTask(SensorInsightsCreateNotificationGroupRequestAsync(body));

        /// <summary>
        /// SensorInsightsCreateNotificationGroupRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Create a notification group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.DtoNotificationGroupResponseEntity response from the API call.</returns>
        public async Task<ApiResponse<Models.DtoNotificationGroupResponseEntity>> SensorInsightsCreateNotificationGroupRequestAsync(
                Models.DtoCreateNotificationGroupRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.DtoNotificationGroupResponseEntity>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/notificationGroups")
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
        /// SensorInsightsDeleteNotificationGroup EndPoint.
        /// </summary>
        /// <param name="payload">Required parameter: Payload for the delete request..</param>
        public void SensorInsightsDeleteNotificationGroup(
                Models.DtoDeleteNotificationGroupRequest payload)
            => CoreHelper.RunVoidTask(SensorInsightsDeleteNotificationGroupAsync(payload));

        /// <summary>
        /// SensorInsightsDeleteNotificationGroup EndPoint.
        /// </summary>
        /// <param name="payload">Required parameter: Payload for the delete request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task SensorInsightsDeleteNotificationGroupAsync(
                Models.DtoDeleteNotificationGroupRequest payload,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/dm/v1/notificationGroups")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("payload", payload).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new M400ManagementErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("UnAuthorized", (_reason, _context) => new ManagementErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new M403ManagementErrorException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new M404ManagementErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// SensorInsightsAddUsersToNotificationGroupRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Add users to a notification group.</param>
        public void SensorInsightsAddUsersToNotificationGroupRequest(
                Models.DtoAddUsersToNotificationGroupRequest body)
            => CoreHelper.RunVoidTask(SensorInsightsAddUsersToNotificationGroupRequestAsync(body));

        /// <summary>
        /// SensorInsightsAddUsersToNotificationGroupRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Add users to a notification group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task SensorInsightsAddUsersToNotificationGroupRequestAsync(
                Models.DtoAddUsersToNotificationGroupRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/notificationGroups/actions/add-users")
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
        /// SensorInsightsRemoveUsersFromNotificationGroupRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Remove users from a notification group.</param>
        public void SensorInsightsRemoveUsersFromNotificationGroupRequest(
                Models.DtoRemoveUsersFromNotificationGroupRequest body)
            => CoreHelper.RunVoidTask(SensorInsightsRemoveUsersFromNotificationGroupRequestAsync(body));

        /// <summary>
        /// SensorInsightsRemoveUsersFromNotificationGroupRequest EndPoint.
        /// </summary>
        /// <param name="body">Required parameter: Remove users from a notification group.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task SensorInsightsRemoveUsersFromNotificationGroupRequestAsync(
                Models.DtoRemoveUsersFromNotificationGroupRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<VoidType>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/dm/v1/notificationGroups/actions/remove-users")
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