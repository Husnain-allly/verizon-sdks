/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.apis;

import com.verizon.m5gedge.ApiHelper;
import com.verizon.m5gedge.Server;
import com.verizon.m5gedge.exceptions.ApiException;
import com.verizon.m5gedge.http.request.HttpMethod;
import com.verizon.m5gedge.http.response.ApiResponse;
import com.verizon.m5gedge.models.CreateIoTApplicationRequest;
import com.verizon.m5gedge.models.CreateIoTApplicationResponse;
import com.verizon.m5gedge.models.CreateTargetRequest;
import com.verizon.m5gedge.models.DeleteTargetRequest;
import com.verizon.m5gedge.models.GenerateExternalIdRequest;
import com.verizon.m5gedge.models.GenerateExternalIdResult;
import com.verizon.m5gedge.models.QueryTargetRequest;
import com.verizon.m5gedge.models.Target;
import io.apimatic.core.ApiCall;
import io.apimatic.core.GlobalConfiguration;
import io.apimatic.coreinterfaces.http.request.ResponseClassType;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.CompletableFuture;
import java.util.concurrent.CompletionException;

/**
 * This class lists all the endpoints of the groups.
 */
public final class TargetsApi extends BaseApi {

    /**
     * Initializes the controller.
     * @param globalConfig    Configurations added in client.
     */
    public TargetsApi(GlobalConfiguration globalConfig) {
        super(globalConfig);
    }

