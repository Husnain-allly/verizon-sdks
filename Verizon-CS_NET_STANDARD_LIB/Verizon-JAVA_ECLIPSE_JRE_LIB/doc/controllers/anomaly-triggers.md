# Anomaly Triggers

```java
AnomalyTriggersApi anomalyTriggersApi = client.getAnomalyTriggersApi();
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

```java
CompletableFuture<ApiResponse<List<GetTriggerResponseList>>> listAnomalyDetectionTriggersAsync()
```

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<GetTriggerResponseList>`](../../doc/models/get-trigger-response-list.md).

## Example Usage

```java
anomalyTriggersApi.listAnomalyDetectionTriggersAsync().thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<AnomalyDetectionTrigger>> updateAnomalyDetectionTriggerAsync(
    final UpdateTriggerRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UpdateTriggerRequest`](../../doc/models/update-trigger-request.md) | Body, Required | Update Trigger Request |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`AnomalyDetectionTrigger`](../../doc/models/anomaly-detection-trigger.md).

## Example Usage

```java
UpdateTriggerRequest body = new UpdateTriggerRequest.Builder()
    .anomalyTriggerRequest(new AnomalyTriggerRequest.Builder()
        .accountNames("0000123456-00001")
        .includeAbnormal(true)
        .includeVeryAbnormal(true)
        .includeUnderExpectedUsage(true)
        .includeOverExpectedUsage(true)
        .build())
    .build();

anomalyTriggersApi.updateAnomalyDetectionTriggerAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<AnomalyDetectionTrigger>> createAnomalyDetectionTriggerAsync(
    final CreateTriggerRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateTriggerRequest`](../../doc/models/create-trigger-request.md) | Body, Required | Create Trigger Request |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`AnomalyDetectionTrigger`](../../doc/models/anomaly-detection-trigger.md).

## Example Usage

```java
CreateTriggerRequest body = new CreateTriggerRequest.Builder()
    .anomalyTriggerRequest(new AnomalyTriggerRequest.Builder()
        .accountNames("0000123456-00001")
        .includeAbnormal(true)
        .includeVeryAbnormal(true)
        .includeUnderExpectedUsage(true)
        .includeOverExpectedUsage(true)
        .build())
    .build();

anomalyTriggersApi.createAnomalyDetectionTriggerAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<List<GetTriggerResponseList>>> listAnomalyDetectionTriggerSettingsAsync(
    final String triggerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `String` | Template, Required | trigger ID |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<GetTriggerResponseList>`](../../doc/models/get-trigger-response-list.md).

## Example Usage

```java
String triggerId = "be1b5958-3e11-41db-9abd-b1b7618c0035";

anomalyTriggersApi.listAnomalyDetectionTriggerSettingsAsync(triggerId).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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

```java
CompletableFuture<ApiResponse<AnomalyDetectionTrigger>> deleteAnomalyDetectionTriggerAsync(
    final String triggerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `triggerId` | `String` | Template, Required | The trigger ID to be deleted |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`AnomalyDetectionTrigger`](../../doc/models/anomaly-detection-trigger.md).

## Example Usage

```java
String triggerId = "be1b5958-3e11-41db-9abd-b1b7618c0035";

anomalyTriggersApi.deleteAnomalyDetectionTriggerAsync(triggerId).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`IntelligenceResultException`](../../doc/models/intelligence-result-exception.md) |

