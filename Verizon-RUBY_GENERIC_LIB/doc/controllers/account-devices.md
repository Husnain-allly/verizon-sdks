# Account Devices

```ruby
account_devices_api = client.account_devices
```

## Class Name

`AccountDevicesApi`

## Methods

* [Get Account Device Information](../../doc/controllers/account-devices.md#get-account-device-information)
* [List Account Devices Information](../../doc/controllers/account-devices.md#list-account-devices-information)


# Get Account Device Information

Retrieve account device information such as reported firmware on the devices.

```ruby
def get_account_device_information(acc,
                                   last_seen_device_id: nil,
                                   protocol: DevicesProtocol::LW_M2M)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `last_seen_device_id` | `String` | Query, Optional | Last seen device identifier. |
| `protocol` | [`DevicesProtocol`](../../doc/models/devices-protocol.md) | Query, Optional | Filter to retrieve a specific protocol type used.<br><br>**Default**: `DevicesProtocol::LW_M2M` |

## Server

`Server::SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`V3AccountDeviceList`](../../doc/models/v3-account-device-list.md).

## Example Usage

```ruby
acc = '0000123456-00001'

last_seen_device_id = '0'

protocol = DevicesProtocol::LW_M2M

result = account_devices_api.get_account_device_information(
  acc,
  last_seen_device_id: last_seen_device_id,
  protocol: protocol
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
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# List Account Devices Information

Retrieve device information for a list of devices on an account.

```ruby
def list_account_devices_information(acc,
                                     body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `String` | Template, Required | Account identifier. |
| `body` | [`DeviceImei`](../../doc/models/device-imei.md) | Body, Required | Request device list information. |

## Server

`Server::SOFTWARE_MANAGEMENT_V3`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DeviceListResult`](../../doc/models/device-list-result.md).

## Example Usage

```ruby
acc = '0000123456-00001'

body = DeviceImei.new(
  device_list: [
    '15-digit IMEI'
  ]
)

result = account_devices_api.list_account_devices_information(
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
  "accountName": "0000123456-00001",
  "deviceCount": 1,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "GM01Q",
      "make": "SEQUANS COMMUNICATIONS",
      "firmware": "SR1.2.0.0-10657",
      "fotaEligible": true,
      "licenseAssigned": true,
      "status": "Active",
      "protocol": "LWM2M",
      "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "statusTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "lastConnectionTime": "2012-04-23T18:25:43.511Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

