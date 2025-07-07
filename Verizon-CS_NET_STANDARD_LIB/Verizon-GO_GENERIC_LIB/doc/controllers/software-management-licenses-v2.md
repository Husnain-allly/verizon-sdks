# Software Management Licenses V2

```go
softwareManagementLicensesV2Api := client.SoftwareManagementLicensesV2Api()
```

## Class Name

`SoftwareManagementLicensesV2Api`

## Methods

* [Get Account License Status](../../doc/controllers/software-management-licenses-v2.md#get-account-license-status)
* [Assign Licenses to Devices](../../doc/controllers/software-management-licenses-v2.md#assign-licenses-to-devices)
* [Remove Licenses From Devices](../../doc/controllers/software-management-licenses-v2.md#remove-licenses-from-devices)
* [List Licenses to Remove](../../doc/controllers/software-management-licenses-v2.md#list-licenses-to-remove)
* [Create List of Licenses to Remove](../../doc/controllers/software-management-licenses-v2.md#create-list-of-licenses-to-remove)
* [Delete List of Licenses to Remove](../../doc/controllers/software-management-licenses-v2.md#delete-list-of-licenses-to-remove)


# Get Account License Status

The endpoint allows user to list license usage.

```go
GetAccountLicenseStatus(
    ctx context.Context,
    account string,
    lastSeenDeviceId *string) (
    models.ApiResponse[models.V2LicenseSummary],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `lastSeenDeviceId` | `*string` | Query, Optional | Last seen device identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V2LicenseSummary](../../doc/models/v2-license-summary.md).

## Example Usage

```go
ctx := context.Background()

account := "0000123456-00001"

lastSeenDeviceId := "15-digit IMEI"

apiResponse, err := softwareManagementLicensesV2Api.GetAccountLicenseStatus(ctx, account, &lastSeenDeviceId)
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
  "accountName": "0402196254-00001",
  "totalLicense": 5000,
  "assignedLicenses": 4319,
  "hasMoreData": true,
  "lastSeenDeviceId": "1000",
  "maxPageSize": 10,
  "deviceList": [
    {
      "deviceId": "990003425730535",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990000473475989",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990000347475989",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    },
    {
      "deviceId": "990007303425535",
      "assignmentTime": "2017-11-29T16:03:42.000Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Assign Licenses to Devices

**This endpoint is deprecated.**

This endpoint allows user to assign licenses to a list of devices.

```go
AssignLicensesToDevices(
    ctx context.Context,
    account string,
    body models.V2LicenseImei) (
    models.ApiResponse[models.V2LicensesAssignedRemovedResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`models.V2LicenseImei`](../../doc/models/v2-license-imei.md) | Body, Required | License assignment. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V2LicensesAssignedRemovedResult](../../doc/models/v2-licenses-assigned-removed-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"

body := models.V2LicenseImei{
    DeviceList:            []string{
        "990003425730524",
        "990000473475967",
    },
}

apiResponse, err := softwareManagementLicensesV2Api.AssignLicensesToDevices(ctx, account, body)
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
  "accountName": "0242078689-00001",
  "licTotalCount": 1000,
  "licUsedCount": 502,
  "deviceList": [
    {
      "deviceId": "990003425730524",
      "status": "Success",
      "resultReason": "Success"
    },
    {
      "deviceId": "990000473475967",
      "status": "Failure",
      "resultReason": "Device does not exist."
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Remove Licenses From Devices

**This endpoint is deprecated.**

This endpoint allows user to remove licenses from a list of devices.

```go
RemoveLicensesFromDevices(
    ctx context.Context,
    account string,
    body models.V2LicenseImei) (
    models.ApiResponse[models.V2LicensesAssignedRemovedResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`models.V2LicenseImei`](../../doc/models/v2-license-imei.md) | Body, Required | License removal. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V2LicensesAssignedRemovedResult](../../doc/models/v2-licenses-assigned-removed-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"

body := models.V2LicenseImei{
    DeviceList:            []string{
        "990003425730535",
        "990000473475989",
        "900000000000999",
    },
}

apiResponse, err := softwareManagementLicensesV2Api.RemoveLicensesFromDevices(ctx, account, body)
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
  "accountName": "0242078689-00001",
  "licTotalCount": 1000,
  "licUsedCount": 998,
  "deviceList": [
    {
      "deviceId": "990003425730535",
      "status": "Success",
      "resultReason": "Success"
    },
    {
      "deviceId": "990000473475989",
      "status": "Success",
      "resultReason": "Success"
    },
    {
      "deviceId": "900000000000999",
      "status": "Failure",
      "resultReason": "No license attached to device"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# List Licenses to Remove

**This endpoint is deprecated.**

The license cancel endpoint allows user to list registered license cancellation candidate devices.

```go
ListLicensesToRemove(
    ctx context.Context,
    account string,
    startIndex *string) (
    models.ApiResponse[models.V2ListOfLicensesToRemove],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `startIndex` | `*string` | Query, Optional | Start index to retrieve. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V2ListOfLicensesToRemove](../../doc/models/v2-list-of-licenses-to-remove.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"



apiResponse, err := softwareManagementLicensesV2Api.ListLicensesToRemove(ctx, account, nil)
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
  "count": 6,
  "hasMoreData": false,
  "updateTime": "2018-03-22 00:06:00.069 +0000 UTC",
  "deviceList": [
    "990003425730535",
    "990000473475989",
    "990005733420535",
    "990000347475989",
    "990007303425535",
    "990007590473489"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Create List of Licenses to Remove

**This endpoint is deprecated.**

The license cancel endpoint allows user to create a list of license cancellation candidate devices.

```go
CreateListOfLicensesToRemove(
    ctx context.Context,
    account string,
    body models.V2ListOfLicensesToRemoveRequest) (
    models.ApiResponse[models.V2ListOfLicensesToRemoveResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |
| `body` | [`models.V2ListOfLicensesToRemoveRequest`](../../doc/models/v2-list-of-licenses-to-remove-request.md) | Body, Required | List of licensess to remove. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V2ListOfLicensesToRemoveResult](../../doc/models/v2-list-of-licenses-to-remove-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"

body := models.V2ListOfLicensesToRemoveRequest{
    Type:                  models.ToPointer("append"),
    Count:                 models.ToPointer(2),
    DeviceList:            []string{
        "990003425730535",
        "990000473475989",
    },
}

apiResponse, err := softwareManagementLicensesV2Api.CreateListOfLicensesToRemove(ctx, account, body)
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
  "count": 2,
  "deviceList": [
    "990003425730535",
    "990000473475989"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Delete List of Licenses to Remove

**This endpoint is deprecated.**

This endpoint allows user to delete a created cancel candidate device list.

```go
DeleteListOfLicensesToRemove(
    ctx context.Context,
    account string) (
    models.ApiResponse[models.FotaV2SuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV2SuccessResult](../../doc/models/fota-v2-success-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"

apiResponse, err := softwareManagementLicensesV2Api.DeleteListOfLicensesToRemove(ctx, account)
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
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

