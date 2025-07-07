# Sensor Insights Smart Alerts

```go
sensorInsightsSmartAlertsApi := client.SensorInsightsSmartAlertsApi()
```

## Class Name

`SensorInsightsSmartAlertsApi`

## Methods

* [Sensor Insights List Smart Alerts Request](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-list-smart-alerts-request)
* [Sensor Insights Patch Smart Alert Request](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-patch-smart-alert-request)
* [Sensor Insights Bulk Update](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-bulk-update)


# Sensor Insights List Smart Alerts Request

```go
SensorInsightsListSmartAlertsRequest(
    ctx context.Context,
    body models.DtoListSmartAlertsRequest) (
    models.ApiResponse[[]models.UserSmartAlert],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoListSmartAlertsRequest`](../../doc/models/dto-list-smart-alerts-request.md) | Body, Required | Retrieve a smart alert |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.UserSmartAlert](../../doc/models/user-smart-alert.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoListSmartAlertsRequest{
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
        Id: models.ToPointer("cb3eea68-eeee-ffff-gggg-ac4463ccd073"),
    }),
}

apiResponse, err := sensorInsightsSmartAlertsApi.SensorInsightsListSmartAlertsRequest(ctx, body)
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


# Sensor Insights Patch Smart Alert Request

```go
SensorInsightsPatchSmartAlertRequest(
    ctx context.Context,
    body models.DtoPatchSmartAlertRequest) (
    models.ApiResponse[models.UserSmartAlert],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoPatchSmartAlertRequest`](../../doc/models/dto-patch-smart-alert-request.md) | Body, Required | Partially update a smart alert |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.UserSmartAlert](../../doc/models/user-smart-alert.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoPatchSmartAlertRequest{
    Accountname:        models.ToPointer("0000123456-00001"),
    Resourceidentifier: models.ToPointer(models.DtoResourceidentifier{
        Id: models.ToPointer("0b37ab8b-eeee-ffff-gggg-e0149af43f43"),
    }),
    Smartalert:         models.ToPointer(models.UserSmartAlert{
        Accountclientid:  models.ToPointer("null"),
        Billingaccountid: models.ToPointer("0000123456-00001"),
        Category:         models.ToPointer("telemetry"),
        Condition:        models.ToPointer(2592000),
        Createdon:        parseTime(time.RFC3339, "2023-10-02T15:46:34.562Z", func(err error) { log.Fatalln(err) }),
        Description:      models.ToPointer("a short description"),
        Deviceid:         models.ToPointer("The UUID of the device"),
        Foreignid:        models.ToPointer("c1f178d3-eeee-ffff-gggg-0d6b7ae6022a"),
        Id:               models.ToPointer("fecbe450-eeee-ffff-gggg-aa166fd5f8e3"),
        Isacknowledged:   models.ToPointer(true),
        Iscleared:        models.ToPointer(true),
        Isdisabled:       models.ToPointer(false),
        Lastupdated:      parseTime(time.RFC3339, "2023-10-02T15:46:34.562Z", func(err error) { log.Fatalln(err) }),
        Name:             models.ToPointer("User defined name of the record"),
        Ruleid:           models.ToPointer("The UUID of a rule"),
        Severity:         models.ToPointer("minor"),
        State:            models.ToPointer("success"),
        Template:         models.ToPointer("The template ID"),
        Version:          models.ToPointer("1.0"),
        Versionid:        "337bd2e8-eeee-ffff-gggg-5207992fd395",
    }),
}

apiResponse, err := sensorInsightsSmartAlertsApi.SensorInsightsPatchSmartAlertRequest(ctx, body)
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


# Sensor Insights Bulk Update

```go
SensorInsightsBulkUpdate(
    ctx context.Context,
    body models.DtoBulkUpdate) (
    models.ApiResponse[models.UserSmartAlert],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoBulkUpdate`](../../doc/models/dto-bulk-update.md) | Body, Required | Bulk update smart alerts |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.UserSmartAlert](../../doc/models/user-smart-alert.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoBulkUpdate{
    Accountname:           models.ToPointer("0000123456-00001"),
    Resourceidentifiers:   []models.TheIDresourceandDeviceId{
        models.TheIDresourceandDeviceId{
            Id:                    models.ToPointer("ee70a869-eeee-ffff-gggg-07c14c31f96e"),
        },
        models.TheIDresourceandDeviceId{
            Deviceid:              models.ToPointer("The UUID of the device"),
        },
    },
    Smartalert:            models.ToPointer(models.BulkUpdateSmartalert{
        Name: models.ToPointer("User defined name of the record"),
    }),
}

apiResponse, err := sensorInsightsSmartAlertsApi.SensorInsightsBulkUpdate(ctx, body)
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

