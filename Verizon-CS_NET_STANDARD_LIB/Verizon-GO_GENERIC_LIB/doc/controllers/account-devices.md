# Account Devices

```go
accountDevicesApi := client.AccountDevicesApi()
```

## Class Name

`AccountDevicesApi`

## Methods

* [Get Account Device Information](../../doc/controllers/account-devices.md#get-account-device-information)
* [List Account Devices Information](../../doc/controllers/account-devices.md#list-account-devices-information)


# Get Account Device Information

Retrieve account device information such as reported firmware on the devices.

```go
GetAccountDeviceInformation(
    ctx context.Context,
    acc string,
    lastSeenDeviceId *string,
    protocol *models.DevicesProtocol) (
    models.ApiResponse[models.V3AccountDeviceList],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `lastSeenDeviceId` | `*string` | Query, Optional | Last seen device identifier. |
| `protocol` | [`*models.DevicesProtocol`](../../doc/models/devices-protocol.md) | Query, Optional | Filter to retrieve a specific protocol type used.<br><br>**Default**: `"LWM2M"` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V3AccountDeviceList](../../doc/models/v3-account-device-list.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

lastSeenDeviceId := "0"

protocol := models.DevicesProtocol_LwM2M

apiResponse, err := accountDevicesApi.GetAccountDeviceInformation(ctx, acc, &lastSeenDeviceId, &protocol)
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


# List Account Devices Information

Retrieve device information for a list of devices on an account.

```go
ListAccountDevicesInformation(
    ctx context.Context,
    acc string,
    body models.DeviceImei) (
    models.ApiResponse[models.DeviceListResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`models.DeviceImei`](../../doc/models/device-imei.md) | Body, Required | Request device list information. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceListResult](../../doc/models/device-list-result.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

body := models.DeviceImei{
    DeviceList:            []string{
        "15-digit IMEI",
    },
}

apiResponse, err := accountDevicesApi.ListAccountDevicesInformation(ctx, acc, body)
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
  "deviceCount": 1,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "GM01Q",
      "make": "SEQUANS COMMUNICATIONS",
      "firmware": "SR1.2.0.0-10657",
      "fotaEligible": true,
      "licenseAssigned": true,
      "status": "Active",
      "protocol": "LWM2M",
      "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "statusTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "lastConnectionTime": "2012-04-23T18:25:43.511Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

