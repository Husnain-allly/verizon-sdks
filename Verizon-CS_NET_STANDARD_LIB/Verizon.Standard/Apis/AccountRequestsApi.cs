// <copyright file="AccountRequestsApi.cs" company="APIMatic">
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
    /// AccountRequestsApi.
    /// </summary>
    public class AccountRequestsApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountRequestsApi"/> class.
        /// </summary>
        internal AccountRequestsApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Returns the current status of an asynchronous request that was made for a single device.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="requestId">Required parameter: UUID from synchronous response..</param>
        /// <returns>Returns the ApiResponse of Models.AsynchronousRequestResult response from the API call.</returns>
        public ApiResponse<Models.AsynchronousRequestResult> GetCurrentAsynchronousRequestStatus(
                string aname,
                string requestId)
            => CoreHelper.RunTask(GetCurrentAsynchronousRequestStatusAsync(aname, requestId));

        /// <summary>
        /// Returns the current status of an asynchronous request that was made for a single device.
        /// </summary>
        /// <param name="aname">Required parameter: Account name..</param>
        /// <param name="requestId">Required parameter: UUID from synchronous response..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AsynchronousRequestResult response from the API call.</returns>
        public async Task<ApiResponse<Models.AsynchronousRequestResult>> GetCurrentAsynchronousRequestStatusAsync(
                string aname,
                string requestId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AsynchronousRequestResult>()
              .Server(Server.Thingspace)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/m2m/v1/accounts/{aname}/requests/{requestId}/status")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("aname", aname).Required())
                      .Template(_template => _template.Setup("requestId", requestId).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Error response.", (_reason, _context) => new ConnectivityManagementResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}