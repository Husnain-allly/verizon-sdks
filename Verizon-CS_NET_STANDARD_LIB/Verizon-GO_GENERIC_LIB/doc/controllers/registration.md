# Registration

```go
registrationApi := client.RegistrationApi()
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

```go
RegisterEtxDevice(
    ctx context.Context,
    body models.ClientRegistrationRequest) (
    models.ApiResponse[models.ClientRegistrationResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ClientRegistrationRequest`](../../doc/models/client-registration-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ClientRegistrationResponse](../../doc/models/client-registration-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ClientRegistrationRequest{
    ClientType:    models.EtxClientType_Trafficlightcontroller,
    ClientSubtype: models.ClientSubtype_Scooter,
    VendorId:      "VerizonETX",
    DeviceId:      models.ToPointer(uuid.MustParse("a4fcd16a-343d-4527-8203-2f46e3e4ff4b")),
    Imei:          models.ToPointer("12-345678-901234-5"),
    Iccid:         models.ToPointer("89345678901234567890"),
}

apiResponse, err := registrationApi.RegisterEtxDevice(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
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

```go
RenewEtxDevice(
    ctx context.Context,
    deviceId uuid.UUID,
    vendorId string,
    body *interface{}) (
    models.ApiResponse[models.ClientRegistrationResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceId` | `uuid.UUID` | Header, Required | - |
| `vendorId` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | `*interface{}` | Body, Optional | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ClientRegistrationResponse](../../doc/models/client-registration-response.md).

## Example Usage

```go
ctx := context.Background()

deviceId := uuid.MustParse("a4fcd16a-343d-4527-8203-2f46e3e4ff4b")

vendorId := "VerizonETX"



apiResponse, err := registrationApi.RenewEtxDevice(ctx, deviceId, vendorId, nil)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
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

```go
UnregisterEtxDevice(
    ctx context.Context,
    vendorId string,
    deviceIDs []uuid.UUID) (
    http.Response,
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `deviceIDs` | `[]uuid.UUID` | Query, Required | The list of device IDs and software service IDs to be unregistered<br><br>**Constraints**: *Minimum Items*: `1`, *Maximum Items*: `100` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```go
ctx := context.Background()

vendorId := "VerizonETX"

deviceIDs := []uuid.UUID{
    uuid.MustParse("0000225a-0000-0000-0000-000000000000"),
}

resp, err := registrationApi.UnregisterEtxDevice(ctx, vendorId, deviceIDs)
if err != nil {
    log.Fatalln(err)
} else {
    fmt.Println(resp.StatusCode)
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

```go
GetEtxDeviceCertificate(
    ctx context.Context,
    deviceId *uuid.UUID,
    imei *string,
    iccid *string) (
    models.ApiResponse[models.ClientPersistenceResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceId` | `*uuid.UUID` | Query, Optional | - |
| `imei` | `*string` | Query, Optional | **Constraints**: *Maximum Length*: `19`, *Pattern*: `^(\d{2}-\d{6}-\d{6}-\d{1,2})$\|^(\d{15,16})$` |
| `iccid` | `*string` | Query, Optional | **Constraints**: *Minimum Length*: `19`, *Maximum Length*: `20`, *Pattern*: `^(89\d{17,18})$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ClientPersistenceResponse](../../doc/models/client-persistence-response.md).

## Example Usage

```go
ctx := context.Background()

deviceId := uuid.MustParse("a4fcd16a-343d-4527-8203-2f46e3e4ff4b")

imei := "12-345678-901234-5"

iccid := "89345678901234567890"

apiResponse, err := registrationApi.GetEtxDeviceCertificate(ctx, &deviceId, &imei, &iccid)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
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

```go
RetrieveMqtturl(
    ctx context.Context,
    vendorId string,
    body models.ConnectionRequest) (
    models.ApiResponse[models.ConnectionResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | [`models.ConnectionRequest`](../../doc/models/connection-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ConnectionResponse](../../doc/models/connection-response.md).

## Example Usage

```go
ctx := context.Background()

vendorId := "VerizonETX"

body := models.ConnectionRequest{
    DeviceId:    uuid.MustParse("976c4bad-03d3-4dcb-9688-ee57db7890e4"),
    Geolocation: models.Geolocation{
        Latitude:  float64(42.36),
        Longitude: float64(-71.06),
    },
    NetworkType: models.EtxNetworkType_Nonvz,
}

apiResponse, err := registrationApi.RetrieveMqtturl(ctx, vendorId, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
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

