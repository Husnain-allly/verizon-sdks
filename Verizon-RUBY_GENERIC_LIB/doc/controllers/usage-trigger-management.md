# Usage Trigger Management

```ruby
usage_trigger_management_api = client.usage_trigger_management
```

## Class Name

`UsageTriggerManagementApi`

## Methods

* [Create New Trigger](../../doc/controllers/usage-trigger-management.md#create-new-trigger)
* [Update Trigger](../../doc/controllers/usage-trigger-management.md#update-trigger)
* [Delete Trigger](../../doc/controllers/usage-trigger-management.md#delete-trigger)


# Create New Trigger

Create a new usage trigger, which will send an alert when the number of device location service transactions reaches a specified percentage of the monthly subscription amount.

```ruby
def create_new_trigger(body: nil)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UsageTriggerAddRequest`](../../doc/models/usage-trigger-add-request.md) | Body, Optional | License assignment. |

## Server

`Server::SUBSCRIPTION_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`UsageTriggerResponse`](../../doc/models/usage-trigger-response.md).

## Example Usage

```ruby
body = UsageTriggerAddRequest.new(
  account_name: '0212312345-00001',
  service_name: ServiceName::LOCATION,
  threshold_value: '95',
  trigger_name: '95% usage alert',
  allow_excess: true,
  send_sms_notification: true,
  sms_phone_numbers: '5551231234',
  send_email_notification: true,
  email_addresses: 'you@theinternet.com'
)

result = usage_trigger_management_api.create_new_trigger(body: body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "triggerId": "595f5c44-c31c-4552-8670-020a1545a84d",
  "triggerName": "90 percent",
  "accountName": "1000012345-00001",
  "serviceName": "Location",
  "thresholdValue": "90",
  "allowExcess": true,
  "sendSmsNotification": true,
  "smsPhoneNumbers": "5558794321",
  "sendEmailNotification": false,
  "emailAddresses": "",
  "createDate": "2018-08-11",
  "updateDate": "2018-08-12"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Update Trigger

Update an existing usage trigger

```ruby
def update_trigger(trigger_id,
                   body: nil)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `trigger_id` | `String` | Template, Required | Usage trigger ID |
| `body` | [`UsageTriggerUpdateRequest`](../../doc/models/usage-trigger-update-request.md) | Body, Optional | New trigger values |

## Server

`Server::SUBSCRIPTION_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`UsageTriggerResponse`](../../doc/models/usage-trigger-response.md).

## Example Usage

```ruby
trigger_id = '595f5c44-c31c-4552-8670-020a1545a84d'

body = UsageTriggerUpdateRequest.new(
  account_name: '1000012345-00001',
  threshold_value: '95'
)

result = usage_trigger_management_api.update_trigger(
  trigger_id,
  body: body
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
  "triggerId": "595f5c44-c31c-4552-8670-020a1545a84d",
  "triggerName": "90 percent",
  "accountName": "1000012345-00001",
  "serviceName": "Location",
  "thresholdValue": "90",
  "allowExcess": true,
  "sendSmsNotification": true,
  "smsPhoneNumbers": "5558794321",
  "sendEmailNotification": false,
  "emailAddresses": "",
  "createDate": "2018-08-11",
  "updateDate": "2018-08-12"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |


# Delete Trigger

eletes the specified usage trigger from the given account

```ruby
def delete_trigger(account_name,
                   trigger_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | Account name |
| `trigger_id` | `String` | Template, Required | Usage trigger ID |

## Server

`Server::SUBSCRIPTION_SERVER`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DeviceLocationSuccessResult`](../../doc/models/device-location-success-result.md).

## Example Usage

```ruby
account_name = '0212312345-00001'

trigger_id = '595f5c44-c31c-4552-8670-020a1545a84d'

result = usage_trigger_management_api.delete_trigger(
  account_name,
  trigger_id
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
| 400 | Unexpected error | [`DeviceLocationResultException`](../../doc/models/device-location-result-exception.md) |

