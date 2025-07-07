# Campaigns V2

```java
CampaignsV2Api campaignsV2Api = client.getCampaignsV2Api();
```

## Class Name

`CampaignsV2Api`

## Methods

* [Schedule Campaign Firmware Upgrade](../../doc/controllers/campaigns-v2.md#schedule-campaign-firmware-upgrade)
* [Get Campaign Information](../../doc/controllers/campaigns-v2.md#get-campaign-information)
* [Update Campaign Firmware Devices](../../doc/controllers/campaigns-v2.md#update-campaign-firmware-devices)
* [Cancel Campaign](../../doc/controllers/campaigns-v2.md#cancel-campaign)
* [Update Campaign Dates](../../doc/controllers/campaigns-v2.md#update-campaign-dates)
* [Schedule File Upgrade](../../doc/controllers/campaigns-v2.md#schedule-file-upgrade)
* [Schedule SW Upgrade Http Devices](../../doc/controllers/campaigns-v2.md#schedule-sw-upgrade-http-devices)


# Schedule Campaign Firmware Upgrade

This endpoint allows user to schedule a software upgrade.

```java
CompletableFuture<ApiResponse<CampaignSoftware>> scheduleCampaignFirmwareUpgradeAsync(
    final String account,
    final CampaignSoftwareUpgrade body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `body` | [`CampaignSoftwareUpgrade`](../../doc/models/campaign-software-upgrade.md) | Body, Required | Software upgrade information. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`CampaignSoftware`](../../doc/models/campaign-software.md).

## Example Usage

```java
String account = "0000123456-00001";
CampaignSoftwareUpgrade body = new CampaignSoftwareUpgrade.Builder(
    "FOTA_Verizon_Model-A_02To03_HF",
    "FOTA_Verizon_Model-A_00To01_HF",
    "FOTA_Verizon_Model-A_02To03_HF",
    "HTTP",
    DateTimeHelper.fromSimpleDate("2020-08-21"),
    DateTimeHelper.fromSimpleDate("2020-08-22"),
    Arrays.asList(
        "990013907835573",
        "990013907884259"
    )
)
.campaignName("FOTA_Verizon_Upgrade")
.downloadAfterDate(DateTimeHelper.fromSimpleDate("2020-08-21"))
.downloadTimeWindowList(Arrays.asList(
        new V2TimeWindow.Builder(
            20,
            21
        )
        .build()
    ))
.installAfterDate(DateTimeHelper.fromSimpleDate("2020-08-21"))
.installTimeWindowList(Arrays.asList(
        new V2TimeWindow.Builder(
            22,
            23
        )
        .build()
    ))
.build();

campaignsV2Api.scheduleCampaignFirmwareUpgradeAsync(account, body).thenAccept(result -> {
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
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
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
  "status": "CampaignRequestPending"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Get Campaign Information

This endpoint allows user to get information of a software upgrade.

```java
CompletableFuture<ApiResponse<CampaignSoftware>> getCampaignInformationAsync(
    final String account,
    final String campaignId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `campaignId` | `String` | Template, Required | Software upgrade identifier. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`CampaignSoftware`](../../doc/models/campaign-software.md).

## Example Usage

```java
String account = "0000123456-00001";
String campaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf";

campaignsV2Api.getCampaignInformationAsync(account, campaignId).thenAccept(result -> {
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
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
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
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Update Campaign Firmware Devices

This endpoint allows user to Add or Remove devices to an existing software upgrade.

```java
CompletableFuture<ApiResponse<V2AddOrRemoveDeviceResult>> updateCampaignFirmwareDevicesAsync(
    final String account,
    final String campaignId,
    final V2AddOrRemoveDeviceRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `campaignId` | `String` | Template, Required | Software upgrade information. |
| `body` | [`V2AddOrRemoveDeviceRequest`](../../doc/models/v2-add-or-remove-device-request.md) | Body, Required | Request to add or remove device to existing software upgrade information. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V2AddOrRemoveDeviceResult`](../../doc/models/v2-add-or-remove-device-result.md).

## Example Usage

```java
String account = "0000123456-00001";
String campaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf";
V2AddOrRemoveDeviceRequest body = new V2AddOrRemoveDeviceRequest.Builder(
    "remove",
    Arrays.asList(
        "990013907884259",
        "990013907835573",
        "990013907833575"
    )
)
.build();

campaignsV2Api.updateCampaignFirmwareDevicesAsync(account, campaignId, body).thenAccept(result -> {
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
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Cancel Campaign

This endpoint allows user to cancel software upgrade. A software upgrade already started can not be cancelled.

```java
CompletableFuture<ApiResponse<FotaV2SuccessResult>> cancelCampaignAsync(
    final String account,
    final String campaignId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `campaignId` | `String` | Template, Required | Unique identifier of campaign. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`FotaV2SuccessResult`](../../doc/models/fota-v2-success-result.md).

## Example Usage

```java
String account = "0000123456-00001";
String campaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf";

campaignsV2Api.cancelCampaignAsync(account, campaignId).thenAccept(result -> {
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


# Update Campaign Dates

This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.

```java
CompletableFuture<ApiResponse<CampaignSoftware>> updateCampaignDatesAsync(
    final String account,
    final String campaignId,
    final V2ChangeCampaignDatesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `campaignId` | `String` | Template, Required | Software upgrade information. |
| `body` | [`V2ChangeCampaignDatesRequest`](../../doc/models/v2-change-campaign-dates-request.md) | Body, Required | New dates and time windows. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`CampaignSoftware`](../../doc/models/campaign-software.md).

## Example Usage

```java
String account = "0000123456-00001";
String campaignId = "60b5d639-ccdc-4db8-8824-069bd94c95bf";
V2ChangeCampaignDatesRequest body = new V2ChangeCampaignDatesRequest.Builder(
    DateTimeHelper.fromSimpleDate("2020-08-21"),
    DateTimeHelper.fromSimpleDate("2020-08-22")
)
.downloadAfterDate(DateTimeHelper.fromSimpleDate("2020-08-21"))
.downloadTimeWindowList(Arrays.asList(
        new V2TimeWindow.Builder(
            3,
            4
        )
        .build()
    ))
.installAfterDate(DateTimeHelper.fromSimpleDate("2020-08-21"))
.installTimeWindowList(Arrays.asList(
        new V2TimeWindow.Builder(
            5,
            6
        )
        .build()
    ))
.build();

campaignsV2Api.updateCampaignDatesAsync(account, campaignId, body).thenAccept(result -> {
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
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "startDate": "2020-08-21",
  "endDate": "2020-08-22",
  "downloadAfterDate": "2020-08-21",
  "downloadTimeWindowList": [
    {
      "startTime": 3,
      "endTime": 4
    },
    {
      "startTime": 5,
      "endTime": 6
    }
  ],
  "installAfterDate": "2020-08-21",
  "installTimeWindowList": [
    {
      "startTime": 5,
      "endTime": 6
    },
    {
      "startTime": 6,
      "endTime": 7
    }
  ],
  "status": "RequestPending"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Schedule File Upgrade

You can upload configuration files and schedule them in a campaign to devices.

```java
CompletableFuture<ApiResponse<UploadAndScheduleFileResponse>> scheduleFileUpgradeAsync(
    final String acc,
    final UploadAndScheduleFileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `body` | [`UploadAndScheduleFileRequest`](../../doc/models/upload-and-schedule-file-request.md) | Body, Required | Device logging information. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`UploadAndScheduleFileResponse`](../../doc/models/upload-and-schedule-file-response.md).

## Example Usage

```java
String acc = "0402196254-00001";
UploadAndScheduleFileRequest body = new UploadAndScheduleFileRequest.Builder()
    .campaignName("FOTA_Verizon_Upgrade")
    .fileName("configfile-Verizon_VZW1_hello-world.txt")
    .fileVersion("1.0")
    .distributionType("HTTP")
    .startDate("2021-02-08")
    .endDate("2021-02-08")
    .downloadAfterDate("2021-02-08")
    .build();

campaignsV2Api.scheduleFileUpgradeAsync(acc, body).thenAccept(result -> {
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
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Schedule SW Upgrade Http Devices

Campaign time windows for downloading and installing software are available as long as the device OEM supports this.

```java
CompletableFuture<ApiResponse<UploadAndScheduleFileResponse>> scheduleSwUpgradeHttpDevicesAsync(
    final String acc,
    final SchedulesSoftwareUpgradeRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `body` | [`SchedulesSoftwareUpgradeRequest`](../../doc/models/schedules-software-upgrade-request.md) | Body, Required | Device logging information. |

## Server

`Server.SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`UploadAndScheduleFileResponse`](../../doc/models/upload-and-schedule-file-response.md).

## Example Usage

```java
String acc = "0402196254-00001";
SchedulesSoftwareUpgradeRequest body = new SchedulesSoftwareUpgradeRequest.Builder()
    .campaignName("FOTA_Verizon_Upgrade")
    .softwareName("FOTA_Verizon_Model-A_02To03_HF")
    .softwareFrom("FOTA_Verizon_Model-A_00To01_HF")
    .softwareTo("FOTA_Verizon_Model-A_02To03_HF")
    .distributionType("HTTP")
    .startDate("2020-08-21")
    .endDate("2020-08-22")
    .downloadAfterDate("2020-08-21")
    .downloadTimeWindowList(Arrays.asList(
        new DownloadTimeWindow.Builder()
            .startTime("20")
            .endTime("21")
            .build()
    ))
    .installAfterDate("2020-08-21")
    .installTimeWindowList(Arrays.asList(
        new DownloadTimeWindow.Builder()
            .startTime("22")
            .endTime("23")
            .build()
    ))
    .deviceList(Arrays.asList(
        "990013907835573",
        "990013907884259"
    ))
    .build();

campaignsV2Api.scheduleSwUpgradeHttpDevicesAsync(acc, body).thenAccept(result -> {
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
  "id": "60b5d639-ccdc-4db8-8824-069bd94c95bf",
  "accountName": "0402196254-00001",
  "campaignName": "FOTA_Verizon_Upgrade",
  "softwareName": "FOTA_Verizon_Model-A_02To03_HF",
  "distributionType": "HTTP",
  "make": "Verizon",
  "model": "Model-A",
  "softwareFrom": "FOTA_Verizon_Model-A_00To01_HF",
  "softwareTo": "FOTA_Verizon_Model-A_02To03_HF",
  "startDate": "2020-08-21",
  "endDate": "2020-08-22",
  "downloadAfterDate": "2020-08-21",
  "downloadTimeWindowList": [
    {
      "startTime": "20",
      "endTime": "21"
    }
  ],
  "installAfterDate": "2020-08-21",
  "installTimeWindowList": [
    {
      "startTime": "22",
      "endTime": "23"
    }
  ],
  "status": "CampaignRequestPending"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

