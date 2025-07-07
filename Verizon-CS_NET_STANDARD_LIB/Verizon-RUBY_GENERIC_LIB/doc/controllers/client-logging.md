# Client Logging

```ruby
client_logging_api = client.client_logging
```

## Class Name

`ClientLoggingApi`

## Methods

* [List Devices With Logging Enabled](../../doc/controllers/client-logging.md#list-devices-with-logging-enabled)
* [Enable Logging for Devices](../../doc/controllers/client-logging.md#enable-logging-for-devices)
* [Disable Logging for Devices](../../doc/controllers/client-logging.md#disable-logging-for-devices)
* [Enable Device Logging](../../doc/controllers/client-logging.md#enable-device-logging)
* [Disable Device Logging](../../doc/controllers/client-logging.md#disable-device-logging)
* [List Device Logs](../../doc/controllers/client-logging.md#list-device-logs)


# List Devices With Logging Enabled

Returns an array of all devices in the specified account for which logging is enabled.

```ruby
def list_devices_with_logging_enabled(account)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`Array<DeviceLoggingStatus>`](../../doc/models/device-logging-status.md).

## Example Usage

```ruby
account = '0000123456-00001'

result = client_logging_api.list_devices_with_logging_enabled(account)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
[
  {
    "deviceId": "990013907835573",
    "expiryDate": "2020-10-19"
  },
  {
    "deviceId": "991124018926684",
    "expiryDate": "2020-10-19"
  },
  {
    "deviceId": "992234129057795",
    "expiryDate": "2020-10-23"
  },
  {
    "deviceId": "998891785613351",
    "expiryDate": "2020-10-23"
  },
  {
    "deviceId": "990013907835573",
    "expiryDate": "2020-10-23"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Enable Logging for Devices

Each customer may have a maximum of 20 devices enabled for logging.

```ruby
def enable_logging_for_devices(account,
                               body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `body` | [`DeviceLoggingRequest`](../../doc/models/device-logging-request.md) | Body, Required | Device logging information. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`Array<DeviceLoggingStatus>`](../../doc/models/device-logging-status.md).

## Example Usage

```ruby
account = '0000123456-00001'

body = DeviceLoggingRequest.new(
  device_ids: [
    '990013907835573',
    '991124018926684',
    '992234129057795',
    '998891785613351',
    '990013907835573'
  ]
)

result = client_logging_api.enable_logging_for_devices(
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
[
  {
    "deviceId": "990013907835573",
    "expiryDate": "2020-10-19"
  },
  {
    "deviceId": "991124018926684",
    "expiryDate": "2020-10-19"
  },
  {
    "deviceId": "992234129057795",
    "expiryDate": "2020-10-23"
  },
  {
    "deviceId": "998891785613351",
    "expiryDate": "2020-10-23"
  },
  {
    "deviceId": "990013907835573",
    "expiryDate": "2020-10-23"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Disable Logging for Devices

Turn logging off for a list of devices.

```ruby
def disable_logging_for_devices(account,
                                device_ids)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `device_ids` | `String` | Query, Required | The list of device IDs. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ruby
account = '0000123456-00001'

device_ids = '990013907835573'

result = client_logging_api.disable_logging_for_devices(
  account,
  device_ids
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


# Enable Device Logging

Enables logging for a specific device.

```ruby
def enable_device_logging(account,
                          device_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `device_id` | `String` | Template, Required | Device IMEI identifier. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DeviceLoggingStatus`](../../doc/models/device-logging-status.md).

## Example Usage

```ruby
account = '0000123456-00001'

device_id = '990013907835573'

result = client_logging_api.enable_device_logging(
  account,
  device_id
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
  "deviceId": "990013907835573",
  "expiryDate": "2020-10-19"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |


# Disable Device Logging

Disables logging for a specific device.

```ruby
def disable_device_logging(account,
                           device_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `device_id` | `String` | Template, Required | Device IMEI identifier. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ruby
account = '0000123456-00001'

device_id = '990013907835573'

result = client_logging_api.disable_device_logging(
  account,
  device_id
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


# List Device Logs

Gets logs for a specific device.

```ruby
def list_device_logs(account,
                     device_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `String` | Template, Required | Account identifier. |
| `device_id` | `String` | Template, Required | Device IMEI identifier. |

## Server

`Server::SOFTWARE_MANAGEMENT_V2`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`Array<DeviceLog>`](../../doc/models/device-log.md).

## Example Usage

```ruby
account = '0000123456-00001'

device_id = '990013907835573'

result = client_logging_api.list_device_logs(
  account,
  device_id
)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
[
  {
    "deviceId": "990013907835573",
    "logTime": "2020-10-22T19:29:50.901Z",
    "logType": "string",
    "eventLog": "string",
    "binaryLogFileBase64": "string",
    "binaryLogFilename": "string"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV2ResultException`](../../doc/models/fota-v2-result-exception.md) |

