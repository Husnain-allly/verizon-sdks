# Software Management Reports V2

```java
SoftwareManagementReportsV2Api softwareManagementReportsV2Api = client.getSoftwareManagementReportsV2Api();
```

## Class Name

`SoftwareManagementReportsV2Api`

## Methods

* [List Available Software](../../doc/controllers/software-management-reports-v2.md#list-available-software)
* [List Account Devices](../../doc/controllers/software-management-reports-v2.md#list-account-devices)
* [Get Device Firmware Upgrade History](../../doc/controllers/software-management-reports-v2.md#get-device-firmware-upgrade-history)
* [Get Campaign History by Status](../../doc/controllers/software-management-reports-v2.md#get-campaign-history-by-status)
* [Get Campaign Device Status](../../doc/controllers/software-management-reports-v2.md#get-campaign-device-status)


# List Available Software

This endpoint allows user to list a certain type of software of an account.

```java
CompletableFuture<ApiResponse<List<SoftwarePackage>>> listAvailableSoftwareAsync(
    final String account,
    final String distributionType)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `distributionType` | `String` | Query, Optional | Filter distributionType to get specific type of software. Value is LWM2M, OMD-DM or HTTP. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<SoftwarePackage>`](../../doc/models/software-package.md).

## Example Usage

```java
String account = "0000123456-00001";
String distributionType = "HTTP";

softwareManagementReportsV2Api.listAvailableSoftwareAsync(account, distributionType).thenAccept(result -> {
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
    "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
    "launchDate": "2020-08-31",
    "releaseNote": "",
    "model": "Model-A",
    "make": "Verizon",
    "distributionType": "HTTP",
    "devicePlatformId": "IoT"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# List Account Devices

The device endpoint gets devices information of an account.

```java
CompletableFuture<ApiResponse<V2AccountDeviceList>> listAccountDevicesAsync(
    final String account,
    final String lastSeenDeviceId,
    final String distributionType)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `lastSeenDeviceId` | `String` | Query, Optional | Last seen device identifier. |
| `distributionType` | `String` | Query, Optional | Filter distributionType to get specific type of devices. Values is LWM2M, OMD-DM or HTTP. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V2AccountDeviceList`](../../doc/models/v2-account-device-list.md).

## Example Usage

```java
String account = "0000123456-00001";
String lastSeenDeviceId = "15-digit IMEI";
String distributionType = "HTTP";

softwareManagementReportsV2Api.listAccountDevicesAsync(account, lastSeenDeviceId, distributionType).thenAccept(result -> {
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
  "hasMoreData": true,
  "lastSeenDeviceId": "15-digit IMEI",
  "maxPageSize": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "Model-A",
      "make": "Verizon",
      "fotaEligible": true,
      "appFotaEligible": true,
      "licenseAssigned": true,
      "distributionType": "HTTP",
      "softwareList": [
        {
          "name": "FOTA_Verizon_Model-A_02To03_HF",
          "version": "3",
          "upgradeTime": "2020-09-08T19:00:51.541Z"
        }
      ],
      "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "updateTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC"
    },
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "Model-A",
      "make": "Verizon",
      "fotaEligible": true,
      "appFotaEligible": true,
      "licenseAssigned": true,
      "distributionType": "HTTP",
      "softwareList": [
        {
          "name": "FOTA_Verizon_Model-A_02To03_HF",
          "version": "3",
          "upgradeTime": "2020-09-08T19:00:51.541Z"
        }
      ],
      "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "updateTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC"
    },
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "Model-A",
      "make": "Verizon",
      "fotaEligible": true,
      "appFotaEligible": true,
      "licenseAssigned": true,
      "distributionType": "HTTP",
      "softwareList": [
        {
          "name": "FOTA_Verizon_Model-A_02To03_HF",
          "version": "3",
          "upgradeTime": "2020-09-08T19:00:51.541Z"
        }
      ],
      "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "upgradeTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "updateTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Get Device Firmware Upgrade History

The endpoint allows user to get software upgrade history of a device based on device IMEI.

```java
CompletableFuture<ApiResponse<List<DeviceSoftwareUpgrade>>> getDeviceFirmwareUpgradeHistoryAsync(
    final String account,
    final String deviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `deviceId` | `String` | Template, Required | Device IMEI identifier. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<DeviceSoftwareUpgrade>`](../../doc/models/device-software-upgrade.md).

## Example Usage

```java
String account = "0000123456-00001";
String deviceId = "990013907835573";

softwareManagementReportsV2Api.getDeviceFirmwareUpgradeHistoryAsync(account, deviceId).thenAccept(result -> {
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
    "deviceId": "990013907835573",
    "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
    "accountName": "0402196254-00001",
    "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
    "startDate": "2018-03-05",
    "status": "UpgradeSuccess",
    "reason": "success"
  },
  {
    "deviceId": "990013907835573",
    "id": "50d5d639-aaca-3ca7-7713-958ac83b84ae",
    "accountName": "0402196254-00001",
    "softwareName": "VerizonSoftwareVersion-01",
    "startDate": "2018-02-20",
    "status": "UpgradeSuccess",
    "reason": "success"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Get Campaign History by Status

The report endpoint allows user to get campaign history of an account for specified status.

```java
CompletableFuture<ApiResponse<V2CampaignHistory>> getCampaignHistoryByStatusAsync(
    final String account,
    final String campaignStatus,
    final String lastSeenCampaignId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `campaignStatus` | `String` | Query, Required | Status of the campaign. |
| `lastSeenCampaignId` | `String` | Query, Optional | Last seen campaign Id. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V2CampaignHistory`](../../doc/models/v2-campaign-history.md).

## Example Usage

```java
String account = "0000123456-00001";
String campaignStatus = "campaignStatus6";
String lastSeenCampaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf";

softwareManagementReportsV2Api.getCampaignHistoryByStatusAsync(account, campaignStatus, lastSeenCampaignId).thenAccept(result -> {
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
  "hasMoreData": true,
  "lastSeenCampaignId": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "campaignList": [
    {
      "accountName": "0402196254-00001",
      "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
      "campaignName": "FOTA_Verizon_Upgrade",
      "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
      "distributionType": "HTTP",
      "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
      "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
      "make": "Verizon",
      "model": "Model-A",
      "startDate": "2020-08-21",
      "endDate": "2020-08-22",
      "downloadAfterDate": "2020-08-21",
      "downloadTimeWindowList": [
        {
          "startTime": 20,
          "endTime": 21
        }
      ],
      "installAfterDate": "2020-08-21",
      "installTimeWindowList": [
        {
          "startTime": 22,
          "endTime": 23
        }
      ],
      "status": "CampaignEnded"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Get Campaign Device Status

The report endpoint allows user to get the full list of device of a campaign.

```java
CompletableFuture<ApiResponse<V2CampaignDevice>> getCampaignDeviceStatusAsync(
    final String account,
    final String campaignId,
    final String lastSeenDeviceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `campaignId` | `String` | Template, Required | Campaign identifier. |
| `lastSeenDeviceId` | `String` | Query, Optional | Last seen device identifier. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V2CampaignDevice`](../../doc/models/v2-campaign-device.md).

## Example Usage

```java
String account = "0000123456-00001";
String campaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf";
String lastSeenDeviceId = "15-digit IMEI";

softwareManagementReportsV2Api.getCampaignDeviceStatusAsync(account, campaignId, lastSeenDeviceId).thenAccept(result -> {
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
  "totalDevice": 1148,
  "hasMoreData": true,
  "lastSeenDeviceId": "15-digit IMEI",
  "maxPageSize": 1000,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradeSuccess",
      "resultReason": "DownloadInstallSucceeded"
    },
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradeSuccess",
      "resultReason": "DownloadInstallSucceeded"
    },
    {
      "deviceId": "15-digit IMEI",
      "status": "UpgradeSuccess",
      "resultReason": "DownloadInstallSucceeded"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

