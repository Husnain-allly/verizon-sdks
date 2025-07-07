# Sensor Insights Rules

```csharp
SensorInsightsRulesApi sensorInsightsRulesApi = client.SensorInsightsRulesApi;
```

## Class Name

`SensorInsightsRulesApi`

## Methods

* [Sensor Insights Overwrite Rule Request](../../doc/controllers/sensor-insights-rules.md#sensor-insights-overwrite-rule-request)
* [Sensor Insights List Rules Request](../../doc/controllers/sensor-insights-rules.md#sensor-insights-list-rules-request)


# Sensor Insights Overwrite Rule Request

```csharp
SensorInsightsOverwriteRuleRequestAsync(
    Models.DtoOverwriteRuleRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOverwriteRuleRequest`](../../doc/models/dto-overwrite-rule-request.md) | Body, Required | Overwrite a rule |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ResourceRule](../../doc/models/resource-rule.md).

## Example Usage

```csharp
DtoOverwriteRuleRequest body = new DtoOverwriteRuleRequest
{
    Accountname = "0000123456-00001",
    Resourceidentifier = new DtoResourceidentifier
    {
        Id = "7f5f610a-eeee-ffff-gggg-4d20cf3dcfbc",
    },
    Rule = new ResourceRule
    {
        Createdon = DateTime.ParseExact("2023-10-02T15:46:34.562Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Foreignid = "c1f178d3-eeee-ffff-gggg-0d6b7ae6022a",
        Lastupdated = DateTime.ParseExact("2023-10-02T15:46:34.562Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
            provider: CultureInfo.InvariantCulture,
            DateTimeStyles.RoundtripKind),
        Rulechain = ApiHelper.JsonDeserialize<object>("{}"),
        Versionid = "337bd2e8-eeee-ffff-gggg-5207992fd395",
        Accountclientid = "null",
        Billingaccountid = "The billing account ID",
        Description = "a short description",
        Deviceid = "The UUID of the device",
        Disabled = true,
        Id = "bc5b5b5a-eeee-ffff-gggg-cb2cb2533d47",
        Name = "User defined name of the record",
        Rulesyntax = "The rule syntax",
        Version = "1.0",
    },
};

try
{
    ApiResponse<ResourceRule> result = await sensorInsightsRulesApi.SensorInsightsOverwriteRuleRequestAsync(body);
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


# Sensor Insights List Rules Request

```csharp
SensorInsightsListRulesRequestAsync(
    Models.DtoListRulesRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListRulesRequest`](../../doc/models/dto-list-rules-request.md) | Body, Required | Retrieve a rule |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.ResourceRule>](../../doc/models/resource-rule.md).

## Example Usage

```csharp
DtoListRulesRequest body = new DtoListRulesRequest
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
        Id = "ffb86390-eeee-ffff-gggg-9d1180882d63",
    },
};

try
{
    ApiResponse<List<ResourceRule>> result = await sensorInsightsRulesApi.SensorInsightsListRulesRequestAsync(body);
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

