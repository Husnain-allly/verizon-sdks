# Device Actions

```ruby
device_actions_api = client.device_actions
```

## Class Name

`DeviceActionsApi`

## Methods

* [Aggregate Usage](../../doc/controllers/device-actions.md#aggregate-usage)
* [Daily Usage](../../doc/controllers/device-actions.md#daily-usage)
* [Service Plan List](../../doc/controllers/device-actions.md#service-plan-list)
* [Account Information](../../doc/controllers/device-actions.md#account-information)
* [Retrieve the Global Device List](../../doc/controllers/device-actions.md#retrieve-the-global-device-list)
* [Retrieve Device Provisioning History](../../doc/controllers/device-actions.md#retrieve-device-provisioning-history)
* [Get Asynchronous Request Status](../../doc/controllers/device-actions.md#get-asynchronous-request-status)


# Aggregate Usage

Retrieve the aggregate usage for a device or a number of devices.

```ruby
def aggregate_usage(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AggregateUsage`](../../doc/models/aggregate-usage.md) | Body, Required | - |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```ruby
body = AggregateUsage.new

result = device_actions_api.aggregate_usage(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Daily Usage

Retrieve the daily usage for a device, for a specified period of time, segmented by day

```ruby
def daily_usage(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DailyUsage`](../../doc/models/daily-usage.md) | Body, Required | - |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DailyUsageResponse`](../../doc/models/daily-usage-response.md).

## Example Usage

```ruby
body = DailyUsage.new

result = device_actions_api.daily_usage(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Service Plan List

Retrieve all of the service plans, features and carriers associated with the account specified.

```ruby
def service_plan_list(account_name)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`AccountDetails`](../../doc/models/account-details.md).

## Example Usage

```ruby
account_name = 'accountName4'

result = device_actions_api.service_plan_list(account_name)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Account Information

Retrieve all of the service plans, features and carriers associated with the account specified.

```ruby
def account_information(account_name)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`AccountDetails`](../../doc/models/account-details.md).

## Example Usage

```ruby
account_name = 'accountName4'

result = device_actions_api.account_information(account_name)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Retrieve the Global Device List

Allows the profile to fetch the complete device list. This works with Verizon US and Global profiles.

```ruby
def retrieve_the_global_device_list(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDeviceListWithProfilesRequest`](../../doc/models/get-device-list-with-profiles-request.md) | Body, Required | Device Profile Query |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```ruby
body = GetDeviceListWithProfilesRequest.new(
  account_name: '0000123456-00001',
  provisioning_status_filter: 'ACTIVE',
  profile_status_filter: 'UNKNOWN'
)

result = device_actions_api.retrieve_the_global_device_list(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Retrieve Device Provisioning History

Retrieve the provisioning history of a specific device or devices.

```ruby
def retrieve_device_provisioning_history(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProvhistoryRequest`](../../doc/models/provhistory-request.md) | Body, Required | Device Provisioning History |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```ruby
body = ProvhistoryRequest.new(
  account_name: '0000123456-00001',
  earliest: DateTimeHelper.from_rfc3339('10/15/2021 04:49:35'),
  latest: DateTimeHelper.from_rfc3339('10/15/2021 04:49:49')
)

result = device_actions_api.retrieve_device_provisioning_history(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Get Asynchronous Request Status

Get the status of an asynchronous request made with the Device Actions.

```ruby
def get_asynchronous_request_status(account_name,
                                    request_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9\-]{3,32}$` |
| `request_id` | `String` | Template, Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9\-]{3,64}$` |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`StatusResponse`](../../doc/models/status-response.md).

## Example Usage

```ruby
account_name = '0000123456-00001'

request_id = 'd1f08526-5443-4054-9a29-4456490ea9f8'

result = device_actions_api.get_asynchronous_request_status(
  account_name,
  request_id
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
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |

