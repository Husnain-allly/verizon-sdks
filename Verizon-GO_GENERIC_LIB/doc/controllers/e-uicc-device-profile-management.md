# E UICC Device Profile Management

```go
euiccDeviceProfileManagementApi := client.EuiccDeviceProfileManagementApi()
```

## Class Name

`EuiccDeviceProfileManagementApi`

## Methods

* [Download Local Profile to Enable](../../doc/controllers/e-uicc-device-profile-management.md#download-local-profile-to-enable)
* [Download Local Profile to Disable](../../doc/controllers/e-uicc-device-profile-management.md#download-local-profile-to-disable)
* [Enable Local Profile](../../doc/controllers/e-uicc-device-profile-management.md#enable-local-profile)
* [Disable Local Profile](../../doc/controllers/e-uicc-device-profile-management.md#disable-local-profile)
* [Delete Local Profile](../../doc/controllers/e-uicc-device-profile-management.md#delete-local-profile)


# Download Local Profile to Enable

Downloads an eUICC local profile to devices and enables the profile.

```go
DownloadLocalProfileToEnable(
    ctx context.Context,
    body models.ProfileChangeStateRequest) (
    models.ApiResponse[models.DeviceManagementResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.ProfileChangeStateRequest{
    Devices:               []models.DeviceList{
        models.DeviceList{
            DeviceIds: []models.DeviceId{
                models.DeviceId{
                    Id:                    "678912789123453456784008666456",
                    Kind:                  "eid",
                },
                models.DeviceId{
                    Id:                    "78425989148000000840",
                    Kind:                  "iccid",
                },
            },
        },
    },
    AccountName:           "1223334444-00001",
    SmsrOid:               "1.3.6.1.4.1.31746.1.500.200.101.5",
}

apiResponse, err := euiccDeviceProfileManagementApi.DownloadLocalProfileToEnable(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Download Local Profile to Disable

Downloads an eUICC local profile to devices and leaves the profile disabled.

```go
DownloadLocalProfileToDisable(
    ctx context.Context,
    body models.ProfileChangeStateRequest) (
    models.ApiResponse[models.DeviceManagementResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.ProfileChangeStateRequest{
    Devices:               []models.DeviceList{
        models.DeviceList{
            DeviceIds: []models.DeviceId{
                models.DeviceId{
                    Id:                    "678912789123453456784008666456",
                    Kind:                  "eid",
                },
                models.DeviceId{
                    Id:                    "78425989148000000840",
                    Kind:                  "iccid",
                },
            },
        },
    },
    AccountName:           "1223334444-00001",
    SmsrOid:               "1.3.6.1.4.1.31746.1.500.200.101.5",
}

apiResponse, err := euiccDeviceProfileManagementApi.DownloadLocalProfileToDisable(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Enable Local Profile

Enable a local profile that has been downloaded to eUICC devices.

```go
EnableLocalProfile(
    ctx context.Context,
    body models.ProfileChangeStateRequest) (
    models.ApiResponse[models.RequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Update state |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ProfileChangeStateRequest{
    Devices:               []models.DeviceList{
        models.DeviceList{
            DeviceIds: []models.DeviceId{
                models.DeviceId{
                    Id:                    "678912789123453456784008666456",
                    Kind:                  "eid",
                },
                models.DeviceId{
                    Id:                    "78425989148000000840",
                    Kind:                  "iccid",
                },
            },
        },
    },
    AccountName:           "1223334444-00001",
    SmsrOid:               "1.3.6.1.4.1.31746.1.500.200.101.5",
}

apiResponse, err := euiccDeviceProfileManagementApi.EnableLocalProfile(ctx, body)
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Disable Local Profile

Disable a local profile on eUICC devices. The default or boot profile will become the enabled profile.

```go
DisableLocalProfile(
    ctx context.Context,
    body models.ProfileChangeStateRequest) (
    models.ApiResponse[models.RequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Update state |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ProfileChangeStateRequest{
    Devices:               []models.DeviceList{
        models.DeviceList{
            DeviceIds: []models.DeviceId{
                models.DeviceId{
                    Id:                    "678912789123453456784008666456",
                    Kind:                  "eid",
                },
                models.DeviceId{
                    Id:                    "78425989148000000840",
                    Kind:                  "iccid",
                },
            },
        },
    },
    AccountName:           "1223334444-00001",
    SmsrOid:               "1.3.6.1.4.1.31746.1.500.200.101.5",
}

apiResponse, err := euiccDeviceProfileManagementApi.DisableLocalProfile(ctx, body)
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Delete Local Profile

Delete a local profile from eUICC devices. If the local profile is enabled, it will first be disabled and the boot or default profile will be enabled.

```go
DeleteLocalProfile(
    ctx context.Context,
    body models.ProfileChangeStateRequest) (
    models.ApiResponse[models.RequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Update state |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.RequestResponse](../../doc/models/request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ProfileChangeStateRequest{
    Devices:               []models.DeviceList{
        models.DeviceList{
            DeviceIds: []models.DeviceId{
                models.DeviceId{
                    Id:                    "678912789123453456784008666456",
                    Kind:                  "eid",
                },
                models.DeviceId{
                    Id:                    "78425989148000000840",
                    Kind:                  "iccid",
                },
            },
        },
    },
    AccountName:           "1223334444-00001",
    SmsrOid:               "1.3.6.1.4.1.31746.1.500.200.101.5",
}

apiResponse, err := euiccDeviceProfileManagementApi.DeleteLocalProfile(ctx, body)
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
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

