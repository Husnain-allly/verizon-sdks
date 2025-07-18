/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.apis;

import com.verizon.m5gedge.ApiHelper;
import com.verizon.m5gedge.Server;
import com.verizon.m5gedge.exceptions.ApiException;
import com.verizon.m5gedge.exceptions.ReadySimRestErrorResponseException;
import com.verizon.m5gedge.http.request.HttpMethod;
import com.verizon.m5gedge.http.response.ApiResponse;
import com.verizon.m5gedge.models.RequestTrigger;
import com.verizon.m5gedge.models.Success;
import io.apimatic.core.ApiCall;
import io.apimatic.core.ErrorCase;
import io.apimatic.core.GlobalConfiguration;
import io.apimatic.coreinterfaces.http.request.ResponseClassType;
import java.io.IOException;
import java.util.concurrent.CompletableFuture;
import java.util.concurrent.CompletionException;

/**
 * This class lists all the endpoints of the groups.
 */
public final class UpdateTriggersApi extends BaseApi {

    /**
     * Initializes the controller.
     * @param globalConfig    Configurations added in client.
     */
    public UpdateTriggersApi(GlobalConfiguration globalConfig) {
        super(globalConfig);
    }

    /**
     * Updates the promotional triggers for pseudo-MDN.
     * @param  body  Optional parameter: Update the triggers
     * @return    Returns the Success wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<Success> updateAllAvailableTriggers(
            final RequestTrigger body) throws ApiException, IOException {
        return prepareUpdateAllAvailableTriggersRequest(body).execute();
    }

    /**
     * Updates the promotional triggers for pseudo-MDN.
     * @param  body  Optional parameter: Update the triggers
     * @return    Returns the Success wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<Success>> updateAllAvailableTriggersAsync(
            final RequestTrigger body) {
        try {
            return prepareUpdateAllAvailableTriggersRequest(body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for updateAllAvailableTriggers.
     */
    private ApiCall<ApiResponse<Success>, ApiException> prepareUpdateAllAvailableTriggersRequest(
            final RequestTrigger body) {
        return new ApiCall.Builder<ApiResponse<Success>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.THINGSPACE.value())
                        .path("/m2m/v2/triggers")
                        .bodyParam(param -> param.value(body).isRequired(false))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
                        .headerParam(param -> param.key("Content-Type")
                                .value("application/json").isRequired(false))
                        .headerParam(param -> param.key("accept").value("application/json"))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("VZ-M2M-Token")))
                        .httpMethod(HttpMethod.PUT))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .apiResponseDeserializer(
                                response -> ApiHelper.deserialize(response, Success.class))
                        .nullify404(false)
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("Error response",
                                (reason, context) -> new ReadySimRestErrorResponseException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }
}