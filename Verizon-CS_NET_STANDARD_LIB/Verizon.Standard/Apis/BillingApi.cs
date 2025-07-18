// <copyright file="BillingApi.cs" company="APIMatic">
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
    /// BillingApi.
    /// </summary>
    public class BillingApi : BaseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingApi"/> class.
        /// </summary>
        internal BillingApi(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This endpoint allows user to add managed accounts to a primary account.
        /// </summary>
        /// <param name="body">Required parameter: Service name and list of accounts to add.</param>
        /// <returns>Returns the ApiResponse of Models.ManagedAccountsAddResponse response from the API call.</returns>
        public ApiResponse<Models.ManagedAccountsAddResponse> AddAccount(
                Models.ManagedAccountsAddRequest body)
            => CoreHelper.RunTask(AddAccountAsync(body));

        /// <summary>
        /// This endpoint allows user to add managed accounts to a primary account.
        /// </summary>
        /// <param name="body">Required parameter: Service name and list of accounts to add.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ManagedAccountsAddResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ManagedAccountsAddResponse>> AddAccountAsync(
                Models.ManagedAccountsAddRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ManagedAccountsAddResponse>()
              .Server(Server.SubscriptionServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/managedaccounts/actions/add")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Activates a managed billing service relationship between a managed account and the primary account.
        /// </summary>
        /// <param name="body">Required parameter: Service name and list of accounts to add.</param>
        /// <returns>Returns the ApiResponse of Models.ManagedAccountsProvisionResponse response from the API call.</returns>
        public ApiResponse<Models.ManagedAccountsProvisionResponse> ManagedAccountAction(
                Models.ManagedAccountsProvisionRequest body)
            => CoreHelper.RunTask(ManagedAccountActionAsync(body));

        /// <summary>
        /// Activates a managed billing service relationship between a managed account and the primary account.
        /// </summary>
        /// <param name="body">Required parameter: Service name and list of accounts to add.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ManagedAccountsProvisionResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ManagedAccountsProvisionResponse>> ManagedAccountActionAsync(
                Models.ManagedAccountsProvisionRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ManagedAccountsProvisionResponse>()
              .Server(Server.SubscriptionServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/managedaccounts/actions/provision")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Deactivates a managed billing service relationship between a managed account and the primary account. .
        /// </summary>
        /// <param name="body">Required parameter: Service name and list of accounts to add.</param>
        /// <returns>Returns the ApiResponse of Models.ManagedAccountCancelResponse response from the API call.</returns>
        public ApiResponse<Models.ManagedAccountCancelResponse> CancelManagedAccountAction(
                Models.ManagedAccountCancelRequest body)
            => CoreHelper.RunTask(CancelManagedAccountActionAsync(body));

        /// <summary>
        /// Deactivates a managed billing service relationship between a managed account and the primary account. .
        /// </summary>
        /// <param name="body">Required parameter: Service name and list of accounts to add.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ManagedAccountCancelResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ManagedAccountCancelResponse>> CancelManagedAccountActionAsync(
                Models.ManagedAccountCancelRequest body,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ManagedAccountCancelResponse>()
              .Server(Server.SubscriptionServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/managedaccounts/actions/cancel")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows user to retrieve the list of all accounts managed by a primary account.
        /// </summary>
        /// <param name="accountName">Required parameter: Primary account identifier.</param>
        /// <param name="serviceName">Required parameter: Service name.</param>
        /// <returns>Returns the ApiResponse of Models.ManagedAccountsGetAllResponse response from the API call.</returns>
        public ApiResponse<Models.ManagedAccountsGetAllResponse> ListManagedAccount(
                string accountName,
                string serviceName)
            => CoreHelper.RunTask(ListManagedAccountAsync(accountName, serviceName));

        /// <summary>
        /// This endpoint allows user to retrieve the list of all accounts managed by a primary account.
        /// </summary>
        /// <param name="accountName">Required parameter: Primary account identifier.</param>
        /// <param name="serviceName">Required parameter: Service name.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.ManagedAccountsGetAllResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.ManagedAccountsGetAllResponse>> ListManagedAccountAsync(
                string accountName,
                string serviceName,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ManagedAccountsGetAllResponse>()
              .Server(Server.SubscriptionServer)
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/managedaccounts/{accountName}/service/{serviceName}")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("thingspace_oauth")
                      .Add("VZ-M2M-Token")
                  )
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("accountName", accountName).Required())
                      .Template(_template => _template.Setup("serviceName", serviceName).Required())))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Unexpected error", (_reason, _context) => new DeviceLocationResultException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}