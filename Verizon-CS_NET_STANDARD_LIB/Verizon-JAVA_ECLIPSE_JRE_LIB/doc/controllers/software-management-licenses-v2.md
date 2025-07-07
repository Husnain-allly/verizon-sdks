# Software Management Licenses V2

```java
SoftwareManagementLicensesV2Api softwareManagementLicensesV2Api = client.getSoftwareManagementLicensesV2Api();
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

```java
CompletableFuture<ApiResponse<V2LicenseSummary>> getAccountLicenseStatusAsync(
    final String account,
    final String lastSeenDeviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `lastSeenDeviceId` | `String` | Query, Optional | Last seen device identifier. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V2LicenseSummary`](../../doc/models/v2-license-summary.md).

## Example Usage

```java
String account = "0000123456-00001";
String lastSeenDeviceId = "15-digit IMEI";

softwareManagementLicensesV2Api.getAccountLicenseStatusAsync(account, lastSeenDeviceId).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<V2LicensesAssignedRemovedResult>> assignLicensesToDevicesAsync(
    final String account,
    final V2LicenseImei body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `body` | [`V2LicenseImei`](../../doc/models/v2-license-imei.md) | Body, Required | License assignment. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V2LicensesAssignedRemovedResult`](../../doc/models/v2-licenses-assigned-removed-result.md).

## Example Usage

```java
String account = "0242078689-00001";
V2LicenseImei body = new V2LicenseImei.Builder(
    Arrays.asList(
        "990003425730524",
        "990000473475967"
    )
)
.build();

softwareManagementLicensesV2Api.assignLicensesToDevicesAsync(account, body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<V2LicensesAssignedRemovedResult>> removeLicensesFromDevicesAsync(
    final String account,
    final V2LicenseImei body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `body` | [`V2LicenseImei`](../../doc/models/v2-license-imei.md) | Body, Required | License removal. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V2LicensesAssignedRemovedResult`](../../doc/models/v2-licenses-assigned-removed-result.md).

## Example Usage

```java
String account = "0242078689-00001";
V2LicenseImei body = new V2LicenseImei.Builder(
    Arrays.asList(
        "990003425730535",
        "990000473475989",
        "900000000000999"
    )
)
.build();

softwareManagementLicensesV2Api.removeLicensesFromDevicesAsync(account, body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<V2ListOfLicensesToRemove>> listLicensesToRemoveAsync(
    final String account,
    final String startIndex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `startIndex` | `String` | Query, Optional | Start index to retrieve. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V2ListOfLicensesToRemove`](../../doc/models/v2-list-of-licenses-to-remove.md).

## Example Usage

```java
String account = "0242078689-00001";

softwareManagementLicensesV2Api.listLicensesToRemoveAsync(account, null).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<V2ListOfLicensesToRemoveResult>> createListOfLicensesToRemoveAsync(
    final String account,
    final V2ListOfLicensesToRemoveRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `body` | [`V2ListOfLicensesToRemoveRequest`](../../doc/models/v2-list-of-licenses-to-remove-request.md) | Body, Required | List of licensess to remove. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V2ListOfLicensesToRemoveResult`](../../doc/models/v2-list-of-licenses-to-remove-result.md).

## Example Usage

```java
String account = "0242078689-00001";
V2ListOfLicensesToRemoveRequest body = new V2ListOfLicensesToRemoveRequest.Builder(
    Arrays.asList(
        "990003425730535",
        "990000473475989"
    )
)
.type("append")
.count(2)
.build();

softwareManagementLicensesV2Api.createListOfLicensesToRemoveAsync(account, body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<FotaV2SuccessResult>> deleteListOfLicensesToRemoveAsync(
    final String account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`FotaV2SuccessResult`](../../doc/models/fota-v2-success-result.md).

## Example Usage

```java
String account = "0242078689-00001";

softwareManagementLicensesV2Api.deleteListOfLicensesToRemoveAsync(account).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

