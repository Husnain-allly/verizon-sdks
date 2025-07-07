# Campaigns V3

```java
CampaignsV3Api campaignsV3Api = client.getCampaignsV3Api();
```

## Class Name

`CampaignsV3Api`

## Methods

* [Schedule Campaign Firmware Upgrade](../../doc/controllers/campaigns-v3.md#schedule-campaign-firmware-upgrade)
* [Update Campaign Firmware Devices](../../doc/controllers/campaigns-v3.md#update-campaign-firmware-devices)
* [Update Campaign Dates](../../doc/controllers/campaigns-v3.md#update-campaign-dates)
* [Get Campaign Information](../../doc/controllers/campaigns-v3.md#get-campaign-information)
* [Cancel Campaign](../../doc/controllers/campaigns-v3.md#cancel-campaign)


# Schedule Campaign Firmware Upgrade

This endpoint allows a user to schedule a firmware upgrade for a list of devices.

```java
CompletableFuture<ApiResponse<FirmwareCampaign>> scheduleCampaignFirmwareUpgradeAsync(
    final String accountName,
    final CampaignFirmwareUpgrade body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Template, Required | Account identifier. |
| `body` | [`CampaignFirmwareUpgrade`](../../doc/models/campaign-firmware-upgrade.md) | Body, Required | Firmware upgrade information. |

## Server

`Server.SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`FirmwareCampaign`](../../doc/models/firmware-campaign.md).

## Example Usage

```java
String accountName = "0000123456-00001";
CampaignFirmwareUpgrade body = new CampaignFirmwareUpgrade.Builder(
    "SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657",
    "SR1.2.0.0-10512",
    "SR1.2.0.0-10657",
    "LWM2M",
    DateTimeHelper.fromSimpleDate("2021-09-29"),
    DateTimeHelper.fromSimpleDate("2021-10-01"),
    Arrays.asList(
        "15-digit IMEI"
    ),
    false,
    false
)
.campaignName("Smart FOTA - test 4")
.campaignTimeWindowList(Arrays.asList(
        new V3TimeWindow.Builder(
            18,
            22
        )
        .build()
    ))
.build();

campaignsV3Api.scheduleCampaignFirmwareUpgradeAsync(accountName, body).thenAccept(result -> {
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
  "id": "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
  "accountName": "0000123456-00001",
  "campaignName": "Smart FOTA - test 4",
  "firmwareName": "SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657",
  "protocol": "LWM2M",
  "firmwareFrom": "SR1.2.0.0-10512",
  "firmwareTo": "SR1.2.0.0-10657",
  "make": "SEQUANS Communications",
  "model": "GM01Q",
  "status": "CampaignRequestPending",
  "startDate": "2021-09-29",
  "endDate": "2021-10-01",
  "campaignTimeWindowList": [
    {
      "startTime": 18,
      "endTime": 22
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Update Campaign Firmware Devices

This endpoint allows user to Add or Remove devices to an existing campaign.

```java
CompletableFuture<ApiResponse<V3AddOrRemoveDeviceResult>> updateCampaignFirmwareDevicesAsync(
    final String acc,
    final String campaignId,
    final V3AddOrRemoveDeviceRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `campaignId` | `String` | Template, Required | Unique identifier of a campaign. |
| `body` | [`V3AddOrRemoveDeviceRequest`](../../doc/models/v3-add-or-remove-device-request.md) | Body, Required | Add or remove device to existing upgrade information. |

## Server

`Server.SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`V3AddOrRemoveDeviceResult`](../../doc/models/v3-add-or-remove-device-result.md).

## Example Usage

```java
String acc = "0000123456-00001";
String campaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652";
V3AddOrRemoveDeviceRequest body = new V3AddOrRemoveDeviceRequest.Builder(
    "remove",
    Arrays.asList(
        "15-digit IMEI"
    )
)
.build();

campaignsV3Api.updateCampaignFirmwareDevicesAsync(acc, campaignId, body).thenAccept(result -> {
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
  "campaignId": "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "status": "AddDeviceSucceed",
      "Reason": "Device added Successfully"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Update Campaign Dates

This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.

```java
CompletableFuture<ApiResponse<FirmwareCampaign>> updateCampaignDatesAsync(
    final String acc,
    final String campaignId,
    final V3ChangeCampaignDatesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `campaignId` | `String` | Template, Required | Firmware upgrade information. |
| `body` | [`V3ChangeCampaignDatesRequest`](../../doc/models/v3-change-campaign-dates-request.md) | Body, Required | New dates and time windows. |

## Server

`Server.SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`FirmwareCampaign`](../../doc/models/firmware-campaign.md).

## Example Usage

```java
String acc = "0000123456-00001";
String campaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652";
V3ChangeCampaignDatesRequest body = new V3ChangeCampaignDatesRequest.Builder(
    DateTimeHelper.fromSimpleDate("2022-02-23"),
    DateTimeHelper.fromSimpleDate("2022-02-24")
)
.campaignTimeWindowList(Arrays.asList(
        new V3TimeWindow.Builder(
            14,
            18
        )
        .build()
    ))
.build();

campaignsV3Api.updateCampaignDatesAsync(acc, campaignId, body).thenAccept(result -> {
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
  "id": "4e03b882-936a-11ec-931f-76f56843c393",
  "accountName": "0000123456-00001",
  "campaignName": "modify-campaign-test-1",
  "firmwareName": "NordicSemiconductorASA_nRF9160_ee58ac77-f1fd-4960-8dc4-4d32e118a6d4_4325d595-7b69-4474-ba39-9c177930aac3",
  "protocol": "LWM2M",
  "firmwareFrom": "ee58ac77-f1fd-4960-8dc4-4d32e118a6d4",
  "firmwareTo": "4325d595-7b69-4474-ba39-9c177930aac3",
  "make": "Nordic Semiconductor ASA",
  "model": "nRF9160",
  "status": "CampaignRequestQueued",
  "startDate": "2022-02-23",
  "endDate": "2022-02-24",
  "campaignTimeWindowList": [
    {
      "startTime": 14,
      "endTime": 18
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Get Campaign Information

This endpoint allows the user to retrieve campaign level information for a specified campaign.

```java
CompletableFuture<ApiResponse<Campaign>> getCampaignInformationAsync(
    final String accountName,
    final String campaignId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Template, Required | Account identifier. |
| `campaignId` | `String` | Template, Required | Firmware upgrade identifier. |

## Server

`Server.SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`Campaign`](../../doc/models/campaign.md).

## Example Usage

```java
String accountName = "0000123456-00001";
String campaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652";

campaignsV3Api.getCampaignInformationAsync(accountName, campaignId).thenAccept(result -> {
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
  "id": "f858b8c4-2153-11ec-8c44-aeb16d1aa652",
  "accountName": "0642233522-00001",
  "campaignName": "Smart FOTA - test 4",
  "protocol": "LWM2M",
  "make": "SEQUANS Communications",
  "model": "GM01Q",
  "status": "CampaignPreScheduled",
  "startDate": "2021-09-29",
  "endDate": "2021-10-01",
  "firmwareName": "SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657",
  "firmwareFrom": "SR1.2.0.0-10512",
  "firmwareTo": "SR1.2.0.0-10657",
  "campaignTimeWindowList": [
    {
      "startTime": 18,
      "endTime": 22
    }
  ],
  "autoAssignLicenseFlag": false,
  "autoAddDevicesFlag": false
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# Cancel Campaign

This endpoint allows user to cancel a firmware campaign. A firmware campaign already started can not be cancelled.

```java
CompletableFuture<ApiResponse<FotaV3SuccessResult>> cancelCampaignAsync(
    final String accountName,
    final String campaignId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Template, Required | Account identifier. |
| `campaignId` | `String` | Template, Required | Firmware upgrade information. |

## Server

`Server.SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`FotaV3SuccessResult`](../../doc/models/fota-v3-success-result.md).

## Example Usage

```java
String accountName = "0000123456-00001";
String campaignId = "f858b8c4-2153-11ec-8c44-aeb16d1aa652";

campaignsV3Api.cancelCampaignAsync(accountName, campaignId).thenAccept(result -> {
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

