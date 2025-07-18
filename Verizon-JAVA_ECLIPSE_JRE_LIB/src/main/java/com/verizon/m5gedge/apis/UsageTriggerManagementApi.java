/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.apis;

import com.verizon.m5gedge.ApiHelper;
import com.verizon.m5gedge.Server;
import com.verizon.m5gedge.exceptions.ApiException;
import com.verizon.m5gedge.exceptions.DeviceLocationResultException;
import com.verizon.m5gedge.http.request.HttpMethod;
import com.verizon.m5gedge.http.response.ApiResponse;
import com.verizon.m5gedge.models.DeviceLocationSuccessResult;
import com.verizon.m5gedge.models.UsageTriggerAddRequest;
import com.verizon.m5gedge.models.UsageTriggerResponse;
import com.verizon.m5gedge.models.UsageTriggerUpdateRequest;
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
public final class UsageTriggerManagementApi extends BaseApi {

    /**
     * Initializes the controller.
     * @param globalConfig    Configurations added in client.
     */
    public UsageTriggerManagementApi(GlobalConfiguration globalConfig) {
        super(globalConfig);
    }

    /**
     * Create a new usage trigger, which will send an alert when the number of device location
     * service transactions reaches a specified percentage of the monthly subscription amount.
     * @param  body  Optional parameter: License assignment.
     * @return    Returns the UsageTriggerResponse wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<UsageTriggerResponse> createNewTrigger(
            final UsageTriggerAddRequest body) throws ApiException, IOException {
        return prepareCreateNewTriggerRequest(body).execute();
    }

    /**
     * Create a new usage trigger, which will send an alert when the number of device location
     * service transactions reaches a specified percentage of the monthly subscription amount.
     * @param  body  Optional parameter: License assignment.
     * @return    Returns the UsageTriggerResponse wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<UsageTriggerResponse>> createNewTriggerAsync(
            final UsageTriggerAddRequest body) {
        try {
            return prepareCreateNewTriggerRequest(body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for createNewTrigger.
     */
    private ApiCall<ApiResponse<UsageTriggerResponse>, ApiException> prepareCreateNewTriggerRequest(
            final UsageTriggerAddRequest body) {
        return new ApiCall.Builder<ApiResponse<UsageTriggerResponse>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.SUBSCRIPTION_SERVER.value())
                        .path("/usage/triggers")
                        .bodyParam(param -> param.value(body).isRequired(false))
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
                                response -> ApiHelper.deserialize(response, UsageTriggerResponse.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Unexpected error",
                                (reason, context) -> new DeviceLocationResultException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * Update an existing usage trigger.
     * @param  triggerId  Required parameter: Usage trigger ID
     * @param  body  Optional parameter: New trigger values
     * @return    Returns the UsageTriggerResponse wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<UsageTriggerResponse> updateTrigger(
            final String triggerId,
            final UsageTriggerUpdateRequest body) throws ApiException, IOException {
        return prepareUpdateTriggerRequest(triggerId, body).execute();
    }

    /**
     * Update an existing usage trigger.
     * @param  triggerId  Required parameter: Usage trigger ID
     * @param  body  Optional parameter: New trigger values
     * @return    Returns the UsageTriggerResponse wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<UsageTriggerResponse>> updateTriggerAsync(
            final String triggerId,
            final UsageTriggerUpdateRequest body) {
        try {
            return prepareUpdateTriggerRequest(triggerId, body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for updateTrigger.
     */
    private ApiCall<ApiResponse<UsageTriggerResponse>, ApiException> prepareUpdateTriggerRequest(
            final String triggerId,
            final UsageTriggerUpdateRequest body) {
        return new ApiCall.Builder<ApiResponse<UsageTriggerResponse>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.SUBSCRIPTION_SERVER.value())
                        .path("/usage/triggers/{triggerId}")
                        .bodyParam(param -> param.value(body).isRequired(false))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
                        .templateParam(param -> param.key("triggerId").value(triggerId)
                                .shouldEncode(true))
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
                                response -> ApiHelper.deserialize(response, UsageTriggerResponse.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Unexpected error",
                                (reason, context) -> new DeviceLocationResultException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * eletes the specified usage trigger from the given account.
     * @param  accountName  Required parameter: Account name
     * @param  triggerId  Required parameter: Usage trigger ID
     * @return    Returns the DeviceLocationSuccessResult wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<DeviceLocationSuccessResult> deleteTrigger(
            final String accountName,
            final String triggerId) throws ApiException, IOException {
        return prepareDeleteTriggerRequest(accountName, triggerId).execute();
    }

    /**
     * eletes the specified usage trigger from the given account.
     * @param  accountName  Required parameter: Account name
     * @param  triggerId  Required parameter: Usage trigger ID
     * @return    Returns the DeviceLocationSuccessResult wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<DeviceLocationSuccessResult>> deleteTriggerAsync(
            final String accountName,
            final String triggerId) {
        try {
            return prepareDeleteTriggerRequest(accountName, triggerId).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for deleteTrigger.
     */
    private ApiCall<ApiResponse<DeviceLocationSuccessResult>, ApiException> prepareDeleteTriggerRequest(
            final String accountName,
            final String triggerId) {
        return new ApiCall.Builder<ApiResponse<DeviceLocationSuccessResult>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.SUBSCRIPTION_SERVER.value())
                        .path("/usage/accounts/{accountName}/triggers/{triggerId}")
                        .templateParam(param -> param.key("accountName").value(accountName)
                                .shouldEncode(true))
                        .templateParam(param -> param.key("triggerId").value(triggerId)
                                .shouldEncode(true))
                        .headerParam(param -> param.key("accept").value("application/json"))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("VZ-M2M-Token")))
                        .httpMethod(HttpMethod.DELETE))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .apiResponseDeserializer(
                                response -> ApiHelper.deserialize(response, DeviceLocationSuccessResult.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Unexpected error",
                                (reason, context) -> new DeviceLocationResultException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }
}