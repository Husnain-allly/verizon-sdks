# Client Logging

```go
clientLoggingApi := client.ClientLoggingApi()
```

## Class Name

`ClientLoggingApi`

## Methods

* [List Devices With Logging Enabled](../../doc/controllers/client-logging.md#list-devices-with-logging-enabled)
* [Enable Logging for Devices](../../doc/controllers/client-logging.md#enable-logging-for-devices)
* [Disable Logging for Devices](../../doc/controllers/client-logging.md#disable-logging-for-devices)
* [Enable Device Logging](../../doc/controllers/client-logging.md#enable-device-logging)
* [Disable Device Logging](../../doc/controllers/client-logging.md#disable-device-logging)
* [List Device Logs](../../doc/controllers/client-logging.md#list-device-logs)


# List Devices With Logging Enabled

Returns an array of all devices in the specified account for which logging is enabled.

```go
ListDevicesWithLoggingEnabled(
    ctx context.Context,
    account string) (
    models.ApiResponse[[]models.DeviceLoggingStatus],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DeviceLoggingStatus](../../doc/models/device-logging-status.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

apiResponse, err := clientLoggingApi.ListDevicesWithLoggingEnabled(ctx, account)
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
[
  {
    "deviceId": "990013907835573",
    "expiryDate": "2020-10-19"
  },
  {
    "deviceId": "991124018926684",
    "expiryDate": "2020-10-19"
  },
  {
    "deviceId": "992234129057795",
    "expiryDate": "2020-10-23"
  },
  {
    "deviceId": "998891785613351",
    "expiryDate": "2020-10-23"
  },
  {
    "deviceId": "990013907835573",
    "expiryDate": "2020-10-23"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Enable Logging for Devices

Each customer may have a maximum of 20 devices enabled for logging.

```go
EnableLoggingForDevices(
    ctx context.Context,
    account string,
    body models.DeviceLoggingRequest) (
    models.ApiResponse[[]models.DeviceLoggingStatus],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`models.DeviceLoggingRequest`](../../doc/models/device-logging-request.md) | Body, Required | Device logging information. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DeviceLoggingStatus](../../doc/models/device-logging-status.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

body := models.DeviceLoggingRequest{
    DeviceIds:             []string{
        "990013907835573",
        "991124018926684",
        "992234129057795",
        "998891785613351",
        "990013907835573",
    },
}

apiResponse, err := clientLoggingApi.EnableLoggingForDevices(ctx, account, body)
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
[
  {
    "deviceId": "990013907835573",
    "expiryDate": "2020-10-19"
  },
  {
    "deviceId": "991124018926684",
    "expiryDate": "2020-10-19"
  },
  {
    "deviceId": "992234129057795",
    "expiryDate": "2020-10-23"
  },
  {
    "deviceId": "998891785613351",
    "expiryDate": "2020-10-23"
  },
  {
    "deviceId": "990013907835573",
    "expiryDate": "2020-10-23"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Disable Logging for Devices

Turn logging off for a list of devices.

```go
DisableLoggingForDevices(
    ctx context.Context,
    account string,
    deviceIds string) (
    http.Response,
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceIds` | `string` | Query, Required | The list of device IDs. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

deviceIds := "990013907835573"

resp, err := clientLoggingApi.DisableLoggingForDevices(ctx, account, deviceIds)
if err != nil {
    log.Fatalln(err)
} else {
    fmt.Println(resp.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Enable Device Logging

Enables logging for a specific device.

```go
EnableDeviceLogging(
    ctx context.Context,
    account string,
    deviceId string) (
    models.ApiResponse[models.DeviceLoggingStatus],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device IMEI identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceLoggingStatus](../../doc/models/device-logging-status.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

deviceId := "990013907835573"

apiResponse, err := clientLoggingApi.EnableDeviceLogging(ctx, account, deviceId)
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
  "deviceId": "990013907835573",
  "expiryDate": "2020-10-19"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Disable Device Logging

Disables logging for a specific device.

```go
DisableDeviceLogging(
    ctx context.Context,
    account string,
    deviceId string) (
    http.Response,
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device IMEI identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

deviceId := "990013907835573"

resp, err := clientLoggingApi.DisableDeviceLogging(ctx, account, deviceId)
if err != nil {
    log.Fatalln(err)
} else {
    fmt.Println(resp.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# List Device Logs

Gets logs for a specific device.

```go
ListDeviceLogs(
    ctx context.Context,
    account string,
    deviceId string) (
    models.ApiResponse[[]models.DeviceLog],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device IMEI identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DeviceLog](../../doc/models/device-log.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

deviceId := "990013907835573"

apiResponse, err := clientLoggingApi.ListDeviceLogs(ctx, account, deviceId)
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
[
  {
    "deviceId": "990013907835573",
    "logTime": "2020-10-22T19:29:50.901Z",
    "logType": "string",
    "eventLog": "string",
    "binaryLogFileBase64": "string",
    "binaryLogFilename": "string"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

