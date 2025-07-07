# Software Management Licenses V3

```go
softwareManagementLicensesV3Api := client.SoftwareManagementLicensesV3Api()
```

## Class Name

`SoftwareManagementLicensesV3Api`

## Methods

* [Get Account Licenses Status](../../doc/controllers/software-management-licenses-v3.md#get-account-licenses-status)
* [Assign Licenses to Devices](../../doc/controllers/software-management-licenses-v3.md#assign-licenses-to-devices)
* [Remove Licenses From Devices](../../doc/controllers/software-management-licenses-v3.md#remove-licenses-from-devices)


# Get Account Licenses Status

The endpoint allows user to list license usage.

```go
GetAccountLicensesStatus(
    ctx context.Context,
    acc string,
    lastSeenDeviceId *string) (
    models.ApiResponse[models.V3LicenseSummary],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `lastSeenDeviceId` | `*string` | Query, Optional | Last seen device identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V3LicenseSummary](../../doc/models/v3-license-summary.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

lastSeenDeviceId := "0"

apiResponse, err := softwareManagementLicensesV3Api.GetAccountLicensesStatus(ctx, acc, &lastSeenDeviceId)
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
  "assignedLicenses": 4319,
  "hasMoreData": true,
  "lastSeenDeviceId": "1000",
  "maxPageSize": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "assignmentTime": "2017-11-29 20:15:42.738 +0000 UTC"
    },
    {
      "deviceId": "15-digit IMEI",
      "assignmentTime": "2017-11-29 20:15:42.738 +0000 UTC"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Assign Licenses to Devices

This endpoint allows user to assign licenses to a list of devices.

```go
AssignLicensesToDevices(
    ctx context.Context,
    acc string,
    body models.V3LicenseImei) (
    models.ApiResponse[models.V3LicenseAssignedRemovedResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`models.V3LicenseImei`](../../doc/models/v3-license-imei.md) | Body, Required | License assignment. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V3LicenseAssignedRemovedResult](../../doc/models/v3-license-assigned-removed-result.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

body := models.V3LicenseImei{
    DeviceList:            []string{
        "15-digit IMEI",
        "15-digit IMEI",
    },
}

apiResponse, err := softwareManagementLicensesV3Api.AssignLicensesToDevices(ctx, acc, body)
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
  "licUsedCount": 2,
  "licCount": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradePending",
      "resultReason": "Upgrade pending, the device upgrade is estimated to be scheduled for 06 Oct 22 18:05 UTC",
      "updatedTime": "2022-08-05T21:05:27.129Z",
      "recentAttemptTime": "2022-10-05T21:05:01.19Z",
      "nextAttemptTime": "2022-10-06T18:35:00Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Remove Licenses From Devices

This endpoint allows user to remove licenses from a list of devices.

```go
RemoveLicensesFromDevices(
    ctx context.Context,
    acc string,
    body models.V3LicenseImei) (
    models.ApiResponse[models.V3LicenseAssignedRemovedResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`models.V3LicenseImei`](../../doc/models/v3-license-imei.md) | Body, Required | License removal. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V3LicenseAssignedRemovedResult](../../doc/models/v3-license-assigned-removed-result.md).

## Example Usage

```go
ctx := context.Background()

acc := "0000123456-00001"

body := models.V3LicenseImei{
    DeviceList:            []string{
        "15-digit IMEI",
        "15-digit IMEI",
        "15-digit IMEI",
    },
}

apiResponse, err := softwareManagementLicensesV3Api.RemoveLicensesFromDevices(ctx, acc, body)
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
  "licUsedCount": 998,
  "licCount": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradePending",
      "resultReason": "Upgrade pending, the device upgrade is estimated to be scheduled for 06 Oct 22 18:05 UTC",
      "updatedTime": "2022-08-05T21:05:27.129Z",
      "recentAttemptTime": "2022-10-05T21:05:01.19Z",
      "nextAttemptTime": "2022-10-06T18:35:00Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