    /**
     * Search for targets by property values. Returns an array of all matching target resources.
     * @param  body  Required parameter: Search for targets by property values.
     * @return    Returns the List of Target wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<List<Target>> queryTarget(
            final QueryTargetRequest body) throws ApiException, IOException {
        return prepareQueryTargetRequest(body).execute();
    }

    /**
     * Search for targets by property values. Returns an array of all matching target resources.
     * @param  body  Required parameter: Search for targets by property values.
     * @return    Returns the List of Target wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<List<Target>>> queryTargetAsync(
            final QueryTargetRequest body) {
        try {
            return prepareQueryTargetRequest(body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for queryTarget.
     */
    private ApiCall<ApiResponse<List<Target>>, ApiException> prepareQueryTargetRequest(
            final QueryTargetRequest body) {
        return new ApiCall.Builder<ApiResponse<List<Target>>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.CLOUD_CONNECTOR.value())
                        .path("/targets/actions/query")
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
                                        Target[].class))
                        .nullify404(false)
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * Remove a target from a ThingSpace account.
     * @param  body  Required parameter: The request body identifies the target to delete.
     * @return    Returns the Void wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<Void> deleteTarget(
            final DeleteTargetRequest body) throws ApiException, IOException {
        return prepareDeleteTargetRequest(body).execute();
    }

    /**
     * Remove a target from a ThingSpace account.
     * @param  body  Required parameter: The request body identifies the target to delete.
     * @return    Returns the Void wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<Void>> deleteTargetAsync(
            final DeleteTargetRequest body) {
        try {
            return prepareDeleteTargetRequest(body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for deleteTarget.
     */
    private ApiCall<ApiResponse<Void>, ApiException> prepareDeleteTargetRequest(
            final DeleteTargetRequest body) {
        return new ApiCall.Builder<ApiResponse<Void>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.CLOUD_CONNECTOR.value())
                        .path("/targets/actions/delete")
                        .bodyParam(param -> param.value(body))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
                        .headerParam(param -> param.key("Content-Type")
                                .value("application/json").isRequired(false))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("VZ-M2M-Token")))
                        .httpMethod(HttpMethod.POST))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .nullify404(false)
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * Define a target to receive data streams, alerts, or callbacks. After creating the target
     * resource, use its ID in a subscription to set up a data stream.
     * @param  body  Required parameter: The request body provides the details of the target that
     *         you want to create.
     * @return    Returns the Target wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<Target> createTarget(
            final CreateTargetRequest body) throws ApiException, IOException {
        return prepareCreateTargetRequest(body).execute();
    }

    /**
     * Define a target to receive data streams, alerts, or callbacks. After creating the target
     * resource, use its ID in a subscription to set up a data stream.
     * @param  body  Required parameter: The request body provides the details of the target that
     *         you want to create.
     * @return    Returns the Target wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<Target>> createTargetAsync(
            final CreateTargetRequest body) {
        try {
            return prepareCreateTargetRequest(body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for createTarget.
     */
    private ApiCall<ApiResponse<Target>, ApiException> prepareCreateTargetRequest(
            final CreateTargetRequest body) {
        return new ApiCall.Builder<ApiResponse<Target>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.CLOUD_CONNECTOR.value())
                        .path("/targets")
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
                                response -> ApiHelper.deserialize(response, Target.class))
                        .nullify404(false)
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * Create a unique string that ThingSpace will pass to AWS for increased security.
     * @param  body  Required parameter: The request body only contains the authenticating account.
     * @return    Returns the GenerateExternalIdResult wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<GenerateExternalIdResult> generateTargetExternalId(
            final GenerateExternalIdRequest body) throws ApiException, IOException {
        return prepareGenerateTargetExternalIdRequest(body).execute();
    }

    /**
     * Create a unique string that ThingSpace will pass to AWS for increased security.
     * @param  body  Required parameter: The request body only contains the authenticating account.
     * @return    Returns the GenerateExternalIdResult wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<GenerateExternalIdResult>> generateTargetExternalIdAsync(
            final GenerateExternalIdRequest body) {
        try {
            return prepareGenerateTargetExternalIdRequest(body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for generateTargetExternalId.
     */
    private ApiCall<ApiResponse<GenerateExternalIdResult>, ApiException> prepareGenerateTargetExternalIdRequest(
            final GenerateExternalIdRequest body) {
        return new ApiCall.Builder<ApiResponse<GenerateExternalIdResult>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.CLOUD_CONNECTOR.value())
                        .path("/targets/actions/newextid")
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
                                response -> ApiHelper.deserialize(response, GenerateExternalIdResult.class))
                        .nullify404(false)
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * Deploy a new Azure IoT Central application based on the Verizon ARM template within the
     * specified Azure Active Directory account.
     * @param  billingaccountId  Required parameter: TThe ThingSpace ID of the authenticating
     *         billing account.
     * @param  body  Required parameter: The request body must include the UUID of the subscription
     *         that you want to update plus any properties that you want to change.
     * @return    Returns the CreateIoTApplicationResponse wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<CreateIoTApplicationResponse> createAzureCentralIoTApplication(
            final String billingaccountId,
            final CreateIoTApplicationRequest body) throws ApiException, IOException {
        return prepareCreateAzureCentralIoTApplicationRequest(billingaccountId, body).execute();
    }

    /**
     * Deploy a new Azure IoT Central application based on the Verizon ARM template within the
     * specified Azure Active Directory account.
     * @param  billingaccountId  Required parameter: TThe ThingSpace ID of the authenticating
     *         billing account.
     * @param  body  Required parameter: The request body must include the UUID of the subscription
     *         that you want to update plus any properties that you want to change.
     * @return    Returns the CreateIoTApplicationResponse wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<CreateIoTApplicationResponse>> createAzureCentralIoTApplicationAsync(
            final String billingaccountId,
            final CreateIoTApplicationRequest body) {
        try {
            return prepareCreateAzureCentralIoTApplicationRequest(billingaccountId, body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for createAzureCentralIoTApplication.
     */
    private ApiCall<ApiResponse<CreateIoTApplicationResponse>, ApiException> prepareCreateAzureCentralIoTApplicationRequest(
            final String billingaccountId,
            final CreateIoTApplicationRequest body) {
        return new ApiCall.Builder<ApiResponse<CreateIoTApplicationResponse>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.CLOUD_CONNECTOR.value())
                        .path("/targets/actions/newaic")
                        .bodyParam(param -> param.value(body))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
                        .headerParam(param -> param.key("BillingaccountID")
                                .value(billingaccountId).isRequired(false))
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
                                response -> ApiHelper.deserialize(response, CreateIoTApplicationResponse.class))
                        .nullify404(false)
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }
}