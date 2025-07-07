# Sensor Insights Smart Alerts

```csharp
SensorInsightsSmartAlertsApi sensorInsightsSmartAlertsApi = client.SensorInsightsSmartAlertsApi;
```

## Class Name

`SensorInsightsSmartAlertsApi`

## Methods

* [Sensor Insights List Smart Alerts Request](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-list-smart-alerts-request)
* [Sensor Insights Patch Smart Alert Request](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-patch-smart-alert-request)
* [Sensor Insights Bulk Update](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-bulk-update)


# Sensor Insights List Smart Alerts Request

```csharp
SensorInsightsListSmartAlertsRequestAsync(
    Models.DtoListSmartAlertsRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListSmartAlertsRequest`](../../doc/models/dto-list-smart-alerts-request.md) | Body, Required | Retrieve a smart alert |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.UserSmartAlert>](../../doc/models/user-smart-alert.md).

## Example Usage

```csharp
DtoListSmartAlertsRequest body = new DtoListSmartAlertsRequest
{
    Accountname = "0000123456-00001",
    Filter = new DtoFilter
    {
        MExpand = "device detail(s)",
        MLimitnumber = 100,
        MNopagination = true,
        MPage = "The number of pages",
        MPagenumber = 100,
        MProjection = new List<string>
        {
            "specific device fields requested",
        },
        MSelection = new Dictionary<string, object>
        {
            ["additionalProp1"] = ApiHelper.JsonDeserialize<object>("\"string\""),
            ["additionalProp2"] = ApiHelper.JsonDeserialize<object>("\"string\""),
            ["additionalProp3"] = ApiHelper.JsonDeserialize<object>("\"string\""),
        },
    },
    Resourceidentifier = new DtoResourceidentifier
    {
        Id = "cb3eea68-eeee-ffff-gggg-ac4463ccd073",
    },
};

try
{
    ApiResponse<List<UserSmartAlert>> result = await sensorInsightsSmartAlertsApi.SensorInsightsListSmartAlertsRequestAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

```csharp
SensorInsightsPatchSmartAlertRequestAsync(
    Models.DtoPatchSmartAlertRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoPatchSmartAlertRequest`](../../doc/models/dto-patch-smart-alert-request.md) | Body, Required | Partially update a smart alert |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.UserSmartAlert](../../doc/models/user-smart-alert.md).

## Example Usage

```csharp
DtoPatchSmartAlertRequest body = new DtoPatchSmartAlertRequest
{
    Accountname = "0000123456-00001",
    Resourceidentifier = new DtoResourceidentifier
    {
        Id = "0b37ab8b-eeee-ffff-gggg-e0149af43f43",
    },
    Smartalert = new UserSmartAlert
    {
        Createdon = DateTime.ParseExact("2023-10-02T15:46:34.562Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Lastupdated = DateTime.ParseExact("2023-10-02T15:46:34.562Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Versionid = "337bd2e8-eeee-ffff-gggg-5207992fd395",
        Accountclientid = "null",
        Billingaccountid = "0000123456-00001",
        Category = "telemetry",
        Condition = 2592000,
        Description = "a short description",
        Deviceid = "The UUID of the device",
        Foreignid = "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
        Id = "fecbe450-eeee-ffff-gggg-aa166fd5f8e3",
        Isacknowledged = true,
        Iscleared = true,
        Isdisabled = false,
        Name = "User defined name of the record",
        Ruleid = "The UUID of a rule",
        Severity = "minor",
        State = "success",
        Template = "The template ID",
        Version = "1.0",
    },
};

try
{
    ApiResponse<UserSmartAlert> result = await sensorInsightsSmartAlertsApi.SensorInsightsPatchSmartAlertRequestAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

```csharp
SensorInsightsBulkUpdateAsync(
    Models.DtoBulkUpdate body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoBulkUpdate`](../../doc/models/dto-bulk-update.md) | Body, Required | Bulk update smart alerts |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.UserSmartAlert](../../doc/models/user-smart-alert.md).

## Example Usage

```csharp
DtoBulkUpdate body = new DtoBulkUpdate
{
    Accountname = "0000123456-00001",
    Resourceidentifiers = new List<TheIDresourceandDeviceId>
    {
        new TheIDresourceandDeviceId
        {
            Id = "ee70a869-eeee-ffff-gggg-07c14c31f96e",
        },
        new TheIDresourceandDeviceId
        {
            Deviceid = "The UUID of the device",
        },
    },
    Smartalert = new BulkUpdateSmartalert
    {
        Name = "User defined name of the record",
    },
};

try
{
    ApiResponse<UserSmartAlert> result = await sensorInsightsSmartAlertsApi.SensorInsightsBulkUpdateAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

