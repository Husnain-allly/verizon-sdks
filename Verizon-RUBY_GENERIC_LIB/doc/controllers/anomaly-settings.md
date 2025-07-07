# Anomaly Settings

```ruby
anomaly_settings_api = client.anomaly_settings
```

## Class Name

`AnomalySettingsApi`

## Methods

* [Activate Anomaly Detection](../../doc/controllers/anomaly-settings.md#activate-anomaly-detection)
* [List Anomaly Detection Settings](../../doc/controllers/anomaly-settings.md#list-anomaly-detection-settings)
* [Reset Anomaly Detection Parameters](../../doc/controllers/anomaly-settings.md#reset-anomaly-detection-parameters)


# Activate Anomaly Detection

Uses the subscribed account ID to activate anomaly detection and set threshold values.

```ruby
def activate_anomaly_detection(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AnomalyDetectionRequest`](../../doc/models/anomaly-detection-request.md) | Body, Required | Request to activate anomaly detection. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`IntelligenceSuccessResult`](../../doc/models/intelligence-success-result.md).

## Example Usage

```ruby
body = AnomalyDetectionRequest.new(
  account_name: '0000123456-00001',
  request_type: 'anomaly',
  sensitivity_parameter: SensitivityParameters.new(
    abnormal_max_value: 1.1,
    enable_abnormal: true,
    enable_very_abnormal: true,
    very_abnormal_max_value: 0.55
  )
)

result = anomaly_settings_api.activate_anomaly_detection(body)

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


# List Anomaly Detection Settings

Retrieves the current anomaly detection settings for an account.

```ruby
def list_anomaly_detection_settings(account_name)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | The name of the subscribed account. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`AnomalyDetectionSettings`](../../doc/models/anomaly-detection-settings.md).

## Example Usage

```ruby
account_name = '0000123456-00001'

result = anomaly_settings_api.list_anomaly_detection_settings(account_name)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "accountName": "Success",
  "sensitivityParameter": {
    "abnormalMaxValue": 1.1,
    "enableAbnormal": true,
    "enableVeryAbnormal": true,
    "veryAbnormalMaxValue": 0.55
  },
  "status": "Active"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | An error occurred. | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# Reset Anomaly Detection Parameters

Resets the thresholds to zero.

```ruby
def reset_anomaly_detection_parameters(account_name)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Template, Required | The name of the subscribed account. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`IntelligenceSuccessResult`](../../doc/models/intelligence-success-result.md).

## Example Usage

```ruby
account_name = '0000123456-00001'

result = anomaly_settings_api.reset_anomaly_detection_parameters(account_name)

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

