# Software Management Licenses V1

```go
softwareManagementLicensesV1Api := client.SoftwareManagementLicensesV1Api()
```

## Class Name

`SoftwareManagementLicensesV1Api`

## Methods

* [Assign Licenses to Devices](../../doc/controllers/software-management-licenses-v1.md#assign-licenses-to-devices)
* [Remove Licenses From Devices](../../doc/controllers/software-management-licenses-v1.md#remove-licenses-from-devices)
* [Create List of Licenses to Remove](../../doc/controllers/software-management-licenses-v1.md#create-list-of-licenses-to-remove)
* [Delete List of Licenses to Remove](../../doc/controllers/software-management-licenses-v1.md#delete-list-of-licenses-to-remove)
* [List Licenses to Remove](../../doc/controllers/software-management-licenses-v1.md#list-licenses-to-remove)


# Assign Licenses to Devices

**This endpoint is deprecated.**

Assigns licenses to a specified list of devices so that firmware upgrades can be scheduled for those devices.

```go
AssignLicensesToDevices(
    ctx context.Context,
    account string,
    body models.V1LicensesAssignedRemovedRequest) (
    models.ApiResponse[models.V1LicensesAssignedRemovedResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`models.V1LicensesAssignedRemovedRequest`](../../doc/models/v1-licenses-assigned-removed-request.md) | Body, Required | IMEIs of the devices to assign licenses to. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V1LicensesAssignedRemovedResult](../../doc/models/v1-licenses-assigned-removed-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"

body := models.V1LicensesAssignedRemovedRequest{
    DeviceList:            []string{
        "990003425730535",
        "990000473475989",
    },
}

apiResponse, err := softwareManagementLicensesV1Api.AssignLicensesToDevices(ctx, account, body)
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
  "licCount": 9000,
  "licUsedCount": 1000,
  "deviceList": [
    {
      "deviceId": "900000000000001",
      "status": "LicenseAssignSuccess",
      "Reason": "Success"
    },
    {
      "deviceId": "900000000000999",
      "status": "LicenseAssignSuccess",
      "Reason": "Success"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Remove Licenses From Devices

**This endpoint is deprecated.**

Remove unused licenses from device.

```go
RemoveLicensesFromDevices(
    ctx context.Context,
    account string,
    body models.V1LicensesAssignedRemovedRequest) (
    models.ApiResponse[models.V1LicensesAssignedRemovedResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`models.V1LicensesAssignedRemovedRequest`](../../doc/models/v1-licenses-assigned-removed-request.md) | Body, Required | IMEIs of the devices to remove licenses from. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V1LicensesAssignedRemovedResult](../../doc/models/v1-licenses-assigned-removed-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"

body := models.V1LicensesAssignedRemovedRequest{
    DeviceList:            []string{
        "900000000000001",
        "900000000000998",
        "900000000000999",
    },
}

apiResponse, err := softwareManagementLicensesV1Api.RemoveLicensesFromDevices(ctx, account, body)
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
  "licCount": 9000,
  "licUsedCount": 998,
  "deviceList": [
    {
      "deviceId": "900000000000001",
      "status": "LicenseRemoveSuccess",
      "Reason": "Success"
    },
    {
      "deviceId": "900000000000998",
      "status": "LicenseRemoveSuccess",
      "Reason": "Success"
    },
    {
      "deviceId": "900000000000999",
      "status": "LicenseRemoveFailed",
      "Reason": "No license attached to device"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Create List of Licenses to Remove

**This endpoint is deprecated.**

Creates a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.

```go
CreateListOfLicensesToRemove(
    ctx context.Context,
    account string,
    body models.V1ListOfLicensesToRemoveRequest) (
    models.ApiResponse[models.V1ListOfLicensesToRemoveResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`models.V1ListOfLicensesToRemoveRequest`](../../doc/models/v1-list-of-licenses-to-remove-request.md) | Body, Required | Cancellation candidate device list. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V1ListOfLicensesToRemoveResult](../../doc/models/v1-list-of-licenses-to-remove-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"

body := models.V1ListOfLicensesToRemoveRequest{
    Type:                  models.ToPointer("append"),
    DeviceList:            []string{
        "990003425730535",
        "990000473475989",
    },
}

apiResponse, err := softwareManagementLicensesV1Api.CreateListOfLicensesToRemove(ctx, account, body)
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
    "900000000000001",
    "900000000000999"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Delete List of Licenses to Remove

**This endpoint is deprecated.**

Deletes the entire list of cancellation candidate devices.

```go
DeleteListOfLicensesToRemove(
    ctx context.Context,
    account string) (
    models.ApiResponse[models.FotaV1SuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.FotaV1SuccessResult](../../doc/models/fota-v1-success-result.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"

apiResponse, err := softwareManagementLicensesV1Api.DeleteListOfLicensesToRemove(ctx, account)
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
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# List Licenses to Remove

**This endpoint is deprecated.**

Returns a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.

```go
ListLicensesToRemove(
    ctx context.Context,
    account string,
    startIndex string) (
    models.ApiResponse[models.V1ListOfLicensesToRemove],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `startIndex` | `string` | Template, Required | The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.V1ListOfLicensesToRemove](../../doc/models/v1-list-of-licenses-to-remove.md).

## Example Usage

```go
ctx := context.Background()

account := "0242078689-00001"

startIndex := "startIndex4"

apiResponse, err := softwareManagementLicensesV1Api.ListLicensesToRemove(ctx, account, startIndex)
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
  "updateTime": "2018-03-22T12:06:06.000Z",
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
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |

