/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.apis;

import com.verizon.m5gedge.ApiHelper;
import com.verizon.m5gedge.Server;
import com.verizon.m5gedge.exceptions.ApiException;
import com.verizon.m5gedge.exceptions.AppConfigResponseErrorException;
import com.verizon.m5gedge.http.request.HttpMethod;
import com.verizon.m5gedge.http.response.ApiResponse;
import com.verizon.m5gedge.models.ConfigurationListItem;
import com.verizon.m5gedge.models.GeoFenceConfigurationRequest;
import com.verizon.m5gedge.models.GeoFenceConfigurationResponse;
import com.verizon.m5gedge.models.GeoFenceConfigurationUpdateRequest;
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
public final class AppConfigServiceApi extends BaseApi {

    /**
     * Initializes the controller.
     * @param globalConfig    Configurations added in client.
     */
    public AppConfigServiceApi(GlobalConfiguration globalConfig) {
        super(globalConfig);
    }

    /**
     * This endpoint fetches and returns the list of configurations defined by the Vendor. The list
     * contains the configurations' identifier, name, description, and active flag. The vendor ID is
     * provided when the configuration is created through the POST request. Note: The user needs to
     * authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens
     * in order to call this API.
     * @param  vendorId  Required parameter: The vendor's identifier
     * @return    Returns the List of ConfigurationListItem wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<List<ConfigurationListItem>> getConfigurationList(
            final String vendorId) throws ApiException, IOException {
        return prepareGetConfigurationListRequest(vendorId).execute();
    }

    /**
     * This endpoint fetches and returns the list of configurations defined by the Vendor. The list
     * contains the configurations' identifier, name, description, and active flag. The vendor ID is
     * provided when the configuration is created through the POST request. Note: The user needs to
     * authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens
     * in order to call this API.
     * @param  vendorId  Required parameter: The vendor's identifier
     * @return    Returns the List of ConfigurationListItem wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<List<ConfigurationListItem>>> getConfigurationListAsync(
            final String vendorId) {
        try {
            return prepareGetConfigurationListRequest(vendorId).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for getConfigurationList.
     */
    private ApiCall<ApiResponse<List<ConfigurationListItem>>, ApiException> prepareGetConfigurationListRequest(
            final String vendorId) {
        return new ApiCall.Builder<ApiResponse<List<ConfigurationListItem>>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.IMP_SERVER.value())
                        .path("/api/v1/application/configurations/geofence/ids")
                        .headerParam(param -> param.key("VendorID")
                                .value(vendorId).isRequired(false))
                        .headerParam(param -> param.key("accept").value("application/json"))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("SessionToken")))
                        .httpMethod(HttpMethod.GET))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .apiResponseDeserializer(
                                response -> ApiHelper.deserializeArray(response,
                                        ConfigurationListItem[].class))
                        .nullify404(false)
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase("404",
                                 ErrorCase.setReason("Configuration not found",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too many requests",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("unexpected error",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * This endpoint fetches and returns a specific configuration's details. The configuration ID
     * parameter, which was provided when the configuration was created through the POST request, is
     * need to retrieve the configuration details. Note: The user needs to authenticate with their
     * ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this
     * API.
     * @param  id  Required parameter: The configuration identifier
     * @param  vendorId  Required parameter: The vendor's identifier
     * @return    Returns the GeoFenceConfigurationResponse wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<GeoFenceConfigurationResponse> getConfiguration(
            final String id,
            final String vendorId) throws ApiException, IOException {
        return prepareGetConfigurationRequest(id, vendorId).execute();
    }

    /**
     * This endpoint fetches and returns a specific configuration's details. The configuration ID
     * parameter, which was provided when the configuration was created through the POST request, is
     * need to retrieve the configuration details. Note: The user needs to authenticate with their
     * ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this
     * API.
     * @param  id  Required parameter: The configuration identifier
     * @param  vendorId  Required parameter: The vendor's identifier
     * @return    Returns the GeoFenceConfigurationResponse wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<GeoFenceConfigurationResponse>> getConfigurationAsync(
            final String id,
            final String vendorId) {
        try {
            return prepareGetConfigurationRequest(id, vendorId).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for getConfiguration.
     */
    private ApiCall<ApiResponse<GeoFenceConfigurationResponse>, ApiException> prepareGetConfigurationRequest(
            final String id,
            final String vendorId) {
        return new ApiCall.Builder<ApiResponse<GeoFenceConfigurationResponse>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.IMP_SERVER.value())
                        .path("/api/v1/application/configurations/geofence")
                        .queryParam(param -> param.key("id")
                                .value(id))
                        .headerParam(param -> param.key("VendorID")
                                .value(vendorId).isRequired(false))
                        .headerParam(param -> param.key("accept").value("application/json"))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("SessionToken")))
                        .httpMethod(HttpMethod.GET))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .apiResponseDeserializer(
                                response -> ApiHelper.deserialize(response, GeoFenceConfigurationResponse.class))
                        .nullify404(false)
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase("404",
                                 ErrorCase.setReason("Configuration not found",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too many requests",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("unexpected error",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * This endpoint creates a new configuration in the system. The data for the new configuration
     * should be provided as JSON in the body of the POST request. The system will return with a
     * unique ID for the configuration, which is needed for any further manipulation (update or
     * delete) of the configuration. Note: The user needs to authenticate with their ThingSpace
     * credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
     * @param  vendorId  Required parameter: The vendor's identifier
     * @param  body  Required parameter:
     * @return    Returns the GeoFenceConfigurationResponse wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<GeoFenceConfigurationResponse> createConfiguration(
            final String vendorId,
            final GeoFenceConfigurationRequest body) throws ApiException, IOException {
        return prepareCreateConfigurationRequest(vendorId, body).execute();
    }

    /**
     * This endpoint creates a new configuration in the system. The data for the new configuration
     * should be provided as JSON in the body of the POST request. The system will return with a
     * unique ID for the configuration, which is needed for any further manipulation (update or
     * delete) of the configuration. Note: The user needs to authenticate with their ThingSpace
     * credentials using the Access/Bearer and Session/M2M tokens in order to call this API.
     * @param  vendorId  Required parameter: The vendor's identifier
     * @param  body  Required parameter:
     * @return    Returns the GeoFenceConfigurationResponse wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<GeoFenceConfigurationResponse>> createConfigurationAsync(
            final String vendorId,
            final GeoFenceConfigurationRequest body) {
        try {
            return prepareCreateConfigurationRequest(vendorId, body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for createConfiguration.
     */
    private ApiCall<ApiResponse<GeoFenceConfigurationResponse>, ApiException> prepareCreateConfigurationRequest(
            final String vendorId,
            final GeoFenceConfigurationRequest body) {
        return new ApiCall.Builder<ApiResponse<GeoFenceConfigurationResponse>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.IMP_SERVER.value())
                        .path("/api/v1/application/configurations/geofence")
                        .bodyParam(param -> param.value(body))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
                        .headerParam(param -> param.key("VendorID")
                                .value(vendorId).isRequired(false))
                        .headerParam(param -> param.key("Content-Type")
                                .value("application/json").isRequired(false))
                        .headerParam(param -> param.key("accept").value("application/json"))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("SessionToken")))
                        .httpMethod(HttpMethod.POST))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .apiResponseDeserializer(
                                response -> ApiHelper.deserialize(response, GeoFenceConfigurationResponse.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Invalid configuration",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too many requests",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("unexpected error",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * This endpoint updates an existing configuration. Similar to POST, the updated data for the
     * configuration should be provided as JSON in the body of the PUT request. The configuration ID
     * parameter, which was provided by the POST (create) operation, is required to do any updates
     * on the configuration. Note: The user needs to authenticate with their ThingSpace credentials
     * using the Access/Bearer and Session/M2M tokens in order to call this API.
     * @param  vendorId  Required parameter: The vendor's identifier
     * @param  id  Required parameter: The configuration identifier
     * @param  body  Required parameter:
     * @return    Returns the Void wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<Void> updateConfiguration(
            final String vendorId,
            final String id,
            final GeoFenceConfigurationUpdateRequest body) throws ApiException, IOException {
        return prepareUpdateConfigurationRequest(vendorId, id, body).execute();
    }

    /**
     * This endpoint updates an existing configuration. Similar to POST, the updated data for the
     * configuration should be provided as JSON in the body of the PUT request. The configuration ID
     * parameter, which was provided by the POST (create) operation, is required to do any updates
     * on the configuration. Note: The user needs to authenticate with their ThingSpace credentials
     * using the Access/Bearer and Session/M2M tokens in order to call this API.
     * @param  vendorId  Required parameter: The vendor's identifier
     * @param  id  Required parameter: The configuration identifier
     * @param  body  Required parameter:
     * @return    Returns the Void wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<Void>> updateConfigurationAsync(
            final String vendorId,
            final String id,
            final GeoFenceConfigurationUpdateRequest body) {
        try {
            return prepareUpdateConfigurationRequest(vendorId, id, body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for updateConfiguration.
     */
    private ApiCall<ApiResponse<Void>, ApiException> prepareUpdateConfigurationRequest(
            final String vendorId,
            final String id,
            final GeoFenceConfigurationUpdateRequest body) {
        return new ApiCall.Builder<ApiResponse<Void>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.IMP_SERVER.value())
                        .path("/api/v1/application/configurations/geofence")
                        .bodyParam(param -> param.value(body))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
                        .queryParam(param -> param.key("id")
                                .value(id))
                        .headerParam(param -> param.key("VendorID")
                                .value(vendorId).isRequired(false))
                        .headerParam(param -> param.key("Content-Type")
                                .value("application/json").isRequired(false))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("SessionToken")))
                        .httpMethod(HttpMethod.PUT))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Invalid configuration",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase("404",
                                 ErrorCase.setReason("Configuration not found",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too many requests",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("unexpected error",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * This endpoint deletes a specific configuration from the system. It requires the configuration
     * ID parameter, which was provided by the POST (create) operation. Note: The user needs to
     * authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens
     * in order to call this API.
     * @param  vendorId  Required parameter: The vendor's identifier
     * @param  id  Required parameter: The configuration identifier
     * @return    Returns the Void wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<Void> deleteConfiguration(
            final String vendorId,
            final String id) throws ApiException, IOException {
        return prepareDeleteConfigurationRequest(vendorId, id).execute();
    }

    /**
     * This endpoint deletes a specific configuration from the system. It requires the configuration
     * ID parameter, which was provided by the POST (create) operation. Note: The user needs to
     * authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens
     * in order to call this API.
     * @param  vendorId  Required parameter: The vendor's identifier
     * @param  id  Required parameter: The configuration identifier
     * @return    Returns the Void wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<Void>> deleteConfigurationAsync(
            final String vendorId,
            final String id) {
        try {
            return prepareDeleteConfigurationRequest(vendorId, id).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for deleteConfiguration.
     */
    private ApiCall<ApiResponse<Void>, ApiException> prepareDeleteConfigurationRequest(
            final String vendorId,
            final String id) {
        return new ApiCall.Builder<ApiResponse<Void>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.IMP_SERVER.value())
                        .path("/api/v1/application/configurations/geofence")
                        .queryParam(param -> param.key("id")
                                .value(id))
                        .headerParam(param -> param.key("VendorID")
                                .value(vendorId).isRequired(false))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("SessionToken")))
                        .httpMethod(HttpMethod.DELETE))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .nullify404(false)
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too many requests",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("unexpected error",
                                (reason, context) -> new AppConfigResponseErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }
}