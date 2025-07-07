# Anomaly Triggers V2

```go
anomalyTriggersV2Api := client.AnomalyTriggersV2Api()
```

## Class Name

`AnomalyTriggersV2Api`

## Methods

* [Create Anomaly Detection Trigger V2](../../doc/controllers/anomaly-triggers-v2.md#create-anomaly-detection-trigger-v2)
* [Update Anomaly Detection Trigger V2](../../doc/controllers/anomaly-triggers-v2.md#update-anomaly-detection-trigger-v2)
* [List Anomaly Detection Trigger Settings V2](../../doc/controllers/anomaly-triggers-v2.md#list-anomaly-detection-trigger-settings-v2)


# Create Anomaly Detection Trigger V2

Creates the trigger to identify an anomaly.

```go
CreateAnomalyDetectionTriggerV2(
    ctx context.Context,
    body []models.CreateTriggerRequestOptions) (
    models.ApiResponse[models.AnomalyDetectionTrigger],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`[]models.CreateTriggerRequestOptions`](../../doc/models/create-trigger-request-options.md) | Body, Required | Request to create an anomaly trigger. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.AnomalyDetectionTrigger](../../doc/models/anomaly-detection-trigger.md).

## Example Usage

```go
ctx := context.Background()

body := []models.CreateTriggerRequestOptions{
    models.CreateTriggerRequestOptions{
        Name:                  models.ToPointer("Anomaly Daily Usage REST Test-Patch 1"),
        TriggerCategory:       models.ToPointer("UsageAnomaly"),
        AccountName:           models.ToPointer("0000123456-00001"),
        AnomalyTriggerRequest: models.ToPointer(models.AnomalyTriggerRequest{
            AccountNames:              models.ToPointer("0000123456-00001"),
            IncludeAbnormal:           models.ToPointer(true),
            IncludeVeryAbnormal:       models.ToPointer(true),
            IncludeUnderExpectedUsage: models.ToPointer(true),
            IncludeOverExpectedUsage:  models.ToPointer(true),
        }),
        Notification:          models.ToPointer(models.TriggerNotification{
            NotificationType:              models.ToPointer("DailySummary"),
            Callback:                      models.ToPointer(true),
            EmailNotification:             models.ToPointer(false),
            NotificationGroupName:         models.ToPointer("Anomaly Test API"),
            NotificationFrequencyFactor:   models.ToPointer(3),
            NotificationFrequencyInterval: models.ToPointer("Hourly"),
            ExternalEmailRecipients:       models.ToPointer("placeholder@verizon.com"),
            SmsNotification:               models.ToPointer(true),
            SmsNumbers:                    []models.SmsNumber{
                models.SmsNumber{
                    Carrier:               models.ToPointer("US Cellular"),
                    Number:                models.ToPointer("9299280711"),
                },
            },
            Reminder:                      models.ToPointer(true),
            Severity:                      models.ToPointer("Critical"),
        }),
    },
}

apiResponse, err := anomalyTriggersV2Api.CreateAnomalyDetectionTriggerV2(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
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

```go
UpdateAnomalyDetectionTriggerV2(
    ctx context.Context,
    body []models.UpdateTriggerRequestOptions) (
    models.ApiResponse[models.IntelligenceSuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`[]models.UpdateTriggerRequestOptions`](../../doc/models/update-trigger-request-options.md) | Body, Required | Request to update existing trigger. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.IntelligenceSuccessResult](../../doc/models/intelligence-success-result.md).

## Example Usage

```go
ctx := context.Background()

body := []models.UpdateTriggerRequestOptions{
    models.UpdateTriggerRequestOptions{
        TriggerId:             models.ToPointer("595f5c44-c31c-4552-8670-020a1545a84d"),
        TriggerName:           models.ToPointer("Anomaly Daily Usage REST Test-Patch Update 4"),
        TriggerCategory:       models.ToPointer("UsageAnomaly"),
        AccountName:           models.ToPointer("0000123456-00001"),
        AnomalyTriggerRequest: models.ToPointer(models.AnomalyTriggerRequest{
            AccountNames:              models.ToPointer("0000123456-00001"),
            IncludeAbnormal:           models.ToPointer(true),
            IncludeVeryAbnormal:       models.ToPointer(true),
            IncludeUnderExpectedUsage: models.ToPointer(false),
            IncludeOverExpectedUsage:  models.ToPointer(true),
        }),
        Notification:          models.ToPointer(models.TriggerNotification{
            NotificationType:              models.ToPointer("DailySummary"),
            Callback:                      models.ToPointer(true),
            EmailNotification:             models.ToPointer(false),
            NotificationGroupName:         models.ToPointer("Anomaly Test API"),
            NotificationFrequencyFactor:   models.ToPointer(3),
            NotificationFrequencyInterval: models.ToPointer("Hourly"),
            ExternalEmailRecipients:       models.ToPointer("placeholder@verizon.com"),
            SmsNotification:               models.ToPointer(true),
            SmsNumbers:                    []models.SmsNumber{
                models.SmsNumber{
                    Carrier:               models.ToPointer("US Cellular"),
                    Number:                models.ToPointer("9299280711"),
                },
            },
            Reminder:                      models.ToPointer(true),
            Severity:                      models.ToPointer("Critical"),
        }),
    },
}

apiResponse, err := anomalyTriggersV2Api.UpdateAnomalyDetectionTriggerV2(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
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

```go
ListAnomalyDetectionTriggerSettingsV2(
    ctx context.Context,
    triggerId string) (
    models.ApiResponse[models.AnomalyTriggerResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string` | Template, Required | The trigger ID of a specific trigger. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.AnomalyTriggerResult](../../doc/models/anomaly-trigger-result.md).

## Example Usage

```go
ctx := context.Background()

triggerId := "be1b5958-3e11-41db-9abd-b1b7618c0035"

apiResponse, err := anomalyTriggersV2Api.ListAnomalyDetectionTriggerSettingsV2(ctx, triggerId)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
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

