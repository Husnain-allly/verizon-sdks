/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.apis;

import com.verizon.m5gedge.ApiHelper;
import com.verizon.m5gedge.Server;
import com.verizon.m5gedge.exceptions.ApiException;
import com.verizon.m5gedge.exceptions.FotaV3ResultException;
import com.verizon.m5gedge.http.request.HttpMethod;
import com.verizon.m5gedge.http.response.ApiResponse;
import com.verizon.m5gedge.models.DeviceFirmwareList;
import com.verizon.m5gedge.models.DeviceFirmwareVersionUpdateResult;
import com.verizon.m5gedge.models.FirmwareImei;
import com.verizon.m5gedge.models.FirmwarePackage;
import com.verizon.m5gedge.models.FirmwareProtocol;
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
public final class FirmwareV3Api extends BaseApi {

    /**
     * Initializes the controller.
     * @param globalConfig    Configurations added in client.
     */
    public FirmwareV3Api(GlobalConfiguration globalConfig) {
        super(globalConfig);
    }

    /**
     * This endpoint allows user to list the firmware of an account.
     * @param  acc  Required parameter: Account identifier.
     * @param  protocol  Required parameter: Filter to retrieve a specific protocol type used.
     * @return    Returns the List of FirmwarePackage wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<List<FirmwarePackage>> listAvailableFirmware(
            final String acc,
            final FirmwareProtocol protocol) throws ApiException, IOException {
        return prepareListAvailableFirmwareRequest(acc, protocol).execute();
    }

    /**
     * This endpoint allows user to list the firmware of an account.
     * @param  acc  Required parameter: Account identifier.
     * @param  protocol  Required parameter: Filter to retrieve a specific protocol type used.
     * @return    Returns the List of FirmwarePackage wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<List<FirmwarePackage>>> listAvailableFirmwareAsync(
            final String acc,
            final FirmwareProtocol protocol) {
        try {
            return prepareListAvailableFirmwareRequest(acc, protocol).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for listAvailableFirmware.
     */
    private ApiCall<ApiResponse<List<FirmwarePackage>>, ApiException> prepareListAvailableFirmwareRequest(
            final String acc,
            final FirmwareProtocol protocol) {
        return new ApiCall.Builder<ApiResponse<List<FirmwarePackage>>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.SOFTWARE_MANAGEMENT_V3.value())
                        .path("/firmware/{acc}")
                        .queryParam(param -> param.key("protocol")
                                .value((protocol != null) ? protocol.value() : "LWM2M"))
                        .templateParam(param -> param.key("acc").value(acc)
                                .shouldEncode(true))
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
                                        FirmwarePackage[].class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Unexpected error.",
                                (reason, context) -> new FotaV3ResultException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * Synchronize ThingSpace with the FOTA server for up to 100 devices.
     * @param  acc  Required parameter: Account identifier.
     * @param  body  Required parameter: DeviceIds to get firmware info synchronously.
     * @return    Returns the DeviceFirmwareList wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<DeviceFirmwareList> synchronizeDeviceFirmware(
            final String acc,
            final FirmwareImei body) throws ApiException, IOException {
        return prepareSynchronizeDeviceFirmwareRequest(acc, body).execute();
    }

    /**
     * Synchronize ThingSpace with the FOTA server for up to 100 devices.
     * @param  acc  Required parameter: Account identifier.
     * @param  body  Required parameter: DeviceIds to get firmware info synchronously.
     * @return    Returns the DeviceFirmwareList wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<DeviceFirmwareList>> synchronizeDeviceFirmwareAsync(
            final String acc,
            final FirmwareImei body) {
        try {
            return prepareSynchronizeDeviceFirmwareRequest(acc, body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for synchronizeDeviceFirmware.
     */
    private ApiCall<ApiResponse<DeviceFirmwareList>, ApiException> prepareSynchronizeDeviceFirmwareRequest(
            final String acc,
            final FirmwareImei body) {
        return new ApiCall.Builder<ApiResponse<DeviceFirmwareList>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.SOFTWARE_MANAGEMENT_V3.value())
                        .path("/firmware/{acc}/devices")
                        .bodyParam(param -> param.value(body))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
                        .templateParam(param -> param.key("acc").value(acc)
                                .shouldEncode(true))
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
                                response -> ApiHelper.deserialize(response, DeviceFirmwareList.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Unexpected error.",
                                (reason, context) -> new FotaV3ResultException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * Ask a device to report its firmware version asynchronously.
     * @param  acc  Required parameter: Account identifier.
     * @param  deviceId  Required parameter: Device identifier.
     * @return    Returns the DeviceFirmwareVersionUpdateResult wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<DeviceFirmwareVersionUpdateResult> reportDeviceFirmware(
            final String acc,
            final String deviceId) throws ApiException, IOException {
        return prepareReportDeviceFirmwareRequest(acc, deviceId).execute();
    }

    /**
     * Ask a device to report its firmware version asynchronously.
     * @param  acc  Required parameter: Account identifier.
     * @param  deviceId  Required parameter: Device identifier.
     * @return    Returns the DeviceFirmwareVersionUpdateResult wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<DeviceFirmwareVersionUpdateResult>> reportDeviceFirmwareAsync(
            final String acc,
            final String deviceId) {
        try {
            return prepareReportDeviceFirmwareRequest(acc, deviceId).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for reportDeviceFirmware.
     */
    private ApiCall<ApiResponse<DeviceFirmwareVersionUpdateResult>, ApiException> prepareReportDeviceFirmwareRequest(
            final String acc,
            final String deviceId) {
        return new ApiCall.Builder<ApiResponse<DeviceFirmwareVersionUpdateResult>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.SOFTWARE_MANAGEMENT_V3.value())
                        .path("/firmware/{acc}/async/{deviceId}")
                        .templateParam(param -> param.key("acc").value(acc)
                                .shouldEncode(true))
                        .templateParam(param -> param.key("deviceId").value(deviceId)
                                .shouldEncode(true))
                        .headerParam(param -> param.key("accept").value("application/json"))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("VZ-M2M-Token")))
                        .httpMethod(HttpMethod.PUT))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .apiResponseDeserializer(
                                response -> ApiHelper.deserialize(response, DeviceFirmwareVersionUpdateResult.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Unexpected error.",
                                (reason, context) -> new FotaV3ResultException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }
}