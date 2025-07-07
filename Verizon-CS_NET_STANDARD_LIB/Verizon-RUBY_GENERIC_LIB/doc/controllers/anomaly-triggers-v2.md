# Anomaly Triggers V2

```ruby
anomaly_triggers_v2_api = client.anomaly_triggers_v2
```

## Class Name

`AnomalyTriggersV2Api`

## Methods

* [Create Anomaly Detection Trigger V2](../../doc/controllers/anomaly-triggers-v2.md#create-anomaly-detection-trigger-v2)
* [Update Anomaly Detection Trigger V2](../../doc/controllers/anomaly-triggers-v2.md#update-anomaly-detection-trigger-v2)
* [List Anomaly Detection Trigger Settings V2](../../doc/controllers/anomaly-triggers-v2.md#list-anomaly-detection-trigger-settings-v2)


# Create Anomaly Detection Trigger V2

Creates the trigger to identify an anomaly.

```ruby
def create_anomaly_detection_trigger_v2(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | Array[[TriggerType1](../../doc/models/trigger-type-1.md) \| [ActiveAnomalyIndicator](../../doc/models/active-anomaly-indicator.md) \| [ActiveTriggerIndicator](../../doc/models/active-trigger-indicator.md)] | Body, Required | Request to create an anomaly trigger. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`AnomalyDetectionTrigger`](../../doc/models/anomaly-detection-trigger.md).

## Example Usage

```ruby
body = [
  TriggerType1.new(
    name: 'Anomaly Daily Usage REST Test-Patch 1',
    trigger_category: 'UsageAnomaly',
    account_name: '0000123456-00001',
    anomaly_trigger_request: AnomalyTriggerRequest.new(
      account_names: '0000123456-00001',
      include_abnormal: true,
      include_very_abnormal: true,
      include_under_expected_usage: true,
      include_over_expected_usage: true
    ),
    notification: TriggerNotification.new(
      notification_type: 'DailySummary',
      callback: true,
      email_notification: false,
      notification_group_name: 'Anomaly Test API',
      notification_frequency_factor: 3,
      notification_frequency_interval: 'Hourly',
      external_email_recipients: 'placeholder@verizon.com',
      sms_notification: true,
      sms_numbers: [
        SmsNumber.new(
          carrier: 'US Cellular',
          number: '9299280711'
        )
      ],
      reminder: true,
      severity: 'Critical'
    )
  )
]

result = anomaly_triggers_v2_api.create_anomaly_detection_trigger_v2(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "triggerId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | An error occurred. | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# Update Anomaly Detection Trigger V2

Updates an existing trigger using the account name.

```ruby
def update_anomaly_detection_trigger_v2(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | Array[[TriggerType3](../../doc/models/trigger-type-3.md) \| [ActiveAnomalyIndicator](../../doc/models/active-anomaly-indicator.md)] | Body, Required | Request to update existing trigger. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`IntelligenceSuccessResult`](../../doc/models/intelligence-success-result.md).

## Example Usage

```ruby
body = [
  TriggerType3.new(
    trigger_id: '595f5c44-c31c-4552-8670-020a1545a84d',
    trigger_name: 'Anomaly Daily Usage REST Test-Patch Update 4',
    trigger_category: 'UsageAnomaly',
    account_name: '0000123456-00001',
    anomaly_trigger_request: AnomalyTriggerRequest.new(
      account_names: '0000123456-00001',
      include_abnormal: true,
      include_very_abnormal: true,
      include_under_expected_usage: false,
      include_over_expected_usage: true
    ),
    notification: TriggerNotification.new(
      notification_type: 'DailySummary',
      callback: true,
      email_notification: false,
      notification_group_name: 'Anomaly Test API',
      notification_frequency_factor: 3,
      notification_frequency_interval: 'Hourly',
      external_email_recipients: 'placeholder@verizon.com',
      sms_notification: true,
      sms_numbers: [
        SmsNumber.new(
          carrier: 'US Cellular',
          number: '9299280711'
        )
      ],
      reminder: true,
      severity: 'Critical'
    )
  )
]

result = anomaly_triggers_v2_api.update_anomaly_detection_trigger_v2(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "status": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | An error occurred. | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# List Anomaly Detection Trigger Settings V2

Retrieves the values for a specific trigger ID.

```ruby
def list_anomaly_detection_trigger_settings_v2(trigger_id)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `trigger_id` | `String` | Template, Required | The trigger ID of a specific trigger. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`AnomalyTriggerResult`](../../doc/models/anomaly-trigger-result.md).

## Example Usage

```ruby
trigger_id = 'be1b5958-3e11-41db-9abd-b1b7618c0035'

result = anomaly_triggers_v2_api.list_anomaly_detection_trigger_settings_v2(trigger_id)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "triggers": [
    {
      "triggerId": "BE1B5958-3E11-41DB-9ABD-B1B7618C0035",
      "triggerName": "Anomaly Daily Usage REST Test-1",
      "organizationName": "AnamolyDetectionRTRTest",
      "triggerCategory": "UsageAnomaly",
      "triggerAttributes": [
        {
          "key": "DataPercentage50",
          "value": false
        }
      ],
      "createdAt": "2021-10-21T23:57:03.397.0000Z",
      "modifiedAt": "2021-10-21T23:57:03.397.0000Z",
      "notification": {
        "notificationType": "DailySummary",
        "callback": true,
        "emailNotification": true,
        "notificationGroupName": "Anomaly Test API",
        "notificationFrequencyFactor": -2147483648,
        "externalEmailRecipients": "placeholder@verizon.com",
        "smsNotification": true,
        "smsNumbers": [
          {
            "carrier": "US Cellular",
            "number": "9299280711"
          }
        ],
        "reminder": false,
        "severity": "Critical"
      }
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | An error occurred. | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |

