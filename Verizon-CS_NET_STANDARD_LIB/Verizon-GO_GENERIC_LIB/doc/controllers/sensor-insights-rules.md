# Sensor Insights Rules

```go
sensorInsightsRulesApi := client.SensorInsightsRulesApi()
```

## Class Name

`SensorInsightsRulesApi`

## Methods

* [Sensor Insights Overwrite Rule Request](../../doc/controllers/sensor-insights-rules.md#sensor-insights-overwrite-rule-request)
* [Sensor Insights List Rules Request](../../doc/controllers/sensor-insights-rules.md#sensor-insights-list-rules-request)


# Sensor Insights Overwrite Rule Request

```go
SensorInsightsOverwriteRuleRequest(
    ctx context.Context,
    body models.DtoOverwriteRuleRequest) (
    models.ApiResponse[models.ResourceRule],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoOverwriteRuleRequest`](../../doc/models/dto-overwrite-rule-request.md) | Body, Required | Overwrite a rule |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ResourceRule](../../doc/models/resource-rule.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoOverwriteRuleRequest{
    Accountname:        models.ToPointer("0000123456-00001"),
    Resourceidentifier: models.ToPointer(models.DtoResourceidentifier{
        Id: models.ToPointer("7f5f610a-eeee-ffff-gggg-4d20cf3dcfbc"),
    }),
    Rule:               models.ToPointer(models.ResourceRule{
        Accountclientid:  models.ToPointer("null"),
        Billingaccountid: models.ToPointer("The billing account ID"),
        Createdon:        parseTime(time.RFC3339, "2023-10-02T15:46:34.562Z", func(err error) { log.Fatalln(err) }),
        Description:      models.ToPointer("a short description"),
        Deviceid:         models.ToPointer("The UUID of the device"),
        Disabled:         models.ToPointer(true),
        Foreignid:        "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
        Id:               models.ToPointer("bc5b5b5a-eeee-ffff-gggg-cb2cb2533d47"),
        Lastupdated:      parseTime(time.RFC3339, "2023-10-02T15:46:34.562Z", func(err error) { log.Fatalln(err) }),
        Name:             models.ToPointer("User defined name of the record"),
        Rulechain:        interface{}(""),
        Rulesyntax:       models.ToPointer("The rule syntax"),
        Version:          models.ToPointer("1.0"),
        Versionid:        "337bd2e8-eeee-ffff-gggg-5207992fd395",
    }),
}

apiResponse, err := sensorInsightsRulesApi.SensorInsightsOverwriteRuleRequest(ctx, body)
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

```go
SensorInsightsListRulesRequest(
    ctx context.Context,
    body models.DtoListRulesRequest) (
    models.ApiResponse[[]models.ResourceRule],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoListRulesRequest`](../../doc/models/dto-list-rules-request.md) | Body, Required | Retrieve a rule |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.ResourceRule](../../doc/models/resource-rule.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoListRulesRequest{
    Accountname:        models.ToPointer("0000123456-00001"),
    Filter:             models.ToPointer(models.DtoFilter{
        MExpand:       models.ToPointer("device detail(s)"),
        MLimitnumber:  models.ToPointer(100),
        MNopagination: models.ToPointer(true),
        MPage:         models.ToPointer("The number of pages"),
        MPagenumber:   models.ToPointer(100),
        MProjection:   []string{
            "specific device fields requested",
        },
        MSelection:    map[string]interface{}{
            "additionalProp1": interface{}("string"),
            "additionalProp2": interface{}("string"),
            "additionalProp3": interface{}("string"),
        },
    }),
    Resourceidentifier: models.ToPointer(models.DtoResourceidentifier{
        Id: models.ToPointer("ffb86390-eeee-ffff-gggg-9d1180882d63"),
    }),
}

apiResponse, err := sensorInsightsRulesApi.SensorInsightsListRulesRequest(ctx, body)
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
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |

