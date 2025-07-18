# Campaigns V2

```ruby
campaigns_v2_api = client.campaigns_v2
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

```ruby
def schedule_campaign_firmware_upgrade(account,
                                       body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `body` | [`CampaignSoftwareUpgrade`](../../doc/models/campaign-software-upgrade.md) | Body, Required | Software upgrade information. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`CampaignSoftware`](../../doc/models/campaign-software.md).

## Example Usage

```ruby
account = '0000123456-00001'

body = CampaignSoftwareUpgrade.new(
  software_name: 'FOTA_Verizon_Model-A_02To03_HF',
  software_from: 'FOTA_Verizon_Model-A_00To01_HF',
  software_to: 'FOTA_Verizon_Model-A_02To03_HF',
  distribution_type: 'HTTP',
  start_date: Date.iso8601('2020-08-21'),
  end_date: Date.iso8601('2020-08-22'),
  device_list: [
    '990013907835573',
    '990013907884259'
  ],
  campaign_name: 'FOTA_Verizon_Upgrade',
  download_after_date: Date.iso8601('2020-08-21'),
  download_time_window_list: [
    V2TimeWindow.new(
      start_time: 20,
      end_time: 21
    )
  ],
  install_after_date: Date.iso8601('2020-08-21'),
  install_time_window_list: [
    V2TimeWindow.new(
      start_time: 22,
      end_time: 23
    )
  ]
)

result = campaigns_v2_api.schedule_campaign_firmware_upgrade(
  account,
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

```ruby
def get_campaign_information(account,
                             campaign_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `campaign_id` | `String` | Template, Required | Software upgrade identifier. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`CampaignSoftware`](../../doc/models/campaign-software.md).

## Example Usage

```ruby
account = '0000123456-00001'

campaign_id = '60b5d639-ccdc-4db8-8824-069bd94c95bf'

result = campaigns_v2_api.get_campaign_information(
  account,
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

```ruby
def update_campaign_firmware_devices(account,
                                     campaign_id,
                                     body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `campaign_id` | `String` | Template, Required | Software upgrade information. |
| `body` | [`V2AddOrRemoveDeviceRequest`](../../doc/models/v2-add-or-remove-device-request.md) | Body, Required | Request to add or remove device to existing software upgrade information. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`V2AddOrRemoveDeviceResult`](../../doc/models/v2-add-or-remove-device-result.md).

## Example Usage

```ruby
account = '0000123456-00001'

campaign_id = '60b5d639-ccdc-4db8-8824-069bd94c95bf'

body = V2AddOrRemoveDeviceRequest.new(
  type: 'remove',
  device_list: [
    '990013907884259',
    '990013907835573',
    '990013907833575'
  ]
)

result = campaigns_v2_api.update_campaign_firmware_devices(
  account,
  campaign_id,
  body
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Cancel Campaign

This endpoint allows user to cancel software upgrade. A software upgrade already started can not be cancelled.

```ruby
def cancel_campaign(account,
                    campaign_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `campaign_id` | `String` | Template, Required | Unique identifier of campaign. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`FotaV2SuccessResult`](../../doc/models/fota-v2-success-result.md).

## Example Usage

```ruby
account = '0000123456-00001'

campaign_id = '60b5d639-ccdc-4db8-8824-069bd94c95bf'

result = campaigns_v2_api.cancel_campaign(
  account,
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
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Update Campaign Dates

This endpoint allows user to change campaign dates and time windows. Fields which need to remain unchanged should be also provided.

```ruby
def update_campaign_dates(account,
                          campaign_id,
                          body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `campaign_id` | `String` | Template, Required | Software upgrade information. |
| `body` | [`V2ChangeCampaignDatesRequest`](../../doc/models/v2-change-campaign-dates-request.md) | Body, Required | New dates and time windows. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`CampaignSoftware`](../../doc/models/campaign-software.md).

## Example Usage

```ruby
account = '0000123456-00001'

campaign_id = '60b5d639-ccdc-4db8-8824-069bd94c95bf'

body = V2ChangeCampaignDatesRequest.new(
  start_date: Date.iso8601('2020-08-21'),
  end_date: Date.iso8601('2020-08-22'),
  download_after_date: Date.iso8601('2020-08-21'),
  download_time_window_list: [
    V2TimeWindow.new(
      start_time: 3,
      end_time: 4
    )
  ],
  install_after_date: Date.iso8601('2020-08-21'),
  install_time_window_list: [
    V2TimeWindow.new(
      start_time: 5,
      end_time: 6
    )
  ]
)

result = campaigns_v2_api.update_campaign_dates(
  account,
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

```ruby
def schedule_file_upgrade(acc,
                          body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `body` | [`UploadAndScheduleFileRequest`](../../doc/models/upload-and-schedule-file-request.md) | Body, Required | Device logging information. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`UploadAndScheduleFileResponse`](../../doc/models/upload-and-schedule-file-response.md).

## Example Usage

```ruby
acc = '0402196254-00001'

body = UploadAndScheduleFileRequest.new(
  campaign_name: 'FOTA_Verizon_Upgrade',
  file_name: 'configfile-Verizon_VZW1_hello-world.txt',
  file_version: '1.0',
  distribution_type: 'HTTP',
  start_date: '2021-02-08',
  end_date: '2021-02-08',
  download_after_date: '2021-02-08'
)

result = campaigns_v2_api.schedule_file_upgrade(
  acc,
  body
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Schedule SW Upgrade Http Devices

Campaign time windows for downloading and installing software are available as long as the device OEM supports this.

```ruby
def schedule_sw_upgrade_http_devices(acc,
                                     body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `body` | [`SchedulesSoftwareUpgradeRequest`](../../doc/models/schedules-software-upgrade-request.md) | Body, Required | Device logging information. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`UploadAndScheduleFileResponse`](../../doc/models/upload-and-schedule-file-response.md).

## Example Usage

```ruby
acc = '0402196254-00001'

body = SchedulesSoftwareUpgradeRequest.new(
  campaign_name: 'FOTA_Verizon_Upgrade',
  software_name: 'FOTA_Verizon_Model-A_02To03_HF',
  software_from: 'FOTA_Verizon_Model-A_00To01_HF',
  software_to: 'FOTA_Verizon_Model-A_02To03_HF',
  distribution_type: 'HTTP',
  start_date: '2020-08-21',
  end_date: '2020-08-22',
  download_after_date: '2020-08-21',
  download_time_window_list: [
    DownloadTimeWindow.new(
      start_time: '20',
      end_time: '21'
    )
  ],
  install_after_date: '2020-08-21',
  install_time_window_list: [
    DownloadTimeWindow.new(
      start_time: '22',
      end_time: '23'
    )
  ],
  device_list: [
    '990013907835573',
    '990013907884259'
  ]
)

result = campaigns_v2_api.schedule_sw_upgrade_http_devices(
  acc,
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

