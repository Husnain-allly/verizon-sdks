# Anomaly Settings

```go
anomalySettingsApi := client.AnomalySettingsApi()
```

## Class Name

`AnomalySettingsApi`

## Methods

* [Activate Anomaly Detection](../../doc/controllers/anomaly-settings.md#activate-anomaly-detection)
* [List Anomaly Detection Settings](../../doc/controllers/anomaly-settings.md#list-anomaly-detection-settings)
* [Reset Anomaly Detection Parameters](../../doc/controllers/anomaly-settings.md#reset-anomaly-detection-parameters)


# Activate Anomaly Detection

Uses the subscribed account ID to activate anomaly detection and set threshold values.

```go
ActivateAnomalyDetection(
    ctx context.Context,
    body models.AnomalyDetectionRequest) (
    models.ApiResponse[models.IntelligenceSuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.AnomalyDetectionRequest`](../../doc/models/anomaly-detection-request.md) | Body, Required | Request to activate anomaly detection. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.IntelligenceSuccessResult](../../doc/models/intelligence-success-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.AnomalyDetectionRequest{
    AccountName:          models.ToPointer("0000123456-00001"),
    RequestType:          models.ToPointer("anomaly"),
    SensitivityParameter: models.ToPointer(models.SensitivityParameters{
        AbnormalMaxValue:     models.ToPointer(float64(1.1)),
        EnableAbnormal:       models.ToPointer(true),
        EnableVeryAbnormal:   models.ToPointer(true),
        VeryAbnormalMaxValue: models.ToPointer(float64(0.55)),
    }),
}

apiResponse, err := anomalySettingsApi.ActivateAnomalyDetection(ctx, body)
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


# List Anomaly Detection Settings

Retrieves the current anomaly detection settings for an account.

```go
ListAnomalyDetectionSettings(
    ctx context.Context,
    accountName string) (
    models.ApiResponse[models.AnomalyDetectionSettings],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | The name of the subscribed account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.AnomalyDetectionSettings](../../doc/models/anomaly-detection-settings.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

apiResponse, err := anomalySettingsApi.ListAnomalyDetectionSettings(ctx, accountName)
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

```go
ResetAnomalyDetectionParameters(
    ctx context.Context,
    accountName string) (
    models.ApiResponse[models.IntelligenceSuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | The name of the subscribed account. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.IntelligenceSuccessResult](../../doc/models/intelligence-success-result.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

apiResponse, err := anomalySettingsApi.ResetAnomalyDetectionParameters(ctx, accountName)
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

