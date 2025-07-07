# Sensor Insights Rules

```java
SensorInsightsRulesApi sensorInsightsRulesApi = client.getSensorInsightsRulesApi();
```

## Class Name

`SensorInsightsRulesApi`

## Methods

* [Sensor Insights Overwrite Rule Request](../../doc/controllers/sensor-insights-rules.md#sensor-insights-overwrite-rule-request)
* [Sensor Insights List Rules Request](../../doc/controllers/sensor-insights-rules.md#sensor-insights-list-rules-request)


# Sensor Insights Overwrite Rule Request

```java
CompletableFuture<ApiResponse<ResourceRule>> sensorInsightsOverwriteRuleRequestAsync(
    final DtoOverwriteRuleRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOverwriteRuleRequest`](../../doc/models/dto-overwrite-rule-request.md) | Body, Required | Overwrite a rule |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`ResourceRule`](../../doc/models/resource-rule.md).

## Example Usage

```java
DtoOverwriteRuleRequest body = new DtoOverwriteRuleRequest.Builder()
    .accountname("0000123456-00001")
    .resourceidentifier(new DtoResourceidentifier.Builder()
        .id("7f5f610a-eeee-ffff-gggg-4d20cf3dcfbc")
        .build())
    .rule(new ResourceRule.Builder(
        DateTimeHelper.fromRfc8601DateTime("2023-10-02T15:46:34.562Z"),
        "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
        DateTimeHelper.fromRfc8601DateTime("2023-10-02T15:46:34.562Z"),
        ApiHelper.deserialize("{}"),
        "337bd2e8-eeee-ffff-gggg-5207992fd395"
    )
    .accountclientid("null")
    .billingaccountid("The billing account ID")
    .description("a short description")
    .deviceid("The UUID of the device")
    .disabled(true)
    .id("bc5b5b5a-eeee-ffff-gggg-cb2cb2533d47")
    .name("User defined name of the record")
    .rulesyntax("The rule syntax")
    .version("1.0")
    .build())
    .build();

sensorInsightsRulesApi.sensorInsightsOverwriteRuleRequestAsync(body).thenAccept(result -> {
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


# Sensor Insights List Rules Request

```java
CompletableFuture<ApiResponse<List<ResourceRule>>> sensorInsightsListRulesRequestAsync(
    final DtoListRulesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListRulesRequest`](../../doc/models/dto-list-rules-request.md) | Body, Required | Retrieve a rule |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`List<ResourceRule>`](../../doc/models/resource-rule.md).

## Example Usage

```java
DtoListRulesRequest body = new DtoListRulesRequest.Builder()
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
        .id("ffb86390-eeee-ffff-gggg-9d1180882d63")
        .build())
    .build();

sensorInsightsRulesApi.sensorInsightsListRulesRequestAsync(body).thenAccept(result -> {
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

