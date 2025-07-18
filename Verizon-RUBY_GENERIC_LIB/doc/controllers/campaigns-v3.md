# Campaigns V3

```ruby
campaigns_v3_api = client.campaigns_v3
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

```ruby
def schedule_campaign_firmware_upgrade(account_name,
                                       body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | Account identifier. |
| `body` | [`CampaignFirmwareUpgrade`](../../doc/models/campaign-firmware-upgrade.md) | Body, Required | Firmware upgrade information. |

## Server

`Server::SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`FirmwareCampaign`](../../doc/models/firmware-campaign.md).

## Example Usage

```ruby
account_name = '0000123456-00001'

body = CampaignFirmwareUpgrade.new(
  firmware_name: 'SEQUANSCommunications_GM01Q_SR1.2.0.0-10512_SR1.2.0.0-10657',
  firmware_from: 'SR1.2.0.0-10512',
  firmware_to: 'SR1.2.0.0-10657',
  protocol: 'LWM2M',
  start_date: Date.iso8601('2021-09-29'),
  end_date: Date.iso8601('2021-10-01'),
  device_list: [
    '15-digit IMEI'
  ],
  auto_assign_license_flag: false,
  auto_add_devices_flag: false,
  campaign_name: 'Smart FOTA - test 4',
  campaign_time_window_list: [
    V3TimeWindow.new(
      start_time: 18,
      end_time: 22
    )
  ]
)

result = campaigns_v3_api.schedule_campaign_firmware_upgrade(
  account_name,
  body
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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

```ruby
def update_campaign_firmware_devices(acc,
                                     campaign_id,
                                     body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `campaign_id` | `String` | Template, Required | Unique identifier of a campaign. |
| `body` | [`V3AddOrRemoveDeviceRequest`](../../doc/models/v3-add-or-remove-device-request.md) | Body, Required | Add or remove device to existing upgrade information. |

## Server

`Server::SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`V3AddOrRemoveDeviceResult`](../../doc/models/v3-add-or-remove-device-result.md).

## Example Usage

```ruby
acc = '0000123456-00001'

campaign_id = 'f858b8c4-2153-11ec-8c44-aeb16d1aa652'

body = V3AddOrRemoveDeviceRequest.new(
  type: 'remove',
  device_list: [
    '15-digit IMEI'
  ]
)

result = campaigns_v3_api.update_campaign_firmware_devices(
  acc,
  campaign_id,
  body
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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

```ruby
def update_campaign_dates(acc,
                          campaign_id,
                          body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `campaign_id` | `String` | Template, Required | Firmware upgrade information. |
| `body` | [`V3ChangeCampaignDatesRequest`](../../doc/models/v3-change-campaign-dates-request.md) | Body, Required | New dates and time windows. |

## Server

`Server::SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`FirmwareCampaign`](../../doc/models/firmware-campaign.md).

## Example Usage

```ruby
acc = '0000123456-00001'

campaign_id = 'f858b8c4-2153-11ec-8c44-aeb16d1aa652'

body = V3ChangeCampaignDatesRequest.new(
  start_date: Date.iso8601('2022-02-23'),
  end_date: Date.iso8601('2022-02-24'),
  campaign_time_window_list: [
    V3TimeWindow.new(
      start_time: 14,
      end_time: 18
    )
  ]
)

result = campaigns_v3_api.update_campaign_dates(
  acc,
  campaign_id,
  body
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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

```ruby
def get_campaign_information(account_name,
                             campaign_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | Account identifier. |
| `campaign_id` | `String` | Template, Required | Firmware upgrade identifier. |

## Server

`Server::SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`Campaign`](../../doc/models/campaign.md).

## Example Usage

```ruby
account_name = '0000123456-00001'

campaign_id = 'f858b8c4-2153-11ec-8c44-aeb16d1aa652'

result = campaigns_v3_api.get_campaign_information(
  account_name,
  campaign_id
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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

```ruby
def cancel_campaign(account_name,
                    campaign_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | Account identifier. |
| `campaign_id` | `String` | Template, Required | Firmware upgrade information. |

## Server

`Server::SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`FotaV3SuccessResult`](../../doc/models/fota-v3-success-result.md).

## Example Usage

```ruby
account_name = '0000123456-00001'

campaign_id = 'f858b8c4-2153-11ec-8c44-aeb16d1aa652'

result = campaigns_v3_api.cancel_campaign(
  account_name,
  campaign_id
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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

