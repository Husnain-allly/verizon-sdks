# Devices Locations

```ruby
devices_locations_api = client.devices_locations
```

## Class Name

`DevicesLocationsApi`

## Methods

* [List Devices Locations Synchronous](../../doc/controllers/devices-locations.md#list-devices-locations-synchronous)
* [List Devices Locations Asynchronous](../../doc/controllers/devices-locations.md#list-devices-locations-asynchronous)
* [Create Location Report](../../doc/controllers/devices-locations.md#create-location-report)
* [Retrieve Location Report](../../doc/controllers/devices-locations.md#retrieve-location-report)
* [Get Location Report Status](../../doc/controllers/devices-locations.md#get-location-report-status)
* [Cancel Queued Location Report Generation](../../doc/controllers/devices-locations.md#cancel-queued-location-report-generation)


# List Devices Locations Synchronous

This locations endpoint retrieves the locations for a list of devices.

```ruby
def list_devices_locations_synchronous(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LocationRequest`](../../doc/models/location-request.md) | Body, Required | Request to obtain location of devices. |

## Server

`Server::DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`Array<Location>`](../../doc/models/location.md).

## Example Usage

```ruby
body = LocationRequest.new(
  account_name: '1234567890-00001',
  device_list: [
    DeviceInfo.new(
      id: '980003420535573',
      kind: 'imei',
      mdn: '7892345678'
    ),
    DeviceInfo.new(
      id: '375535024300089',
      kind: 'imei',
      mdn: '7897654321'
    )
  ],
  accuracy_mode: AccuracyMode::ENUM_0,
  cache_mode: CacheMode::ENUM_1
)

result = devices_locations_api.list_devices_locations_synchronous(body)

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
    "msid": "7892345678",
    "pd": {
      "time": "20170520004421",
      "x": "33.45324",
      "y": "-84.59621",
      "radius": "5571",
      "qos": false
    },
    "error": {}
  },
  {
    "msid": "8583239709",
    "pd": {
      "time": "20170525214342",
      "x": "38.8408694",
      "y": "-105.0422583",
      "radius": "3866",
      "qos": false
    },
    "error": {}
  },
  {
    "msid": "7897654321",
    "pd": {},
    "error": {
      "time": "20170525214342",
      "type": "POSITION METHOD FAILURE",
      "info": "Exception code=ABSENT SUBSCRIBER"
    }
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# List Devices Locations Asynchronous

Requests the current or cached location of up to 10,000 IoT or consumer devices (phones, tablets. etc.). This request returns a synchronous transaction ID, and the location information for each device is returned asynchronously as a DeviceLocation callback message.

```ruby
def list_devices_locations_asynchronous(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LocationRequest`](../../doc/models/location-request.md) | Body, Required | An asynchronous request to obtain locations of devices. |

## Server

`Server::DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`SynchronousLocationRequestResult`](../../doc/models/synchronous-location-request-result.md).

## Example Usage

```ruby
body = LocationRequest.new(
  account_name: '2234434445-32333',
  device_list: [
    DeviceInfo.new(
      id: '354677790348290',
      kind: 'imei',
      mdn: '5557337468'
    )
  ],
  accuracy_mode: AccuracyMode::ENUM_0,
  cache_mode: CacheMode::ENUM_2
)

result = devices_locations_api.list_devices_locations_asynchronous(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "txid": "4be7c858-eeee-ffff-gggg-95061456d835",
  "status": "QUEUED"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Create Location Report

Request an asynchronous device location report.

```ruby
def create_location_report(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`LocationRequest`](../../doc/models/location-request.md) | Body, Required | Request for device location report. |

## Server

`Server::DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`AsynchronousLocationRequestResult`](../../doc/models/asynchronous-location-request-result.md).

## Example Usage

```ruby
body = LocationRequest.new(
  account_name: '1234567890-00001',
  device_list: [
    DeviceInfo.new(
      id: '980003420535573',
      kind: 'imei',
      mdn: '7892345678'
    ),
    DeviceInfo.new(
      id: '375535024300089',
      kind: 'imei',
      mdn: '7897654321'
    ),
    DeviceInfo.new(
      id: 'A100003861E585',
      kind: 'meid',
      mdn: '7897650914'
    )
  ],
  accuracy_mode: AccuracyMode::ENUM_0,
  cache_mode: CacheMode::ENUM_1
)

result = devices_locations_api.create_location_report(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "status": "QUEUED"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Retrieve Location Report

Download a completed asynchronous device location report.

```ruby
def retrieve_location_report(account_name,
                             txid,
                             startindex)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | Account identifier in "##########-#####". |
| `txid` | `String` | Template, Required | Transaction ID from POST /locationreports response. |
| `startindex` | `Integer` | Template, Required | Zero-based number of the first record to return. |

## Server

`Server::DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`LocationReport`](../../doc/models/location-report.md).

## Example Usage

```ruby
account_name = '0000123456-00001'

txid = '2017-12-11Te8b47da2-eeee-ffff-gggg-61815e1e97e9'

startindex = 0

result = devices_locations_api.retrieve_location_report(
  account_name,
  txid,
  startindex
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
  "startIndex": "0",
  "txid": "2017-12-11Te8b47da2-eeee-ffff-gggg-61815e1e97e9",
  "totalCount": 3,
  "hasMoreData": false,
  "devLocationList": [
    {
      "error": {},
      "msid": "7892345678",
      "pd": {
        "qos": false,
        "radius": "5571",
        "time": "20170520004421",
        "x": "33.45324",
        "y": "-84.59621"
      }
    },
    {
      "error": {},
      "msid": "8583239709",
      "pd": {
        "qos": false,
        "radius": "3866",
        "time": "20170525214342",
        "x": "38.8408694",
        "y": "-105.0422583"
      }
    },
    {
      "error": {
        "time": "20170525214342",
        "type": "POSITION METHOD FAILURE",
        "info": "Exception code=ABSENT SUBSCRIBER"
      },
      "msid": "7897654321",
      "pd": {}
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Get Location Report Status

Returns the current status of a requested device location report.

```ruby
def get_location_report_status(account_name,
                               txid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | Account identifier in "##########-#####". |
| `txid` | `String` | Template, Required | Transaction ID of the report. |

## Server

`Server::DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`LocationReportStatus`](../../doc/models/location-report-status.md).

## Example Usage

```ruby
account_name = '0252012345-00001'

txid = '2c90bd28-eeee-ffff-gggg-7e3bd4fbff33'

result = devices_locations_api.get_location_report_status(
  account_name,
  txid
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
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33",
  "status": "INPROGRESS"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Cancel Queued Location Report Generation

Cancel a queued device location report.

```ruby
def cancel_queued_location_report_generation(account_name,
                                             txid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | Account identifier in "##########-#####". |
| `txid` | `String` | Template, Required | Transaction ID of the report to cancel. |

## Server

`Server::DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`TransactionId`](../../doc/models/transaction-id.md).

## Example Usage

```ruby
account_name = '0252012345-00001'

txid = '2c90bd28-eeee-ffff-gggg-7e3bd4fbff33'

result = devices_locations_api.cancel_queued_location_report_generation(
  account_name,
  txid
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
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

