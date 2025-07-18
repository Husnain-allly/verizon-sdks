/*
 * VerizonLib
 *
 * This file was automatically generated by APIMATIC v3.0 ( https://www.apimatic.io ).
 */

package com.verizon.m5gedge.apis;

import com.verizon.m5gedge.ApiHelper;
import com.verizon.m5gedge.Server;
import com.verizon.m5gedge.exceptions.ApiException;
import com.verizon.m5gedge.exceptions.EtxResponseErrorException;
import com.verizon.m5gedge.http.request.HttpMethod;
import com.verizon.m5gedge.http.response.ApiResponse;
import com.verizon.m5gedge.models.ClientPersistenceResponse;
import com.verizon.m5gedge.models.ClientRegistrationRequest;
import com.verizon.m5gedge.models.ClientRegistrationResponse;
import com.verizon.m5gedge.models.ConnectionRequest;
import com.verizon.m5gedge.models.ConnectionResponse;
import io.apimatic.core.ApiCall;
import io.apimatic.core.ErrorCase;
import io.apimatic.core.GlobalConfiguration;
import io.apimatic.coreinterfaces.http.request.ResponseClassType;
import java.io.IOException;
import java.util.List;
import java.util.UUID;
import java.util.concurrent.CompletableFuture;
import java.util.concurrent.CompletionException;

/**
 * This class lists all the endpoints of the groups.
 */
public final class RegistrationApi extends BaseApi {

    /**
     * Initializes the controller.
     * @param globalConfig    Configurations added in client.
     */
    public RegistrationApi(GlobalConfiguration globalConfig) {
        super(globalConfig);
    }

