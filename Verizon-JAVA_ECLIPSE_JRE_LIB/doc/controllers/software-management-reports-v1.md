# Software Management Reports V1

```java
SoftwareManagementReportsV1Api softwareManagementReportsV1Api = client.getSoftwareManagementReportsV1Api();
```

## Class Name

`SoftwareManagementReportsV1Api`

## Methods

* [List Account Devices](../../doc/controllers/software-management-reports-v1.md#list-account-devices)
* [List Upgrades for Specified Status](../../doc/controllers/software-management-reports-v1.md#list-upgrades-for-specified-status)
* [Get Device Firmware Upgrade History](../../doc/controllers/software-management-reports-v1.md#get-device-firmware-upgrade-history)


# List Account Devices

Returns an array of all devices in the specified account. Each device object includes information needed for managing firmware, including the device make and model, MDN and IMEI, and current firmware version.

```java
CompletableFuture<ApiResponse<DeviceListQueryResult>> listAccountDevicesAsync(
    final String account,
    final String startIndex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |
| `startIndex` | `String` | Template, Required | Only return devices with IMEIs larger than this value. Use 0 for the first request. If `hasMoreData`=true in the response, use the `lastSeenDeviceId` value from the response as the startIndex in the next request. |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`DeviceListQueryResult`](../../doc/models/device-list-query-result.md).

## Example Usage

```java
String account = "0242078689-00001";
String startIndex = "startIndex4";

softwareManagementReportsV1Api.listAccountDevicesAsync(account, startIndex).thenAccept(result -> {
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
  "accountName": "0242078698-00001",
  "hasMoreData": true,
  "lastSeenDeviceId": 900000000001000,
  "deviceList": [
    {
      "deviceId": "900000000000001",
      "mdn": "0000040881",
      "model": "Model-A",
      "make": "Verizon",
      "firmware": "VerizonFirmwareVersion-01",
      "fotaEligible": true,
      "licenseAssigned": true,
      "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC"
    },
    {
      "deviceId": "900000000000999",
      "mdn": "0000041879",
      "model": "Model-A",
      "make": "Verizon",
      "firmware": "VerizonFirmwareVersion-01",
      "fotaEligible": true,
      "licenseAssigned": true,
      "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC"
    },
    {
      "deviceId": "900000000001000",
      "mdn": "0000041880",
      "model": "Model-A",
      "make": "Verizon",
      "firmware": "VerizonFirmwareVersion-01",
      "fotaEligible": true,
      "licenseAssigned": true,
      "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# List Upgrades for Specified Status

Returns a list of all upgrades with a specified status.

```java
CompletableFuture<ApiResponse<UpgradeListQueryResult>> listUpgradesForSpecifiedStatusAsync(
    final String account,
    final UpgradeStatus upgradeStatus,
    final String startIndex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |
| `upgradeStatus` | [`UpgradeStatus`](../../doc/models/upgrade-status.md) | Template, Required | The status of the upgrades that you want to retrieve. |
| `startIndex` | `String` | Template, Required | The zero-based number of the first record to return. Set startIndex=0 for the first request. If `hasMoreFlag`=true in the response, use the `lastSeenUpgradeId` value from the response as the startIndex in the next request. |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`UpgradeListQueryResult`](../../doc/models/upgrade-list-query-result.md).

## Example Usage

```java
String account = "0242078689-00001";
UpgradeStatus upgradeStatus = UpgradeStatus.REQUESTPENDING;
String startIndex = "startIndex4";

softwareManagementReportsV1Api.listUpgradesForSpecifiedStatusAsync(account, upgradeStatus, startIndex).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |


# Get Device Firmware Upgrade History

Returns the upgrade history of the specified device from the previous six months.

```java
CompletableFuture<ApiResponse<List<DeviceUpgradeHistory>>> getDeviceFirmwareUpgradeHistoryAsync(
    final String account,
    final String deviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier in "##########-#####". |
| `deviceId` | `String` | Template, Required | The IMEI of the device. |

## Server

`Server.SOFTWARE_MANAGEMENT_V1`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<DeviceUpgradeHistory>`](../../doc/models/device-upgrade-history.md).

## Example Usage

```java
String account = "0242078689-00001";
String deviceId = "900000000000001";

softwareManagementReportsV1Api.getDeviceFirmwareUpgradeHistoryAsync(account, deviceId).thenAccept(result -> {
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
[
  {
    "deviceId": "900000000000001",
    "id": "f574fbb8-b291-4cc7-bf22-4e3f27977558",
    "accountName": "0242078689-00001",
    "firmwareFrom": "VerizonFirmwareVersion-02",
    "firmwareTo": "VerizonFirmwareVersion-03",
    "startDate": "2018-03-05",
    "upgradeStartTime": "2018-03-05T19:07:21Z",
    "status": "UpgradeSuccess",
    "reason": "success"
  },
  {
    "deviceId": "900000000000001",
    "id": "5edade25-c06c-4b13-ba2a-fbb9ada93579",
    "accountName": "0242078689-00001",
    "firmwareFrom": "VerizonFirmwareVersion-01",
    "firmwareTo": "VerizonFirmwareVersion-02",
    "startDate": "2018-02-20",
    "upgradeStartTime": "2018-02-20T00:03:19Z",
    "status": "UpgradeSuccess",
    "reason": "success"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultException`](../../doc/models/fota-v1-result-exception.md) |

