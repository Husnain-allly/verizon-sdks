# Anomaly Triggers

```go
anomalyTriggersApi := client.AnomalyTriggersApi()
```

## Class Name

`AnomalyTriggersApi`

## Methods

* [List Anomaly Detection Triggers](../../doc/controllers/anomaly-triggers.md#list-anomaly-detection-triggers)
* [Update Anomaly Detection Trigger](../../doc/controllers/anomaly-triggers.md#update-anomaly-detection-trigger)
* [Create Anomaly Detection Trigger](../../doc/controllers/anomaly-triggers.md#create-anomaly-detection-trigger)
* [List Anomaly Detection Trigger Settings](../../doc/controllers/anomaly-triggers.md#list-anomaly-detection-trigger-settings)
* [Delete Anomaly Detection Trigger](../../doc/controllers/anomaly-triggers.md#delete-anomaly-detection-trigger)


# List Anomaly Detection Triggers

This corresponds to the M2M-MC SOAP interface, `GetTriggers`.

```go
ListAnomalyDetectionTriggers(
    ctx context.Context) (
    models.ApiResponse[[]models.GetTriggerResponseList],
    error)
```

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.GetTriggerResponseList](../../doc/models/get-trigger-response-list.md).

## Example Usage

```go
ctx := context.Background()

apiResponse, err := anomalyTriggersApi.ListAnomalyDetectionTriggers(ctx)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 401 | Unauthorized | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 403 | Forbidden | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 404 | Not Found / Does not exist | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 406 | Format / Request Unacceptable | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 429 | Too many requests | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| Default | Error response | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# Update Anomaly Detection Trigger

This corresponds to the M2M-MC SOAP interface, `UpdateTriggerRequest`.

```go
UpdateAnomalyDetectionTrigger(
    ctx context.Context,
    body models.UpdateTriggerRequest) (
    models.ApiResponse[models.AnomalyDetectionTrigger],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.UpdateTriggerRequest`](../../doc/models/update-trigger-request.md) | Body, Required | Update Trigger Request |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.AnomalyDetectionTrigger](../../doc/models/anomaly-detection-trigger.md).

## Example Usage

```go
ctx := context.Background()

body := models.UpdateTriggerRequest{
    AnomalyTriggerRequest:    models.ToPointer(models.AnomalyTriggerRequest{
        AccountNames:              models.ToPointer("0000123456-00001"),
        IncludeAbnormal:           models.ToPointer(true),
        IncludeVeryAbnormal:       models.ToPointer(true),
        IncludeUnderExpectedUsage: models.ToPointer(true),
        IncludeOverExpectedUsage:  models.ToPointer(true),
    }),
}

apiResponse, err := anomalyTriggersApi.UpdateAnomalyDetectionTrigger(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 401 | Unauthorized | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 403 | Forbidden | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 404 | Not Found / Does not exist | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 406 | Format / Request Unacceptable | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 429 | Too many requests | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| Default | Error response | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# Create Anomaly Detection Trigger

This corresponds to the M2M-MC SOAP interface, `CreateTrigger`.

```go
CreateAnomalyDetectionTrigger(
    ctx context.Context,
    body models.CreateTriggerRequest) (
    models.ApiResponse[models.AnomalyDetectionTrigger],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.CreateTriggerRequest`](../../doc/models/create-trigger-request.md) | Body, Required | Create Trigger Request |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.AnomalyDetectionTrigger](../../doc/models/anomaly-detection-trigger.md).

## Example Usage

```go
ctx := context.Background()

body := models.CreateTriggerRequest{
    AnomalyTriggerRequest: models.ToPointer(models.AnomalyTriggerRequest{
        AccountNames:              models.ToPointer("0000123456-00001"),
        IncludeAbnormal:           models.ToPointer(true),
        IncludeVeryAbnormal:       models.ToPointer(true),
        IncludeUnderExpectedUsage: models.ToPointer(true),
        IncludeOverExpectedUsage:  models.ToPointer(true),
    }),
}

apiResponse, err := anomalyTriggersApi.CreateAnomalyDetectionTrigger(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 401 | Unauthorized | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 403 | Forbidden | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 404 | Not Found / Does not exist | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 406 | Format / Request Unacceptable | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 429 | Too many requests | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| Default | Error response | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# List Anomaly Detection Trigger Settings

This corresponds to the M2M-MC SOAP interface, `GetTriggers`.

```go
ListAnomalyDetectionTriggerSettings(
    ctx context.Context,
    triggerId string) (
    models.ApiResponse[[]models.GetTriggerResponseList],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string` | Template, Required | trigger ID |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.GetTriggerResponseList](../../doc/models/get-trigger-response-list.md).

## Example Usage

```go
ctx := context.Background()

triggerId := "be1b5958-3e11-41db-9abd-b1b7618c0035"

apiResponse, err := anomalyTriggersApi.ListAnomalyDetectionTriggerSettings(ctx, triggerId)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 401 | Unauthorized | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 403 | Forbidden | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 404 | Not Found / Does not exist | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 406 | Format / Request Unacceptable | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| 429 | Too many requests | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |
| Default | Error response | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |


# Delete Anomaly Detection Trigger

Deletes a specific trigger ID

```go
DeleteAnomalyDetectionTrigger(
    ctx context.Context,
    triggerId string) (
    models.ApiResponse[models.AnomalyDetectionTrigger],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `string` | Template, Required | The trigger ID to be deleted |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.AnomalyDetectionTrigger](../../doc/models/anomaly-detection-trigger.md).

## Example Usage

```go
ctx := context.Background()

triggerId := "be1b5958-3e11-41db-9abd-b1b7618c0035"

apiResponse, err := anomalyTriggersApi.DeleteAnomalyDetectionTrigger(ctx, triggerId)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |

