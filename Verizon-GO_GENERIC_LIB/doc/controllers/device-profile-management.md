# Device Profile Management

```go
deviceProfileManagementApi := client.DeviceProfileManagementApi()
```

## Class Name

`DeviceProfileManagementApi`

## Methods

* [Activate Device Through Profile](../../doc/controllers/device-profile-management.md#activate-device-through-profile)
* [Profile to Activate Device](../../doc/controllers/device-profile-management.md#profile-to-activate-device)
* [Profile to Deactivate Device](../../doc/controllers/device-profile-management.md#profile-to-deactivate-device)
* [Profile to Set Fallback Attribute](../../doc/controllers/device-profile-management.md#profile-to-set-fallback-attribute)


# Activate Device Through Profile

Uses the profile to bring the device under management.

```go
ActivateDeviceThroughProfile(
    ctx context.Context,
    body models.ActivateDeviceProfileRequest) (
    models.ApiResponse[models.RequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ActivateDeviceProfileRequest`](../../doc/models/activate-device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ActivateDeviceProfileRequest{
    Devices:     []models.DeviceList{
        models.DeviceList{
            DeviceIds: []models.DeviceId{
                models.DeviceId{
                    Id:                    "32-digit EID",
                    Kind:                  "eid",
                },
                models.DeviceId{
                    Id:                    "15-digit IMEI",
                    Kind:                  "imei",
                },
            },
        },
    },
    AccountName: "0000123456-00001",
    ServicePlan: models.ToPointer("The service plan name"),
    MdnZipCode:  models.ToPointer("five digit zip code"),
}

apiResponse, err := deviceProfileManagementApi.ActivateDeviceThroughProfile(ctx, body)
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
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Profile to Activate Device

Uses the profile to activate the device.

```go
ProfileToActivateDevice(
    ctx context.Context,
    body models.ProfileRequest) (
    models.ApiResponse[models.RequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ProfileRequest`](../../doc/models/profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ProfileRequest{
    AccountName:       "0000123456-00001",
    Devices:           []models.DeviceList{
        models.DeviceList{
        },
    },
    CarrierName:       models.ToPointer("the name of the mobile service provider"),
    ServicePlan:       models.ToPointer("The service plan name"),
    MdnZipCode:        models.ToPointer("five digit zip code"),
}

apiResponse, err := deviceProfileManagementApi.ProfileToActivateDevice(ctx, body)
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
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Profile to Deactivate Device

Uses the profile to deactivate the device.

```go
ProfileToDeactivateDevice(
    ctx context.Context,
    body models.DeactivateDeviceProfileRequest) (
    models.ApiResponse[models.RequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DeactivateDeviceProfileRequest`](../../doc/models/deactivate-device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DeactivateDeviceProfileRequest{
    AccountName:          "0000123456-00001",
    ReasonCode:           "a short code for the reason action was taken",
    CarrierName:          models.ToPointer("the name of the mobile service provider"),
    EtfWaiver:            models.ToPointer(true),
    CheckFallbackProfile: models.ToPointer(false),
}

apiResponse, err := deviceProfileManagementApi.ProfileToDeactivateDevice(ctx, body)
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
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Profile to Set Fallback Attribute

Allows the profile to set the fallback attribute to the device.

```go
ProfileToSetFallbackAttribute(
    ctx context.Context,
    body models.SetFallbackAttributeRequest) (
    models.ApiResponse[models.RequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.SetFallbackAttributeRequest`](../../doc/models/set-fallback-attribute-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.SetFallbackAttributeRequest{
    Devices:     []models.DeviceList{
        models.DeviceList{
        },
    },
    AccountName: "0000123456-00001",
    CarrierName: models.ToPointer("the name of the mobile service provider"),
}

apiResponse, err := deviceProfileManagementApi.ProfileToSetFallbackAttribute(ctx, body)
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
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

