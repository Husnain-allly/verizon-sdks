# Managinge SIM Profiles

```go
managingeSimProfilesApi := client.ManagingeSimProfilesApi()
```

## Class Name

`ManagingeSimProfilesApi`

## Methods

* [Resume Profile](../../doc/controllers/managinge-sim-profiles.md#resume-profile)
* [Profile Suspend](../../doc/controllers/managinge-sim-profiles.md#profile-suspend)
* [Device Suspend](../../doc/controllers/managinge-sim-profiles.md#device-suspend)
* [Set Fallback](../../doc/controllers/managinge-sim-profiles.md#set-fallback)
* [Activate a Device Profile](../../doc/controllers/managinge-sim-profiles.md#activate-a-device-profile)
* [Enable a Device Profile](../../doc/controllers/managinge-sim-profiles.md#enable-a-device-profile)
* [Deactivate a Device Profile](../../doc/controllers/managinge-sim-profiles.md#deactivate-a-device-profile)
* [Enable a Device Profile for Download](../../doc/controllers/managinge-sim-profiles.md#enable-a-device-profile-for-download)
* [Download a Device Profile](../../doc/controllers/managinge-sim-profiles.md#download-a-device-profile)
* [Delete a Device Profile](../../doc/controllers/managinge-sim-profiles.md#delete-a-device-profile)


# Resume Profile

Resume service to a device with either a lead or local profile.

```go
ResumeProfile(
    ctx context.Context,
    body models.GioProfileRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.GioProfileRequest{
    Devices:     []models.GioDeviceList{
        models.GioDeviceList{
        },
    },
    AccountName: "0000123456-00001",
    MdnZipCode:  models.ToPointer("12345"),
    ServicePlan: models.ToPointer("service plan name"),
}

apiResponse, err := managingEsimProfilesApi.ResumeProfile(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Profile Suspend

Suspend a device's Global profile.

```go
ProfileSuspend(
    ctx context.Context,
    body models.GioProfileRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.GioProfileRequest{
    Devices:     []models.GioDeviceList{
        models.GioDeviceList{
        },
    },
    AccountName: "0000123456-00001",
    MdnZipCode:  models.ToPointer("12345"),
    ServicePlan: models.ToPointer("service plan name"),
}

apiResponse, err := managingEsimProfilesApi.ProfileSuspend(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Device Suspend

Suspend all service to an eUICC device, including the lead and local profile.

```go
DeviceSuspend(
    ctx context.Context,
    body models.GioProfileRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.GioProfileRequest{
    Devices:     []models.GioDeviceList{
        models.GioDeviceList{
        },
    },
    AccountName: "0000123456-00001",
    MdnZipCode:  models.ToPointer("12345"),
    ServicePlan: models.ToPointer("service plan name"),
}

apiResponse, err := managingEsimProfilesApi.DeviceSuspend(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Set Fallback

Enable a fallback profile to be set.

```go
SetFallback(
    ctx context.Context,
    body models.FallBack) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.FallBack`](../../doc/models/fall-back.md) | Body, Required | Set the fallback attributes to allow a fallback profile to be activated. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.FallBack{
}

apiResponse, err := managingEsimProfilesApi.SetFallback(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Activate a Device Profile

Activate a device with either a lead or local profile.

```go
ActivateADeviceProfile(
    ctx context.Context,
    body models.GioProfileRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.GioProfileRequest{
    Devices:     []models.GioDeviceList{
        models.GioDeviceList{
        },
    },
    AccountName: "0000123456-00001",
    MdnZipCode:  models.ToPointer("12345"),
    ServicePlan: models.ToPointer("service plan name"),
}

apiResponse, err := managingEsimProfilesApi.ActivateADeviceProfile(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Enable a Device Profile

Enable a device lead or local profile.

```go
EnableADeviceProfile(
    ctx context.Context,
    body models.DeviceProfileRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DeviceProfileRequest{
    AccountName: models.ToPointer("0000123456-00001"),
    ServicePlan: models.ToPointer("service plan name"),
}

apiResponse, err := managingEsimProfilesApi.EnableADeviceProfile(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Deactivate a Device Profile

Deactivate the lead or local profile. **Note:** to reactivate the profile, use the **Activate** endpoint above.

```go
DeactivateADeviceProfile(
    ctx context.Context,
    body models.GioDeactivateDeviceProfileRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.GioDeactivateDeviceProfileRequest`](../../doc/models/gio-deactivate-device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.GioDeactivateDeviceProfileRequest{
    AccountName: models.ToPointer("0000123456-00001"),
    ServicePlan: models.ToPointer("service plan name"),
    EtfWaiver:   models.ToPointer(false),
    ReasonCode:  models.ToPointer("FF"),
}

apiResponse, err := managingEsimProfilesApi.DeactivateADeviceProfile(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Enable a Device Profile for Download

Enable the Global IoT Orchestration device profile for download.

```go
EnableADeviceProfileForDownload(
    ctx context.Context,
    body models.DeviceProfileRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DeviceProfileRequest{
    AccountName: models.ToPointer("0000123456-00001"),
    ServicePlan: models.ToPointer("service plan name"),
}

apiResponse, err := managingEsimProfilesApi.EnableADeviceProfileForDownload(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Download a Device Profile

Download a Global IoT Orchestration device profile.

```go
DownloadADeviceProfile(
    ctx context.Context,
    body models.DeviceProfileRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DeviceProfileRequest{
    AccountName: models.ToPointer("0000123456-00001"),
    ServicePlan: models.ToPointer("service plan name"),
}

apiResponse, err := managingEsimProfilesApi.DownloadADeviceProfile(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Delete a Device Profile

Delete a device profile for Global IoT Orchestration. **Note:** the profile must be deactivated first!

```go
DeleteADeviceProfile(
    ctx context.Context,
    body models.DeviceProfileRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DeviceProfileRequest{
    AccountName: models.ToPointer("0000123456-00001"),
    ServicePlan: models.ToPointer("service plan name"),
}

apiResponse, err := managingEsimProfilesApi.DeleteADeviceProfile(ctx, body)
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |

