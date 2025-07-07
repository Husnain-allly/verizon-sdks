# Registration

```java
RegistrationApi registrationApi = client.getRegistrationApi();
```

## Class Name

`RegistrationApi`

## Methods

* [Register ETX Device](../../doc/controllers/registration.md#register-etx-device)
* [Renew ETX Device](../../doc/controllers/registration.md#renew-etx-device)
* [Unregister ETX Device](../../doc/controllers/registration.md#unregister-etx-device)
* [Get ETX Device Certificate](../../doc/controllers/registration.md#get-etx-device-certificate)
* [Retrieve MQTTURL](../../doc/controllers/registration.md#retrieve-mqtturl)


# Register ETX Device

With this API call the user (client) registers its device or software service to the ETX system. Therefore, when a connection is initiated from the device or software service to the ETX system along with the credential provided by this registration call, then the connection will be authorized.

- The user can register multiple devices or software services, which can all be used at the same time.
- There rules set in the system that limit the type and subtype of the clients that are allowed to be registered under the VendorID. The rules are created based ont he agreement between the Vendor and Verizon.
- The user will only be able to register a limited number of devices or software services under the same VendorID. This registration limit is specified by the agreement between the Vendor and Verizon.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```java
CompletableFuture<ApiResponse<ClientRegistrationResponse>> registerEtxDeviceAsync(
    final ClientRegistrationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ClientRegistrationRequest`](../../doc/models/client-registration-request.md) | Body, Required | - |

## Server

`Server.IMP_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ClientRegistrationResponse`](../../doc/models/client-registration-response.md).

## Example Usage

```java
ClientRegistrationRequest body = new ClientRegistrationRequest.Builder(
    EtxClientType.TRAFFICLIGHTCONTROLLER,
    ClientSubtype.SCOOTER,
    "VerizonETX"
)
.deviceId(UUID.fromString("a4fcd16a-343d-4527-8203-2f46e3e4ff4b"))
.imei("12-345678-901234-5")
.iccid("89345678901234567890")
.build();

registrationApi.registerEtxDeviceAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid Request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 401 | Unauthorized Request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 403 | Forbidden Request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 429 | Too Many Requests | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 503 | Internal Server Error | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| Default | Forbidden | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |


# Renew ETX Device

With this API call the user (client) can:

- renew the certificate of a device or software service in the ETX system if the original certificate has expired. If the client's certificate expired or going to expire within 30 days and new certificate will be issued. If the certificate expires more than 30 days, the current certificate will be returned to the client.
- complete its device or software service registration to the ETX system if the original registration request was not successful because of a pending certificate generation. Whenever the user receives a "client registration is pending" response (HTTP 202) from POST /clients/registration call. The client should initiate this PUT API call to finish the registration process and get the required certificate.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```java
CompletableFuture<ApiResponse<ClientRegistrationResponse>> renewEtxDeviceAsync(
    final UUID deviceId,
    final String vendorId,
    final Object body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceId` | `UUID` | Header, Required | - |
| `vendorId` | `String` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | `Object` | Body, Optional | - |

## Server

`Server.IMP_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ClientRegistrationResponse`](../../doc/models/client-registration-response.md).

## Example Usage

```java
UUID deviceId = UUID.fromString("a4fcd16a-343d-4527-8203-2f46e3e4ff4b");
String vendorId = "VerizonETX";

registrationApi.renewEtxDeviceAsync(deviceId, vendorId, null).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid Request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 401 | Unauthorized Request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 403 | Forbidden Request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 429 | Too Many Requests | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 503 | Internal Server Error | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| Default | Forbidden | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |


# Unregister ETX Device

With this API call the user (client) can unregister its devices and software services from the ETX system. The unregistered devices and services will no longer be able to use the ETX Message Exchange.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```java
CompletableFuture<ApiResponse<Void>> unregisterEtxDeviceAsync(
    final String vendorId,
    final List<UUID> deviceIDs)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `String` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `deviceIDs` | `List<UUID>` | Query, Required | The list of device IDs and software service IDs to be unregistered<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `100` |

## Server

`Server.IMP_SERVER`

## Response Type

`void`

## Example Usage

```java
String vendorId = "VerizonETX";
List<UUID> deviceIDs = Arrays.asList(
    UUID.fromString("0000225a-0000-0000-0000-000000000000")
);

registrationApi.unregisterEtxDeviceAsync(vendorId, deviceIDs).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid Request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 401 | Unauthorized Request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 403 | Forbidden Request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 429 | Too Many Requests | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 503 | Internal Server Error | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| Default | Forbidden | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |


# Get ETX Device Certificate

With this API call the user can check the certificate of the device. At least one of the DeviceID, IMEI or ICCID is required to make the call.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```java
CompletableFuture<ApiResponse<ClientPersistenceResponse>> getEtxDeviceCertificateAsync(
    final UUID deviceId,
    final String imei,
    final String iccid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceId` | `UUID` | Query, Optional | - |
| `imei` | `String` | Query, Optional | **Constraints**: *Maximum Length*: `19`, *Pattern*: `^(\d{2}-\d{6}-\d{6}-\d{1,2})$\|^(\d{15,16})$` |
| `iccid` | `String` | Query, Optional | **Constraints**: *Minimum Length*: `19`, *Maximum Length*: `20`, *Pattern*: `^(89\d{17,18})$` |

## Server

`Server.IMP_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ClientPersistenceResponse`](../../doc/models/client-persistence-response.md).

## Example Usage

```java
UUID deviceId = UUID.fromString("a4fcd16a-343d-4527-8203-2f46e3e4ff4b");
String imei = "12-345678-901234-5";
String iccid = "89345678901234567890";

registrationApi.getEtxDeviceCertificateAsync(deviceId, imei, iccid).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 401 | Unauthorized | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 403 | Forbidden Request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 404 | Not Found | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 429 | Too Many Requests | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 500 | Internal server Error | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| Default | Forbidden | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |


# Retrieve MQTTURL

With this API call the device or software service requests the MQTT URL for the location that it needs to connect. To determine the proper URL the device or software service needs to provide its ID (the one that was provided in the registration request), location (GPS coordinates), and whether it is on the Verizon cellular network or not.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```java
CompletableFuture<ApiResponse<ConnectionResponse>> retrieveMqtturlAsync(
    final String vendorId,
    final ConnectionRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `String` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | [`ConnectionRequest`](../../doc/models/connection-request.md) | Body, Required | - |

## Server

`Server.IMP_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ConnectionResponse`](../../doc/models/connection-response.md).

## Example Usage

```java
String vendorId = "VerizonETX";
ConnectionRequest body = new ConnectionRequest.Builder(
    UUID.fromString("976c4bad-03d3-4dcb-9688-ee57db7890e4"),
    new Geolocation.Builder(
        42.36D,
        -71.06D
    )
    .build(),
    EtxNetworkType.NONVZ
)
.build();

registrationApi.retrieveMqtturlAsync(vendorId, body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 401 | Unauthorized | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 403 | Forbidden Request | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 429 | Too Many Requests | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| 503 | Internal server Error | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |
| Default | Forbidden | [`EtxResponseErrorException`](../../doc/models/etx-response-error-exception.md) |

