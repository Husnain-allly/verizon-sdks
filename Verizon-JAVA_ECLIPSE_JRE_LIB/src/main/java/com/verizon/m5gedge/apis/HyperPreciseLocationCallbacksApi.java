/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.apis;

import com.verizon.m5gedge.ApiHelper;
import com.verizon.m5gedge.Server;
import com.verizon.m5gedge.exceptions.ApiException;
import com.verizon.m5gedge.exceptions.HyperPreciseLocationResultException;
import com.verizon.m5gedge.http.request.HttpMethod;
import com.verizon.m5gedge.http.response.ApiResponse;
import com.verizon.m5gedge.models.CallbackCreated;
import com.verizon.m5gedge.models.CallbackRegistered;
import com.verizon.m5gedge.models.HyperPreciseLocationCallback;
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
public final class HyperPreciseLocationCallbacksApi extends BaseApi {

    /**
     * Initializes the controller.
     * @param globalConfig    Configurations added in client.
     */
    public HyperPreciseLocationCallbacksApi(GlobalConfiguration globalConfig) {
        super(globalConfig);
    }

    /**
     * Find registered callback listener for account by account number.
     * @param  accountNumber  Required parameter: A unique identifier for an account.
     * @return    Returns the List of CallbackCreated wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<List<CallbackCreated>> listRegisteredCallbacks(
            final String accountNumber) throws ApiException, IOException {
        return prepareListRegisteredCallbacksRequest(accountNumber).execute();
    }

    /**
     * Find registered callback listener for account by account number.
     * @param  accountNumber  Required parameter: A unique identifier for an account.
     * @return    Returns the List of CallbackCreated wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<List<CallbackCreated>>> listRegisteredCallbacksAsync(
            final String accountNumber) {
        try {
            return prepareListRegisteredCallbacksRequest(accountNumber).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for listRegisteredCallbacks.
     */
    private ApiCall<ApiResponse<List<CallbackCreated>>, ApiException> prepareListRegisteredCallbacksRequest(
            final String accountNumber) {
        return new ApiCall.Builder<ApiResponse<List<CallbackCreated>>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.HYPER_PRECISE_LOCATION.value())
                        .path("/callbacks")
                        .queryParam(param -> param.key("accountNumber")
                                .value(accountNumber))
                        .headerParam(param -> param.key("accept").value("application/json"))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("VZ-M2M-Token")))
                        .httpMethod(HttpMethod.GET))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .apiResponseDeserializer(
                                response -> ApiHelper.deserializeArray(response,
                                        CallbackCreated[].class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Bad request.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("401",
                                 ErrorCase.setReason("Unauthorized request. Access token is missing or invalid.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden request.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("404",
                                 ErrorCase.setReason("Bad request. Not found.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("409",
                                 ErrorCase.setReason("Bad request. Conflict state.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("500",
                                 ErrorCase.setReason("Internal Server Error.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * Registers a URL at which an account receives asynchronous responses and other messages from a
     * ThingSpace Platform callback service. The messages are REST messages. You are responsible for
     * creating and running a listening process on your server at that URL to receive and parse the
     * messages.
     * @param  accountNumber  Required parameter: A unique identifier for an account.
     * @param  body  Required parameter:
     * @return    Returns the CallbackRegistered wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<CallbackRegistered> registerCallback(
            final String accountNumber,
            final HyperPreciseLocationCallback body) throws ApiException, IOException {
        return prepareRegisterCallbackRequest(accountNumber, body).execute();
    }

    /**
     * Registers a URL at which an account receives asynchronous responses and other messages from a
     * ThingSpace Platform callback service. The messages are REST messages. You are responsible for
     * creating and running a listening process on your server at that URL to receive and parse the
     * messages.
     * @param  accountNumber  Required parameter: A unique identifier for an account.
     * @param  body  Required parameter:
     * @return    Returns the CallbackRegistered wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<CallbackRegistered>> registerCallbackAsync(
            final String accountNumber,
            final HyperPreciseLocationCallback body) {
        try {
            return prepareRegisterCallbackRequest(accountNumber, body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for registerCallback.
     */
    private ApiCall<ApiResponse<CallbackRegistered>, ApiException> prepareRegisterCallbackRequest(
            final String accountNumber,
            final HyperPreciseLocationCallback body) {
        return new ApiCall.Builder<ApiResponse<CallbackRegistered>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.HYPER_PRECISE_LOCATION.value())
                        .path("/callbacks")
                        .bodyParam(param -> param.value(body))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
                        .queryParam(param -> param.key("accountNumber")
                                .value(accountNumber))
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
                                response -> ApiHelper.deserialize(response, CallbackRegistered.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Bad request.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("401",
                                 ErrorCase.setReason("Unauthorized request. Access token is missing or invalid.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden request.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("404",
                                 ErrorCase.setReason("Bad request. Not found.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("409",
                                 ErrorCase.setReason("Bad request. Conflict state.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("500",
                                 ErrorCase.setReason("Internal Server Error.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * Stops ThingSpace from sending callback messages for the specified account and listener name.
     * @param  accountNumber  Required parameter: A unique identifier for a account.
     * @param  service  Required parameter: The name of the callback service that will be deleted.
     * @return    Returns the Void wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<Void> deregisterCallback(
            final String accountNumber,
            final String service) throws ApiException, IOException {
        return prepareDeregisterCallbackRequest(accountNumber, service).execute();
    }

    /**
     * Stops ThingSpace from sending callback messages for the specified account and listener name.
     * @param  accountNumber  Required parameter: A unique identifier for a account.
     * @param  service  Required parameter: The name of the callback service that will be deleted.
     * @return    Returns the Void wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<Void>> deregisterCallbackAsync(
            final String accountNumber,
            final String service) {
        try {
            return prepareDeregisterCallbackRequest(accountNumber, service).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for deregisterCallback.
     */
    private ApiCall<ApiResponse<Void>, ApiException> prepareDeregisterCallbackRequest(
            final String accountNumber,
            final String service) {
        return new ApiCall.Builder<ApiResponse<Void>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.HYPER_PRECISE_LOCATION.value())
                        .path("/callbacks")
                        .queryParam(param -> param.key("accountNumber")
                                .value(accountNumber))
                        .queryParam(param -> param.key("service")
                                .value(service))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("VZ-M2M-Token")))
                        .httpMethod(HttpMethod.DELETE))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Bad request.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("401",
                                 ErrorCase.setReason("Unauthorized request. Access token is missing or invalid.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden request.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("404",
                                 ErrorCase.setReason("Bad request. Not found.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("409",
                                 ErrorCase.setReason("Bad request. Conflict state.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .localErrorCase("500",
                                 ErrorCase.setReason("Internal Server Error.",
                                (reason, context) -> new HyperPreciseLocationResultException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }
}