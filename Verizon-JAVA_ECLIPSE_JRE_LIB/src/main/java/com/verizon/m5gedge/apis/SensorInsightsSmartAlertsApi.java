/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.apis;

import com.verizon.m5gedge.ApiHelper;
import com.verizon.m5gedge.Server;
import com.verizon.m5gedge.exceptions.ApiException;
import com.verizon.m5gedge.exceptions.M400ManagementErrorException;
import com.verizon.m5gedge.exceptions.M403ManagementErrorException;
import com.verizon.m5gedge.exceptions.M404ManagementErrorException;
import com.verizon.m5gedge.exceptions.M500ManagementErrorException;
import com.verizon.m5gedge.exceptions.ManagementErrorException;
import com.verizon.m5gedge.http.request.HttpMethod;
import com.verizon.m5gedge.http.response.ApiResponse;
import com.verizon.m5gedge.models.DtoBulkUpdate;
import com.verizon.m5gedge.models.DtoListSmartAlertsRequest;
import com.verizon.m5gedge.models.DtoPatchSmartAlertRequest;
import com.verizon.m5gedge.models.UserSmartAlert;
import io.apimatic.core.ApiCall;
import io.apimatic.core.ErrorCase;
import io.apimatic.core.GlobalConfiguration;
import io.apimatic.coreinterfaces.http.request.ResponseClassType;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.CompletableFuture;
import java.util.concurrent.CompletionException;

/**
 * This class lists all the endpoints of the groups.
 */
public final class SensorInsightsSmartAlertsApi extends BaseApi {

    /**
     * Initializes the controller.
     * @param globalConfig    Configurations added in client.
     */
    public SensorInsightsSmartAlertsApi(GlobalConfiguration globalConfig) {
        super(globalConfig);
    }

