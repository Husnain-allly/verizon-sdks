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
import com.verizon.m5gedge.models.DtoListDevicesRequest;
import com.verizon.m5gedge.models.ResourceDevice;
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
public final class SensorInsightsGatewaysApi extends BaseApi {

    /**
     * Initializes the controller.
     * @param globalConfig    Configurations added in client.
     */
    public SensorInsightsGatewaysApi(GlobalConfiguration globalConfig) {
        super(globalConfig);
    }

    /**
     * @param  body  Required parameter: Get gateway information
     * @return    Returns the List of ResourceDevice wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<List<ResourceDevice>> sensorInsightsListGatewayDevicesRequest(
            final DtoListDevicesRequest body) throws ApiException, IOException {
        return prepareSensorInsightsListGatewayDevicesRequestRequest(body).execute();
    }

    /**
     * @param  body  Required parameter: Get gateway information
     * @return    Returns the List of ResourceDevice wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<List<ResourceDevice>>> sensorInsightsListGatewayDevicesRequestAsync(
            final DtoListDevicesRequest body) {
        try {
            return prepareSensorInsightsListGatewayDevicesRequestRequest(body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for sensorInsightsListGatewayDevicesRequest.
     */
    private ApiCall<ApiResponse<List<ResourceDevice>>, ApiException> prepareSensorInsightsListGatewayDevicesRequestRequest(
            final DtoListDevicesRequest body) {
        return new ApiCall.Builder<ApiResponse<List<ResourceDevice>>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.THINGSPACE.value())
                        .path("/dm/v1/devices/gateways/actions/query")
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
                                        ResourceDevice[].class))
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