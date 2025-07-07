# Software Management Licenses V1

```java
SoftwareManagementLicensesV1Api softwareManagementLicensesV1Api = client.getSoftwareManagementLicensesV1Api();
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

```java
CompletableFuture<ApiResponse<V1LicensesAssignedRemovedResult>> assignLicensesToDevicesAsync(
    final String account,
    final V1LicensesAssignedRemovedRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`V1LicensesAssignedRemovedRequest`](../../doc/models/v1-licenses-assigned-removed-request.md) | Body, Required | IMEIs of the devices to assign licenses to. |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V1LicensesAssignedRemovedResult`](../../doc/models/v1-licenses-assigned-removed-result.md).

## Example Usage

```java
String account = "0242078689-00001";
V1LicensesAssignedRemovedRequest body = new V1LicensesAssignedRemovedRequest.Builder(
    Arrays.asList(
        "990003425730535",
        "990000473475989"
    )
)
.build();

softwareManagementLicensesV1Api.assignLicensesToDevicesAsync(account, body).thenAccept(result -> {
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

```java
CompletableFuture<ApiResponse<V1LicensesAssignedRemovedResult>> removeLicensesFromDevicesAsync(
    final String account,
    final V1LicensesAssignedRemovedRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`V1LicensesAssignedRemovedRequest`](../../doc/models/v1-licenses-assigned-removed-request.md) | Body, Required | IMEIs of the devices to remove licenses from. |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V1LicensesAssignedRemovedResult`](../../doc/models/v1-licenses-assigned-removed-result.md).

## Example Usage

```java
String account = "0242078689-00001";
V1LicensesAssignedRemovedRequest body = new V1LicensesAssignedRemovedRequest.Builder(
    Arrays.asList(
        "900000000000001",
        "900000000000998",
        "900000000000999"
    )
)
.build();

softwareManagementLicensesV1Api.removeLicensesFromDevicesAsync(account, body).thenAccept(result -> {
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

```java
CompletableFuture<ApiResponse<V1ListOfLicensesToRemoveResult>> createListOfLicensesToRemoveAsync(
    final String account,
    final V1ListOfLicensesToRemoveRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`V1ListOfLicensesToRemoveRequest`](../../doc/models/v1-list-of-licenses-to-remove-request.md) | Body, Required | Cancellation candidate device list. |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V1ListOfLicensesToRemoveResult`](../../doc/models/v1-list-of-licenses-to-remove-result.md).

## Example Usage

```java
String account = "0242078689-00001";
V1ListOfLicensesToRemoveRequest body = new V1ListOfLicensesToRemoveRequest.Builder(
    Arrays.asList(
        "990003425730535",
        "990000473475989"
    )
)
.type("append")
.build();

softwareManagementLicensesV1Api.createListOfLicensesToRemoveAsync(account, body).thenAccept(result -> {
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

```java
CompletableFuture<ApiResponse<FotaV1SuccessResult>> deleteListOfLicensesToRemoveAsync(
    final String account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`FotaV1SuccessResult`](../../doc/models/fota-v1-success-result.md).

## Example Usage

```java
String account = "0242078689-00001";

softwareManagementLicensesV1Api.deleteListOfLicensesToRemoveAsync(account).thenAccept(result -> {
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
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# List Licenses to Remove

**This endpoint is deprecated.**

Returns a list of devices from which licenses will be removed if the number of MRC licenses becomes less than the number of assigned licenses.

```java
CompletableFuture<ApiResponse<V1ListOfLicensesToRemove>> listLicensesToRemoveAsync(
    final String account,
    final String startIndex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |
| `startIndex` | `String` | Template, Required | The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc. |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V1ListOfLicensesToRemove`](../../doc/models/v1-list-of-licenses-to-remove.md).

## Example Usage

```java
String account = "0242078689-00001";
String startIndex = "startIndex4";

softwareManagementLicensesV1Api.listLicensesToRemoveAsync(account, startIndex).thenAccept(result -> {
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