    /**
     * @param  body  Required parameter: Retrieve a smart alert
     * @return    Returns the List of UserSmartAlert wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<List<UserSmartAlert>> sensorInsightsListSmartAlertsRequest(
            final DtoListSmartAlertsRequest body) throws ApiException, IOException {
        return prepareSensorInsightsListSmartAlertsRequestRequest(body).execute();
    }

    /**
     * @param  body  Required parameter: Retrieve a smart alert
     * @return    Returns the List of UserSmartAlert wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<List<UserSmartAlert>>> sensorInsightsListSmartAlertsRequestAsync(
            final DtoListSmartAlertsRequest body) {
        try {
            return prepareSensorInsightsListSmartAlertsRequestRequest(body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for sensorInsightsListSmartAlertsRequest.
     */
    private ApiCall<ApiResponse<List<UserSmartAlert>>, ApiException> prepareSensorInsightsListSmartAlertsRequestRequest(
            final DtoListSmartAlertsRequest body) {
        return new ApiCall.Builder<ApiResponse<List<UserSmartAlert>>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.THINGSPACE.value())
                        .path("/dm/v1/smartAlerts/actions/query")
                        .bodyParam(param -> param.value(body))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
                        .headerParam(param -> param.key("Content-Type")
                                .value("application/json").isRequired(false))
                        .headerParam(param -> param.key("accept").value("application/json"))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("VZ-M2M-Token")))
                        .httpMethod(HttpMethod.POST))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .apiResponseDeserializer(
                                response -> ApiHelper.deserializeArray(response,
                                        UserSmartAlert[].class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Bad Request",
                                (reason, context) -> new M400ManagementErrorException(reason, context)))
                        .localErrorCase("401",
                                 ErrorCase.setReason("UnAuthorized",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new M403ManagementErrorException(reason, context)))
                        .localErrorCase("404",
                                 ErrorCase.setReason("Not Found",
                                (reason, context) -> new M404ManagementErrorException(reason, context)))
                        .localErrorCase("406",
                                 ErrorCase.setReason("Not Acceptable",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .localErrorCase("415",
                                 ErrorCase.setReason("Unsupported media type",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too many requests",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .localErrorCase("500",
                                 ErrorCase.setReason("Internal server error.",
                                (reason, context) -> new M500ManagementErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("Unexpected error",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * @param  body  Required parameter: Partially update a smart alert
     * @return    Returns the UserSmartAlert wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<UserSmartAlert> sensorInsightsPatchSmartAlertRequest(
            final DtoPatchSmartAlertRequest body) throws ApiException, IOException {
        return prepareSensorInsightsPatchSmartAlertRequestRequest(body).execute();
    }

    /**
     * @param  body  Required parameter: Partially update a smart alert
     * @return    Returns the UserSmartAlert wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<UserSmartAlert>> sensorInsightsPatchSmartAlertRequestAsync(
            final DtoPatchSmartAlertRequest body) {
        try {
            return prepareSensorInsightsPatchSmartAlertRequestRequest(body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for sensorInsightsPatchSmartAlertRequest.
     */
    private ApiCall<ApiResponse<UserSmartAlert>, ApiException> prepareSensorInsightsPatchSmartAlertRequestRequest(
            final DtoPatchSmartAlertRequest body) {
        return new ApiCall.Builder<ApiResponse<UserSmartAlert>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.THINGSPACE.value())
                        .path("/dm/v1/smartAlerts")
                        .bodyParam(param -> param.value(body))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
                        .headerParam(param -> param.key("Content-Type")
                                .value("application/json").isRequired(false))
                        .headerParam(param -> param.key("accept").value("application/json"))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("VZ-M2M-Token")))
                        .httpMethod(HttpMethod.PATCH))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .apiResponseDeserializer(
                                response -> ApiHelper.deserialize(response, UserSmartAlert.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Bad Request",
                                (reason, context) -> new M400ManagementErrorException(reason, context)))
                        .localErrorCase("401",
                                 ErrorCase.setReason("UnAuthorized",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new M403ManagementErrorException(reason, context)))
                        .localErrorCase("404",
                                 ErrorCase.setReason("Not Found",
                                (reason, context) -> new M404ManagementErrorException(reason, context)))
                        .localErrorCase("406",
                                 ErrorCase.setReason("Not Acceptable",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .localErrorCase("415",
                                 ErrorCase.setReason("Unsupported media type",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too many requests",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .localErrorCase("500",
                                 ErrorCase.setReason("Internal server error.",
                                (reason, context) -> new M500ManagementErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("Unexpected error",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * @param  body  Required parameter: Bulk update smart alerts
     * @return    Returns the UserSmartAlert wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<UserSmartAlert> sensorInsightsBulkUpdate(
            final DtoBulkUpdate body) throws ApiException, IOException {
        return prepareSensorInsightsBulkUpdateRequest(body).execute();
    }

    /**
     * @param  body  Required parameter: Bulk update smart alerts
     * @return    Returns the UserSmartAlert wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<UserSmartAlert>> sensorInsightsBulkUpdateAsync(
            final DtoBulkUpdate body) {
        try {
            return prepareSensorInsightsBulkUpdateRequest(body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for sensorInsightsBulkUpdate.
     */
    private ApiCall<ApiResponse<UserSmartAlert>, ApiException> prepareSensorInsightsBulkUpdateRequest(
            final DtoBulkUpdate body) {
        return new ApiCall.Builder<ApiResponse<UserSmartAlert>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.THINGSPACE.value())
                        .path("/dm/v1/smartAlerts/actions/bulkupdate")
                        .bodyParam(param -> param.value(body))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
                        .headerParam(param -> param.key("Content-Type")
                                .value("application/json").isRequired(false))
                        .headerParam(param -> param.key("accept").value("application/json"))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("VZ-M2M-Token")))
                        .httpMethod(HttpMethod.POST))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .apiResponseDeserializer(
                                response -> ApiHelper.deserialize(response, UserSmartAlert.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Bad Request",
                                (reason, context) -> new M400ManagementErrorException(reason, context)))
                        .localErrorCase("401",
                                 ErrorCase.setReason("UnAuthorized",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new M403ManagementErrorException(reason, context)))
                        .localErrorCase("404",
                                 ErrorCase.setReason("Not Found",
                                (reason, context) -> new M404ManagementErrorException(reason, context)))
                        .localErrorCase("406",
                                 ErrorCase.setReason("Not Acceptable",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .localErrorCase("415",
                                 ErrorCase.setReason("Unsupported media type",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too many requests",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .localErrorCase("500",
                                 ErrorCase.setReason("Internal server error.",
                                (reason, context) -> new M500ManagementErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("Unexpected error",
                                (reason, context) -> new ManagementErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }
}