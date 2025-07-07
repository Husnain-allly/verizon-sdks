# Firmware V3

```go
firmwareV3Api := client.FirmwareV3Api()
```

## Class Name

`FirmwareV3Api`

## Methods

* [List Available Firmware](../../doc/controllers/firmware-v3.md#list-available-firmware)
* [Synchronize Device Firmware](../../doc/controllers/firmware-v3.md#synchronize-device-firmware)
* [Report Device Firmware](../../doc/controllers/firmware-v3.md#report-device-firmware)


# List Available Firmware

This endpoint allows user to list the firmware of an account.

```go
ListAvailableFirmware(
    ctx context.Context,
    acc string,
    protocol models.FirmwareProtocol) (
    models.ApiResponse[[]models.FirmwarePackage],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `protocol` | [`models.FirmwareProtocol`](../../doc/models/firmware-protocol.md) | Query, Required | Filter to retrieve a specific protocol type used. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.FirmwarePackage](../../doc/models/firmware-package.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

protocol := models.FirmwareProtocol_LwM2M

apiResponse, err := firmwareV3Api.ListAvailableFirmware(ctx, acc, protocol)
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
    "firmwareName": "VerizonSmartCommunities_LCO-277C4N_BG96MAR04A04M1G_BG96MAR04A04M1G_BETA0130B",
    "firmwareFrom": "BG96MAR04A04M1G",
    "firmwareTo": "BG96MAR04A04M1G_BETA0130B",
    "launchDate": "2012-04-23T18:25:43.511Z",
    "releaseNote": "",
    "model": "LCO-277C4N",
    "make": "Verizon Smart Communities",
    "protocol": "LWM2M"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Synchronize Device Firmware

Synchronize ThingSpace with the FOTA server for up to 100 devices.

```go
SynchronizeDeviceFirmware(
    ctx context.Context,
    acc string,
    body models.FirmwareImei) (
    models.ApiResponse[models.DeviceFirmwareList],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`models.FirmwareImei`](../../doc/models/firmware-imei.md) | Body, Required | DeviceIds to get firmware info synchronously. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceFirmwareList](../../doc/models/device-firmware-list.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

body := models.FirmwareImei{
    DeviceList:            []string{
        "15-digit IMEI",
    },
}

apiResponse, err := firmwareV3Api.SynchronizeDeviceFirmware(ctx, acc, body)
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
  "accountName": "0000123456-00001",
  "deviceFirmwarVersionList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "FirmwareVersionUpdateSuccess",
      "firmwareVersion": "SR1.2.0.0-10657"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Report Device Firmware

Ask a device to report its firmware version asynchronously.

```go
ReportDeviceFirmware(
    ctx context.Context,
    acc string,
    deviceId string) (
    models.ApiResponse[models.DeviceFirmwareVersionUpdateResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `deviceId` | `string` | Template, Required | Device identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceFirmwareVersionUpdateResult](../../doc/models/device-firmware-version-update-result.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

deviceId := "15-digit IMEI"

apiResponse, err := firmwareV3Api.ReportDeviceFirmware(ctx, acc, deviceId)
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

