# Sensor Insights Smart Alerts

```java
SensorInsightsSmartAlertsApi sensorInsightsSmartAlertsApi = client.getSensorInsightsSmartAlertsApi();
```

## Class Name

`SensorInsightsSmartAlertsApi`

## Methods

* [Sensor Insights List Smart Alerts Request](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-list-smart-alerts-request)
* [Sensor Insights Patch Smart Alert Request](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-patch-smart-alert-request)
* [Sensor Insights Bulk Update](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-bulk-update)


# Sensor Insights List Smart Alerts Request

```java
CompletableFuture<ApiResponse<List<UserSmartAlert>>> sensorInsightsListSmartAlertsRequestAsync(
    final DtoListSmartAlertsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListSmartAlertsRequest`](../../doc/models/dto-list-smart-alerts-request.md) | Body, Required | Retrieve a smart alert |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<UserSmartAlert>`](../../doc/models/user-smart-alert.md).

## Example Usage

```java
DtoListSmartAlertsRequest body = new DtoListSmartAlertsRequest.Builder()
    .accountname("0000123456-00001")
    .filter(new DtoFilter.Builder()
        .mExpand("device detail(s)")
        .mLimitnumber(100)
        .mNopagination(true)
        .mPage("The number of pages")
        .mPagenumber(100)
        .mProjection(Arrays.asList(
            "specific device fields requested"
        ))
        .mSelection(new LinkedHashMap<String, Object>() {{
            put("additionalProp1", ApiHelper.deserialize("\"string\""));
            put("additionalProp2", ApiHelper.deserialize("\"string\""));
            put("additionalProp3", ApiHelper.deserialize("\"string\""));
        }})
        .build())
    .resourceidentifier(new DtoResourceidentifier.Builder()
        .id("cb3eea68-eeee-ffff-gggg-ac4463ccd073")
        .build())
    .build();

sensorInsightsSmartAlertsApi.sensorInsightsListSmartAlertsRequestAsync(body).thenAccept(result -> {
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
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Patch Smart Alert Request

```java
CompletableFuture<ApiResponse<UserSmartAlert>> sensorInsightsPatchSmartAlertRequestAsync(
    final DtoPatchSmartAlertRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoPatchSmartAlertRequest`](../../doc/models/dto-patch-smart-alert-request.md) | Body, Required | Partially update a smart alert |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`UserSmartAlert`](../../doc/models/user-smart-alert.md).

## Example Usage

```java
DtoPatchSmartAlertRequest body = new DtoPatchSmartAlertRequest.Builder()
    .accountname("0000123456-00001")
    .resourceidentifier(new DtoResourceidentifier.Builder()
        .id("0b37ab8b-eeee-ffff-gggg-e0149af43f43")
        .build())
    .smartalert(new UserSmartAlert.Builder(
        DateTimeHelper.fromRfc8601DateTime("2023-10-02T15:46:34.562Z"),
        DateTimeHelper.fromRfc8601DateTime("2023-10-02T15:46:34.562Z"),
        "337bd2e8-eeee-ffff-gggg-5207992fd395"
    )
    .accountclientid("null")
    .billingaccountid("0000123456-00001")
    .category("telemetry")
    .condition(2592000)
    .description("a short description")
    .deviceid("The UUID of the device")
    .foreignid("c1f178d3-eeee-ffff-gggg-0d6b7ae6022a")
    .id("fecbe450-eeee-ffff-gggg-aa166fd5f8e3")
    .isacknowledged(true)
    .iscleared(true)
    .isdisabled(false)
    .name("User defined name of the record")
    .ruleid("The UUID of a rule")
    .severity("minor")
    .state("success")
    .template("The template ID")
    .version("1.0")
    .build())
    .build();

sensorInsightsSmartAlertsApi.sensorInsightsPatchSmartAlertRequestAsync(body).thenAccept(result -> {
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
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Bulk Update

```java
CompletableFuture<ApiResponse<UserSmartAlert>> sensorInsightsBulkUpdateAsync(
    final DtoBulkUpdate body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoBulkUpdate`](../../doc/models/dto-bulk-update.md) | Body, Required | Bulk update smart alerts |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`UserSmartAlert`](../../doc/models/user-smart-alert.md).

## Example Usage

```java
DtoBulkUpdate body = new DtoBulkUpdate.Builder()
    .accountname("0000123456-00001")
    .resourceidentifiers(Arrays.asList(
        new TheIDresourceandDeviceId.Builder()
            .id("ee70a869-eeee-ffff-gggg-07c14c31f96e")
            .build(),
        new TheIDresourceandDeviceId.Builder()
            .deviceid("The UUID of the device")
            .build()
    ))
    .smartalert(new BulkUpdateSmartalert.Builder()
        .name("User defined name of the record")
        .build())
    .build();

sensorInsightsSmartAlertsApi.sensorInsightsBulkUpdateAsync(body).thenAccept(result -> {
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
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |

