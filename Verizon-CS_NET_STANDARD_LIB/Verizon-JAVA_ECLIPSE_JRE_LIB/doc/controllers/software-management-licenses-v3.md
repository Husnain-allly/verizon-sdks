# Software Management Licenses V3

```java
SoftwareManagementLicensesV3Api softwareManagementLicensesV3Api = client.getSoftwareManagementLicensesV3Api();
```

## Class Name

`SoftwareManagementLicensesV3Api`

## Methods

* [Get Account Licenses Status](../../doc/controllers/software-management-licenses-v3.md#get-account-licenses-status)
* [Assign Licenses to Devices](../../doc/controllers/software-management-licenses-v3.md#assign-licenses-to-devices)
* [Remove Licenses From Devices](../../doc/controllers/software-management-licenses-v3.md#remove-licenses-from-devices)


# Get Account Licenses Status

The endpoint allows user to list license usage.

```java
CompletableFuture<ApiResponse<V3LicenseSummary>> getAccountLicensesStatusAsync(
    final String acc,
    final String lastSeenDeviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `lastSeenDeviceId` | `String` | Query, Optional | Last seen device identifier. |

## Server

`Server.SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V3LicenseSummary`](../../doc/models/v3-license-summary.md).

## Example Usage

```java
String acc = "0000123456-00001";
String lastSeenDeviceId = "0";

softwareManagementLicensesV3Api.getAccountLicensesStatusAsync(acc, lastSeenDeviceId).thenAccept(result -> {
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

```java
CompletableFuture<ApiResponse<V3LicenseAssignedRemovedResult>> assignLicensesToDevicesAsync(
    final String acc,
    final V3LicenseImei body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `body` | [`V3LicenseImei`](../../doc/models/v3-license-imei.md) | Body, Required | License assignment. |

## Server

`Server.SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V3LicenseAssignedRemovedResult`](../../doc/models/v3-license-assigned-removed-result.md).

## Example Usage

```java
String acc = "0000123456-00001";
V3LicenseImei body = new V3LicenseImei.Builder(
    Arrays.asList(
        "15-digit IMEI",
        "15-digit IMEI"
    )
)
.build();

softwareManagementLicensesV3Api.assignLicensesToDevicesAsync(acc, body).thenAccept(result -> {
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

```java
CompletableFuture<ApiResponse<V3LicenseAssignedRemovedResult>> removeLicensesFromDevicesAsync(
    final String acc,
    final V3LicenseImei body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `body` | [`V3LicenseImei`](../../doc/models/v3-license-imei.md) | Body, Required | License removal. |

## Server

`Server.SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V3LicenseAssignedRemovedResult`](../../doc/models/v3-license-assigned-removed-result.md).

## Example Usage

```java
String acc = "0000123456-00001";
V3LicenseImei body = new V3LicenseImei.Builder(
    Arrays.asList(
        "15-digit IMEI",
        "15-digit IMEI",
        "15-digit IMEI"
    )
)
.build();

softwareManagementLicensesV3Api.removeLicensesFromDevicesAsync(acc, body).thenAccept(result -> {
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

