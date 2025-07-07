# Registration

```csharp
RegistrationApi registrationApi = client.RegistrationApi;
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

```csharp
RegisterEtxDeviceAsync(
    Models.ClientRegistrationRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ClientRegistrationRequest`](../../doc/models/client-registration-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ClientRegistrationResponse](../../doc/models/client-registration-response.md).

## Example Usage

```csharp
ClientRegistrationRequest body = new ClientRegistrationRequest
{
    ClientType = EtxClientType.TrafficLightController,
    ClientSubtype = ClientSubtype.Scooter,
    VendorId = "VerizonETX",
    DeviceId = new Guid("a4fcd16a-343d-4527-8203-2f46e3e4ff4b"),
    Imei = "12-345678-901234-5",
    Iccid = "89345678901234567890",
};

try
{
    ApiResponse<ClientRegistrationResponse> result = await registrationApi.RegisterEtxDeviceAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
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

```csharp
RenewEtxDeviceAsync(
    Guid deviceId,
    string vendorId,
    object body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceId` | `Guid` | Header, Required | - |
| `vendorId` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | `object` | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ClientRegistrationResponse](../../doc/models/client-registration-response.md).

## Example Usage

```csharp
Guid deviceId = new Guid("a4fcd16a-343d-4527-8203-2f46e3e4ff4b");
string vendorId = "VerizonETX";
try
{
    ApiResponse<ClientRegistrationResponse> result = await registrationApi.RenewEtxDeviceAsync(
        deviceId,
        vendorId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
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

```csharp
UnregisterEtxDeviceAsync(
    string vendorId,
    List<Guid> deviceIDs)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `deviceIDs` | `List<Guid>` | Query, Required | The list of device IDs and software service IDs to be unregistered<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `100` |

## Response Type

`Task`

## Example Usage

```csharp
string vendorId = "VerizonETX";
List<Guid> deviceIDs = new List<Guid>
{
    new Guid("0000225a-0000-0000-0000-000000000000"),
};

try
{
    await registrationApi.UnregisterEtxDeviceAsync(
        vendorId,
        deviceIDs
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
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

```csharp
GetEtxDeviceCertificateAsync(
    Guid? deviceId = null,
    string imei = null,
    string iccid = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceId` | `Guid?` | Query, Optional | - |
| `imei` | `string` | Query, Optional | **Constraints**: *Maximum Length*: `19`, *Pattern*: `^(\d{2}-\d{6}-\d{6}-\d{1,2})$\|^(\d{15,16})$` |
| `iccid` | `string` | Query, Optional | **Constraints**: *Minimum Length*: `19`, *Maximum Length*: `20`, *Pattern*: `^(89\d{17,18})$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ClientPersistenceResponse](../../doc/models/client-persistence-response.md).

## Example Usage

```csharp
Guid? deviceId = new Guid("a4fcd16a-343d-4527-8203-2f46e3e4ff4b");
string imei = "12-345678-901234-5";
string iccid = "89345678901234567890";
try
{
    ApiResponse<ClientPersistenceResponse> result = await registrationApi.GetEtxDeviceCertificateAsync(
        deviceId,
        imei,
        iccid
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
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

```csharp
RetrieveMqtturlAsync(
    string vendorId,
    Models.ConnectionRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | [`ConnectionRequest`](../../doc/models/connection-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ConnectionResponse](../../doc/models/connection-response.md).

## Example Usage

```csharp
string vendorId = "VerizonETX";
ConnectionRequest body = new ConnectionRequest
{
    DeviceId = new Guid("976c4bad-03d3-4dcb-9688-ee57db7890e4"),
    Geolocation = new Geolocation
    {
        Latitude = 42.36,
        Longitude = -71.06,
    },
    NetworkType = EtxNetworkType.NonVz,
};

try
{
    ApiResponse<ConnectionResponse> result = await registrationApi.RetrieveMqtturlAsync(
        vendorId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
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