    /**
     * With this API call the user (client) registers its device or software service to the ETX
     * system. Therefore, when a connection is initiated from the device or software service to the
     * ETX system along with the credential provided by this registration call, then the connection
     * will be authorized. - The user can register multiple devices or software services, which can
     * all be used at the same time. - There rules set in the system that limit the type and subtype
     * of the clients that are allowed to be registered under the VendorID. The rules are created
     * based ont he agreement between the Vendor and Verizon. - The user will only be able to
     * register a limited number of devices or software services under the same VendorID. This
     * registration limit is specified by the agreement between the Vendor and Verizon. Note: The
     * user needs to authenticate with their ThingSpace credentials using the Access/Bearer and
     * Session/M2M tokens in order to call this API.
     * @param  body  Required parameter:
     * @return    Returns the ClientRegistrationResponse wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<ClientRegistrationResponse> registerEtxDevice(
            final ClientRegistrationRequest body) throws ApiException, IOException {
        return prepareRegisterEtxDeviceRequest(body).execute();
    }

    /**
     * With this API call the user (client) registers its device or software service to the ETX
     * system. Therefore, when a connection is initiated from the device or software service to the
     * ETX system along with the credential provided by this registration call, then the connection
     * will be authorized. - The user can register multiple devices or software services, which can
     * all be used at the same time. - There rules set in the system that limit the type and subtype
     * of the clients that are allowed to be registered under the VendorID. The rules are created
     * based ont he agreement between the Vendor and Verizon. - The user will only be able to
     * register a limited number of devices or software services under the same VendorID. This
     * registration limit is specified by the agreement between the Vendor and Verizon. Note: The
     * user needs to authenticate with their ThingSpace credentials using the Access/Bearer and
     * Session/M2M tokens in order to call this API.
     * @param  body  Required parameter:
     * @return    Returns the ClientRegistrationResponse wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<ClientRegistrationResponse>> registerEtxDeviceAsync(
            final ClientRegistrationRequest body) {
        try {
            return prepareRegisterEtxDeviceRequest(body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for registerEtxDevice.
     */
    private ApiCall<ApiResponse<ClientRegistrationResponse>, ApiException> prepareRegisterEtxDeviceRequest(
            final ClientRegistrationRequest body) {
        return new ApiCall.Builder<ApiResponse<ClientRegistrationResponse>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.IMP_SERVER.value())
                        .path("/api/v2/clients/registration")
                        .bodyParam(param -> param.value(body))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
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
                                response -> ApiHelper.deserialize(response, ClientRegistrationResponse.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Invalid Request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("401",
                                 ErrorCase.setReason("Unauthorized Request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden Request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too Many Requests",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("503",
                                 ErrorCase.setReason("Internal Server Error",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * With this API call the user (client) can: - renew the certificate of a device or software
     * service in the ETX system if the original certificate has expired. If the client's
     * certificate expired or going to expire within 30 days and new certificate will be issued. If
     * the certificate expires more than 30 days, the current certificate will be returned to the
     * client. - complete its device or software service registration to the ETX system if the
     * original registration request was not successful because of a pending certificate generation.
     * Whenever the user receives a "client registration is pending" response (HTTP 202) from POST
     * /clients/registration call. The client should initiate this PUT API call to finish the
     * registration process and get the required certificate. Note: The user needs to authenticate
     * with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to
     * call this API.
     * @param  deviceId  Required parameter:
     * @param  vendorId  Required parameter: The VendorID set during the Vendor registration call.
     * @param  body  Optional parameter:
     * @return    Returns the ClientRegistrationResponse wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<ClientRegistrationResponse> renewEtxDevice(
            final UUID deviceId,
            final String vendorId,
            final Object body) throws ApiException, IOException {
        return prepareRenewEtxDeviceRequest(deviceId, vendorId, body).execute();
    }

    /**
     * With this API call the user (client) can: - renew the certificate of a device or software
     * service in the ETX system if the original certificate has expired. If the client's
     * certificate expired or going to expire within 30 days and new certificate will be issued. If
     * the certificate expires more than 30 days, the current certificate will be returned to the
     * client. - complete its device or software service registration to the ETX system if the
     * original registration request was not successful because of a pending certificate generation.
     * Whenever the user receives a "client registration is pending" response (HTTP 202) from POST
     * /clients/registration call. The client should initiate this PUT API call to finish the
     * registration process and get the required certificate. Note: The user needs to authenticate
     * with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to
     * call this API.
     * @param  deviceId  Required parameter:
     * @param  vendorId  Required parameter: The VendorID set during the Vendor registration call.
     * @param  body  Optional parameter:
     * @return    Returns the ClientRegistrationResponse wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<ClientRegistrationResponse>> renewEtxDeviceAsync(
            final UUID deviceId,
            final String vendorId,
            final Object body) {
        try {
            return prepareRenewEtxDeviceRequest(deviceId, vendorId, body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for renewEtxDevice.
     */
    private ApiCall<ApiResponse<ClientRegistrationResponse>, ApiException> prepareRenewEtxDeviceRequest(
            final UUID deviceId,
            final String vendorId,
            final Object body) {
        return new ApiCall.Builder<ApiResponse<ClientRegistrationResponse>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.IMP_SERVER.value())
                        .path("/api/v2/clients/registration")
                        .bodyParam(param -> param.value(body).isRequired(false))
                        .bodySerializer(() ->  ApiHelper.serialize(body))
                        .headerParam(param -> param.key("DeviceID")
                                .value(deviceId).isRequired(false))
                        .headerParam(param -> param.key("VendorID")
                                .value(vendorId).isRequired(false))
                        .headerParam(param -> param.key("Content-Type")
                                .value("application/json").isRequired(false))
                        .headerParam(param -> param.key("accept").value("application/json"))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("SessionToken")))
                        .httpMethod(HttpMethod.PUT))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .apiResponseDeserializer(
                                response -> ApiHelper.deserialize(response, ClientRegistrationResponse.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Invalid Request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("401",
                                 ErrorCase.setReason("Unauthorized Request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden Request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too Many Requests",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("503",
                                 ErrorCase.setReason("Internal Server Error",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * With this API call the user (client) can unregister its devices and software services from
     * the ETX system. The unregistered devices and services will no longer be able to use the ETX
     * Message Exchange. Note: The user needs to authenticate with their ThingSpace credentials
     * using the Access/Bearer and Session/M2M tokens in order to call this API.
     * @param  vendorId  Required parameter: The VendorID set during the Vendor registration call.
     * @param  deviceIDs  Required parameter: The list of device IDs and software service IDs to be
     *         unregistered
     * @return    Returns the Void wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<Void> unregisterEtxDevice(
            final String vendorId,
            final List<UUID> deviceIDs) throws ApiException, IOException {
        return prepareUnregisterEtxDeviceRequest(vendorId, deviceIDs).execute();
    }

    /**
     * With this API call the user (client) can unregister its devices and software services from
     * the ETX system. The unregistered devices and services will no longer be able to use the ETX
     * Message Exchange. Note: The user needs to authenticate with their ThingSpace credentials
     * using the Access/Bearer and Session/M2M tokens in order to call this API.
     * @param  vendorId  Required parameter: The VendorID set during the Vendor registration call.
     * @param  deviceIDs  Required parameter: The list of device IDs and software service IDs to be
     *         unregistered
     * @return    Returns the Void wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<Void>> unregisterEtxDeviceAsync(
            final String vendorId,
            final List<UUID> deviceIDs) {
        try {
            return prepareUnregisterEtxDeviceRequest(vendorId, deviceIDs).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for unregisterEtxDevice.
     */
    private ApiCall<ApiResponse<Void>, ApiException> prepareUnregisterEtxDeviceRequest(
            final String vendorId,
            final List<UUID> deviceIDs) {
        return new ApiCall.Builder<ApiResponse<Void>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.IMP_SERVER.value())
                        .path("/api/v2/clients/registration")
                        .queryParam(param -> param.key("DeviceIDs")
                                .value(deviceIDs))
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
                        .localErrorCase("400",
                                 ErrorCase.setReason("Invalid Request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("401",
                                 ErrorCase.setReason("Unauthorized Request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden Request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too Many Requests",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("503",
                                 ErrorCase.setReason("Internal Server Error",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * With this API call the user can check the certificate of the device. At least one of the
     * DeviceID, IMEI or ICCID is required to make the call. Note: The user needs to authenticate
     * with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to
     * call this API.
     * @param  deviceId  Optional parameter:
     * @param  imei  Optional parameter:
     * @param  iccid  Optional parameter:
     * @return    Returns the ClientPersistenceResponse wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<ClientPersistenceResponse> getEtxDeviceCertificate(
            final UUID deviceId,
            final String imei,
            final String iccid) throws ApiException, IOException {
        return prepareGetEtxDeviceCertificateRequest(deviceId, imei, iccid).execute();
    }

    /**
     * With this API call the user can check the certificate of the device. At least one of the
     * DeviceID, IMEI or ICCID is required to make the call. Note: The user needs to authenticate
     * with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to
     * call this API.
     * @param  deviceId  Optional parameter:
     * @param  imei  Optional parameter:
     * @param  iccid  Optional parameter:
     * @return    Returns the ClientPersistenceResponse wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<ClientPersistenceResponse>> getEtxDeviceCertificateAsync(
            final UUID deviceId,
            final String imei,
            final String iccid) {
        try {
            return prepareGetEtxDeviceCertificateRequest(deviceId, imei, iccid).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for getEtxDeviceCertificate.
     */
    private ApiCall<ApiResponse<ClientPersistenceResponse>, ApiException> prepareGetEtxDeviceCertificateRequest(
            final UUID deviceId,
            final String imei,
            final String iccid) {
        return new ApiCall.Builder<ApiResponse<ClientPersistenceResponse>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.IMP_SERVER.value())
                        .path("/api/v2/clients/registration")
                        .queryParam(param -> param.key("DeviceID")
                                .value(deviceId).isRequired(false))
                        .queryParam(param -> param.key("IMEI")
                                .value(imei).isRequired(false))
                        .queryParam(param -> param.key("ICCID")
                                .value(iccid).isRequired(false))
                        .headerParam(param -> param.key("accept").value("application/json"))
                        .withAuth(auth -> auth
                                .and(andAuth -> andAuth
                                        .add("thingspace_oauth")
                                        .add("SessionToken")))
                        .httpMethod(HttpMethod.GET))
                .responseHandler(responseHandler -> responseHandler
                        .responseClassType(ResponseClassType.API_RESPONSE)
                        .apiResponseDeserializer(
                                response -> ApiHelper.deserialize(response, ClientPersistenceResponse.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Invalid request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("401",
                                 ErrorCase.setReason("Unauthorized",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden Request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("404",
                                 ErrorCase.setReason("Not Found",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too Many Requests",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("500",
                                 ErrorCase.setReason("Internal server Error",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }

    /**
     * With this API call the device or software service requests the MQTT URL for the location that
     * it needs to connect. To determine the proper URL the device or software service needs to
     * provide its ID (the one that was provided in the registration request), location (GPS
     * coordinates), and whether it is on the Verizon cellular network or not. Note: The user needs
     * to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M
     * tokens in order to call this API.
     * @param  vendorId  Required parameter: The VendorID set during the Vendor registration call.
     * @param  body  Required parameter:
     * @return    Returns the ConnectionResponse wrapped in ApiResponse response from the API call
     * @throws    ApiException    Represents error response from the server.
     * @throws    IOException    Signals that an I/O exception of some sort has occurred.
     */
    public ApiResponse<ConnectionResponse> retrieveMqtturl(
            final String vendorId,
            final ConnectionRequest body) throws ApiException, IOException {
        return prepareRetrieveMqtturlRequest(vendorId, body).execute();
    }

    /**
     * With this API call the device or software service requests the MQTT URL for the location that
     * it needs to connect. To determine the proper URL the device or software service needs to
     * provide its ID (the one that was provided in the registration request), location (GPS
     * coordinates), and whether it is on the Verizon cellular network or not. Note: The user needs
     * to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M
     * tokens in order to call this API.
     * @param  vendorId  Required parameter: The VendorID set during the Vendor registration call.
     * @param  body  Required parameter:
     * @return    Returns the ConnectionResponse wrapped in ApiResponse response from the API call
     */
    public CompletableFuture<ApiResponse<ConnectionResponse>> retrieveMqtturlAsync(
            final String vendorId,
            final ConnectionRequest body) {
        try {
            return prepareRetrieveMqtturlRequest(vendorId, body).executeAsync();
        } catch (Exception e) {
            throw new CompletionException(e);
        }
    }

    /**
     * Builds the ApiCall object for retrieveMqtturl.
     */
    private ApiCall<ApiResponse<ConnectionResponse>, ApiException> prepareRetrieveMqtturlRequest(
            final String vendorId,
            final ConnectionRequest body) {
        return new ApiCall.Builder<ApiResponse<ConnectionResponse>, ApiException>()
                .globalConfig(getGlobalConfiguration())
                .requestBuilder(requestBuilder -> requestBuilder
                        .server(Server.IMP_SERVER.value())
                        .path("/api/v2/clients/connection")
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
                                response -> ApiHelper.deserialize(response, ConnectionResponse.class))
                        .nullify404(false)
                        .localErrorCase("400",
                                 ErrorCase.setReason("Invalid request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("401",
                                 ErrorCase.setReason("Unauthorized",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("403",
                                 ErrorCase.setReason("Forbidden Request",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("429",
                                 ErrorCase.setReason("Too Many Requests",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase("503",
                                 ErrorCase.setReason("Internal server Error",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .localErrorCase(ErrorCase.DEFAULT,
                                 ErrorCase.setReason("Forbidden",
                                (reason, context) -> new EtxResponseErrorException(reason, context)))
                        .globalErrorCase(GLOBAL_ERROR_CASES))
                .build();
    }
}