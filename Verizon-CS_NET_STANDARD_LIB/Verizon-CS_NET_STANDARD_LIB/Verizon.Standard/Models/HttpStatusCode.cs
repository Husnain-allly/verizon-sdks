// <copyright file="HttpStatusCode.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// HttpStatusCode.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum HttpStatusCode
    {
        /// <summary>
        /// Enum100Continue.
        /// </summary>
        [EnumMember(Value = "100 CONTINUE")]
        Enum100Continue,

        /// <summary>
        /// Enum101SwitchingProtocols.
        /// </summary>
        [EnumMember(Value = "101 SWITCHING_PROTOCOLS")]
        Enum101SwitchingProtocols,

        /// <summary>
        /// Enum102Processing.
        /// </summary>
        [EnumMember(Value = "102 PROCESSING")]
        Enum102Processing,

        /// <summary>
        /// Enum103Checkpoint.
        /// </summary>
        [EnumMember(Value = "103 CHECKPOINT")]
        Enum103Checkpoint,

        /// <summary>
        /// Enum200Ok.
        /// </summary>
        [EnumMember(Value = "200 OK")]
        Enum200Ok,

        /// <summary>
        /// Enum201Created.
        /// </summary>
        [EnumMember(Value = "201 CREATED")]
        Enum201Created,

        /// <summary>
        /// Enum202Accepted.
        /// </summary>
        [EnumMember(Value = "202 ACCEPTED")]
        Enum202Accepted,

        /// <summary>
        /// Enum203NonAuthoritativeInformation.
        /// </summary>
        [EnumMember(Value = "203 NON_AUTHORITATIVE_INFORMATION")]
        Enum203NonAuthoritativeInformation,

        /// <summary>
        /// Enum204NoContent.
        /// </summary>
        [EnumMember(Value = "204 NO_CONTENT")]
        Enum204NoContent,

        /// <summary>
        /// Enum205ResetContent.
        /// </summary>
        [EnumMember(Value = "205 RESET_CONTENT")]
        Enum205ResetContent,

        /// <summary>
        /// Enum206PartialContent.
        /// </summary>
        [EnumMember(Value = "206 PARTIAL_CONTENT")]
        Enum206PartialContent,

        /// <summary>
        /// Enum207MultiStatus.
        /// </summary>
        [EnumMember(Value = "207 MULTI_STATUS")]
        Enum207MultiStatus,

        /// <summary>
        /// Enum208AlreadyReported.
        /// </summary>
        [EnumMember(Value = "208 ALREADY_REPORTED")]
        Enum208AlreadyReported,

        /// <summary>
        /// Enum226ImUsed.
        /// </summary>
        [EnumMember(Value = "226 IM_USED")]
        Enum226ImUsed,

        /// <summary>
        /// Enum300MultipleChoices.
        /// </summary>
        [EnumMember(Value = "300 MULTIPLE_CHOICES")]
        Enum300MultipleChoices,

        /// <summary>
        /// Enum301MovedPermanently.
        /// </summary>
        [EnumMember(Value = "301 MOVED_PERMANENTLY")]
        Enum301MovedPermanently,

        /// <summary>
        /// Enum302Found.
        /// </summary>
        [EnumMember(Value = "302 FOUND")]
        Enum302Found,

        /// <summary>
        /// Enum302MovedTemporarily.
        /// </summary>
        [EnumMember(Value = "302 MOVED_TEMPORARILY")]
        Enum302MovedTemporarily,

        /// <summary>
        /// Enum303SeeOther.
        /// </summary>
        [EnumMember(Value = "303 SEE_OTHER")]
        Enum303SeeOther,

        /// <summary>
        /// Enum304NotModified.
        /// </summary>
        [EnumMember(Value = "304 NOT_MODIFIED")]
        Enum304NotModified,

        /// <summary>
        /// Enum305UseProxy.
        /// </summary>
        [EnumMember(Value = "305 USE_PROXY")]
        Enum305UseProxy,

        /// <summary>
        /// Enum307TemporaryRedirect.
        /// </summary>
        [EnumMember(Value = "307 TEMPORARY_REDIRECT")]
        Enum307TemporaryRedirect,

        /// <summary>
        /// Enum308PermanentRedirect.
        /// </summary>
        [EnumMember(Value = "308 PERMANENT_REDIRECT")]
        Enum308PermanentRedirect,

        /// <summary>
        /// Enum400BadRequest.
        /// </summary>
        [EnumMember(Value = "400 BAD_REQUEST")]
        Enum400BadRequest,

        /// <summary>
        /// Enum401Unauthorized.
        /// </summary>
        [EnumMember(Value = "401 UNAUTHORIZED")]
        Enum401Unauthorized,

        /// <summary>
        /// Enum402PaymentRequired.
        /// </summary>
        [EnumMember(Value = "402 PAYMENT_REQUIRED")]
        Enum402PaymentRequired,

        /// <summary>
        /// Enum403Forbidden.
        /// </summary>
        [EnumMember(Value = "403 FORBIDDEN")]
        Enum403Forbidden,

        /// <summary>
        /// Enum404NotFound.
        /// </summary>
        [EnumMember(Value = "404 NOT_FOUND")]
        Enum404NotFound,

        /// <summary>
        /// Enum405MethodNotAllowed.
        /// </summary>
        [EnumMember(Value = "405 METHOD_NOT_ALLOWED")]
        Enum405MethodNotAllowed,

        /// <summary>
        /// Enum406NotAcceptable.
        /// </summary>
        [EnumMember(Value = "406 NOT_ACCEPTABLE")]
        Enum406NotAcceptable,

        /// <summary>
        /// Enum407ProxyAuthenticationRequired.
        /// </summary>
        [EnumMember(Value = "407 PROXY_AUTHENTICATION_REQUIRED")]
        Enum407ProxyAuthenticationRequired,

        /// <summary>
        /// Enum408RequestTimeout.
        /// </summary>
        [EnumMember(Value = "408 REQUEST_TIMEOUT")]
        Enum408RequestTimeout,

        /// <summary>
        /// Enum409Conflict.
        /// </summary>
        [EnumMember(Value = "409 CONFLICT")]
        Enum409Conflict,

        /// <summary>
        /// Enum410Gone.
        /// </summary>
        [EnumMember(Value = "410 GONE")]
        Enum410Gone,

        /// <summary>
        /// Enum411LengthRequired.
        /// </summary>
        [EnumMember(Value = "411 LENGTH_REQUIRED")]
        Enum411LengthRequired,

        /// <summary>
        /// Enum412PreconditionFailed.
        /// </summary>
        [EnumMember(Value = "412 PRECONDITION_FAILED")]
        Enum412PreconditionFailed,

        /// <summary>
        /// Enum413PayloadTooLarge.
        /// </summary>
        [EnumMember(Value = "413 PAYLOAD_TOO_LARGE")]
        Enum413PayloadTooLarge,

        /// <summary>
        /// Enum413RequestEntityTooLarge.
        /// </summary>
        [EnumMember(Value = "413 REQUEST_ENTITY_TOO_LARGE")]
        Enum413RequestEntityTooLarge,

        /// <summary>
        /// Enum414UriTooLong.
        /// </summary>
        [EnumMember(Value = "414 URI_TOO_LONG")]
        Enum414UriTooLong,

        /// <summary>
        /// Enum414RequestUriTooLong.
        /// </summary>
        [EnumMember(Value = "414 REQUEST_URI_TOO_LONG")]
        Enum414RequestUriTooLong,

        /// <summary>
        /// Enum415UnsupportedMediaType.
        /// </summary>
        [EnumMember(Value = "415 UNSUPPORTED_MEDIA_TYPE")]
        Enum415UnsupportedMediaType,

        /// <summary>
        /// Enum416RequestedRangeNotSatisfiable.
        /// </summary>
        [EnumMember(Value = "416 REQUESTED_RANGE_NOT_SATISFIABLE")]
        Enum416RequestedRangeNotSatisfiable,

        /// <summary>
        /// Enum417ExpectationFailed.
        /// </summary>
        [EnumMember(Value = "417 EXPECTATION_FAILED")]
        Enum417ExpectationFailed,

        /// <summary>
        /// Enum418IAmATeapot.
        /// </summary>
        [EnumMember(Value = "418 I_AM_A_TEAPOT")]
        Enum418IAmATeapot,

        /// <summary>
        /// Enum419InsufficientSpaceOnResource.
        /// </summary>
        [EnumMember(Value = "419 INSUFFICIENT_SPACE_ON_RESOURCE")]
        Enum419InsufficientSpaceOnResource,

        /// <summary>
        /// Enum420MethodFailure.
        /// </summary>
        [EnumMember(Value = "420 METHOD_FAILURE")]
        Enum420MethodFailure,

        /// <summary>
        /// Enum421DestinationLocked.
        /// </summary>
        [EnumMember(Value = "421 DESTINATION_LOCKED")]
        Enum421DestinationLocked,

        /// <summary>
        /// Enum422UnprocessableEntity.
        /// </summary>
        [EnumMember(Value = "422 UNPROCESSABLE_ENTITY")]
        Enum422UnprocessableEntity,

        /// <summary>
        /// Enum423Locked.
        /// </summary>
        [EnumMember(Value = "423 LOCKED")]
        Enum423Locked,

        /// <summary>
        /// Enum424FailedDependency.
        /// </summary>
        [EnumMember(Value = "424 FAILED_DEPENDENCY")]
        Enum424FailedDependency,

        /// <summary>
        /// Enum425TooEarly.
        /// </summary>
        [EnumMember(Value = "425 TOO_EARLY")]
        Enum425TooEarly,

        /// <summary>
        /// Enum426UpgradeRequired.
        /// </summary>
        [EnumMember(Value = "426 UPGRADE_REQUIRED")]
        Enum426UpgradeRequired,

        /// <summary>
        /// Enum428PreconditionRequired.
        /// </summary>
        [EnumMember(Value = "428 PRECONDITION_REQUIRED")]
        Enum428PreconditionRequired,

        /// <summary>
        /// Enum429TooManyRequests.
        /// </summary>
        [EnumMember(Value = "429 TOO_MANY_REQUESTS")]
        Enum429TooManyRequests,

        /// <summary>
        /// Enum431RequestHeaderFieldsTooLarge.
        /// </summary>
        [EnumMember(Value = "431 REQUEST_HEADER_FIELDS_TOO_LARGE")]
        Enum431RequestHeaderFieldsTooLarge,

        /// <summary>
        /// Enum451UnavailableForLegalReasons.
        /// </summary>
        [EnumMember(Value = "451 UNAVAILABLE_FOR_LEGAL_REASONS")]
        Enum451UnavailableForLegalReasons,

        /// <summary>
        /// Enum500InternalServerError.
        /// </summary>
        [EnumMember(Value = "500 INTERNAL_SERVER_ERROR")]
        Enum500InternalServerError,

        /// <summary>
        /// Enum501NotImplemented.
        /// </summary>
        [EnumMember(Value = "501 NOT_IMPLEMENTED")]
        Enum501NotImplemented,

        /// <summary>
        /// Enum502BadGateway.
        /// </summary>
        [EnumMember(Value = "502 BAD_GATEWAY")]
        Enum502BadGateway,

        /// <summary>
        /// Enum503ServiceUnavailable.
        /// </summary>
        [EnumMember(Value = "503 SERVICE_UNAVAILABLE")]
        Enum503ServiceUnavailable,

        /// <summary>
        /// Enum504GatewayTimeout.
        /// </summary>
        [EnumMember(Value = "504 GATEWAY_TIMEOUT")]
        Enum504GatewayTimeout,

        /// <summary>
        /// Enum505HttpVersionNotSupported.
        /// </summary>
        [EnumMember(Value = "505 HTTP_VERSION_NOT_SUPPORTED")]
        Enum505HttpVersionNotSupported,

        /// <summary>
        /// Enum506VariantAlsoNegotiates.
        /// </summary>
        [EnumMember(Value = "506 VARIANT_ALSO_NEGOTIATES")]
        Enum506VariantAlsoNegotiates,

        /// <summary>
        /// Enum507InsufficientStorage.
        /// </summary>
        [EnumMember(Value = "507 INSUFFICIENT_STORAGE")]
        Enum507InsufficientStorage,

        /// <summary>
        /// Enum508LoopDetected.
        /// </summary>
        [EnumMember(Value = "508 LOOP_DETECTED")]
        Enum508LoopDetected,

        /// <summary>
        /// Enum509BandwidthLimitExceeded.
        /// </summary>
        [EnumMember(Value = "509 BANDWIDTH_LIMIT_EXCEEDED")]
        Enum509BandwidthLimitExceeded,

        /// <summary>
        /// Enum510NotExtended.
        /// </summary>
        [EnumMember(Value = "510 NOT_EXTENDED")]
        Enum510NotExtended,

        /// <summary>
        /// Enum511NetworkAuthenticationRequired.
        /// </summary>
        [EnumMember(Value = "511 NETWORK_AUTHENTICATION_REQUIRED")]
        Enum511NetworkAuthenticationRequired
    }
}