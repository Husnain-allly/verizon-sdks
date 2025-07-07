# Exclusions

Exclude devices from location services.

```ruby
exclusions_api = client.exclusions
```

## Class Name

`ExclusionsApi`

## Methods

* [Devices Location Get Consent Async](../../doc/controllers/exclusions.md#devices-location-get-consent-async)
* [Devices Location Give Consent Async](../../doc/controllers/exclusions.md#devices-location-give-consent-async)
* [Devices Location Update Consent](../../doc/controllers/exclusions.md#devices-location-update-consent)
* [Exclude Devices](../../doc/controllers/exclusions.md#exclude-devices)
* [Remove Devices From Exclusion List](../../doc/controllers/exclusions.md#remove-devices-from-exclusion-list)
* [List Excluded Devices](../../doc/controllers/exclusions.md#list-excluded-devices)


# Devices Location Get Consent Async

Get the consent settings for the entire account or device list in an account.

```ruby
def devices_location_get_consent_async(account_name,
                                       device_id: nil)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Query, Required | The numeric name of the account. |
| `device_id` | `String` | Query, Optional | The IMEI of the device being queried |

## Server

`Server::DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`GetAccountDeviceConsent`](../../doc/models/get-account-device-consent.md).

## Example Usage

```ruby
account_name = '0000123456-00001'

device_id = '900000000000009'

result = exclusions_api.devices_location_get_consent_async(
  account_name,
  device_id: device_id
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
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Devices Location Give Consent Async

Create a consent record to use location services as an asynchronous request.

```ruby
def devices_location_give_consent_async(body: nil)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AccountConsentCreate`](../../doc/models/account-consent-create.md) | Body, Optional | Account details to create a consent record. |

## Server

`Server::DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`ConsentTransactionId`](../../doc/models/consent-transaction-id.md).

## Example Usage

```ruby
body = AccountConsentCreate.new(
  account_name: '0000123456-00001'
)

result = exclusions_api.devices_location_give_consent_async(body: body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Devices Location Update Consent

Update the location services consent record for an entire account.

```ruby
def devices_location_update_consent(body: nil)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AccountConsentUpdate`](../../doc/models/account-consent-update.md) | Body, Optional | Account details to update a consent record. |

## Server

`Server::DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`ConsentTransactionId`](../../doc/models/consent-transaction-id.md).

## Example Usage

```ruby
body = AccountConsentUpdate.new(
  account_name: '0000123456-00001',
  all_device_consent: 0
)

result = exclusions_api.devices_location_update_consent(body: body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Exclude Devices

This consents endpoint sets a new exclusion list.

```ruby
def exclude_devices(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ConsentRequest`](../../doc/models/consent-request.md) | Body, Required | Request to update account consent exclusion list. |

## Server

`Server::DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DeviceLocationSuccessResult`](../../doc/models/device-location-success-result.md).

## Example Usage

```ruby
body = ConsentRequest.new(
  account_name: '1234567890-00001',
  all_device: false,
  type: 'replace',
  exclusion: [
    '980003420535573',
    '375535024300089',
    'A100003861E585'
  ]
)

result = exclusions_api.exclude_devices(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Remove Devices From Exclusion List

Removes devices from the exclusion list so that they can be located with Device Location Services requests.

```ruby
def remove_devices_from_exclusion_list(account_name,
                                       device_list)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Query, Required | The numeric name of the account. |
| `device_list` | `String` | Query, Required | A list of the device IDs to remove from the exclusion list. |

## Server

`Server::DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DeviceLocationSuccessResult`](../../doc/models/device-location-success-result.md).

## Example Usage

```ruby
account_name = '0000123456-00001'

device_list = 'IMEI'

result = exclusions_api.remove_devices_from_exclusion_list(
  account_name,
  device_list
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
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# List Excluded Devices

This consents endpoint retrieves a list of excluded devices in an account.

```ruby
def list_excluded_devices(account_name,
                          start_index)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | Account identifier in "##########-#####". |
| `start_index` | `String` | Template, Required | Zero-based number of the first record to return. |

## Server

`Server::DEVICE_LOCATION`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DevicesConsentResult`](../../doc/models/devices-consent-result.md).

## Example Usage

```ruby
account_name = '0252012345-00001'

start_index = '0'

result = exclusions_api.list_excluded_devices(
  account_name,
  start_index
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
  "accountName": "2024009649-00001",
  "allDevice": false,
  "hasMoreData": false,
  "totalCount": 4,
  "updateTime": "2018-05-18 19:20:50.076 +0000 UTC",
  "exclusion": [
    "990003420535375",
    "420535399000375",
    "A100003861E585",
    "205353759900034"
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

