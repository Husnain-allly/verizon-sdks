# Sensor Insights Device Profile

```csharp
SensorInsightsDeviceProfileApi sensorInsightsDeviceProfileApi = client.SensorInsightsDeviceProfileApi;
```

## Class Name

`SensorInsightsDeviceProfileApi`

## Methods

* [Create a Profile](../../doc/controllers/sensor-insights-device-profile.md#create-a-profile)
* [Delete a Profile](../../doc/controllers/sensor-insights-device-profile.md#delete-a-profile)
* [Update a Profile](../../doc/controllers/sensor-insights-device-profile.md#update-a-profile)
* [Query a Profile](../../doc/controllers/sensor-insights-device-profile.md#query-a-profile)


# Create a Profile

Create a device profile

```csharp
CreateAProfileAsync(
    Models.DtoConfigurationProfile body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoConfigurationProfile`](../../doc/models/dto-configuration-profile.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.DtoProfileResponse>](../../doc/models/dto-profile-response.md).

## Example Usage

```csharp
DtoConfigurationProfile body = new DtoConfigurationProfile
{
    Accountname = "0000123456-00001",
    Profiles = new List<DtoProfile>
    {
        new DtoProfile
        {
            Kind = "the kind of profile being created",
            Version = "1.0",
            Modelid = "00000000-0000-0000-0000-000000000019",
            Name = "Demo Entry sensor 1730928792",
            Configuration = ApiHelper.JsonDeserialize<object>("{\"randomInt\":21,\"resportingInterval\":24}"),
        },
    },
};

try
{
    ApiResponse<List<DtoProfileResponse>> result = await sensorInsightsDeviceProfileApi.CreateAProfileAsync(body);
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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |


# Delete a Profile

Delete a device profile

```csharp
DeleteAProfileAsync(
    Models.DtoConfigurationProfileDelete deleterequest)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deleterequest` | [`DtoConfigurationProfileDelete`](../../doc/models/dto-configuration-profile-delete.md) | Header, Required | payload for the delete request |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.DtoProfileResponse>](../../doc/models/dto-profile-response.md).

## Example Usage

```csharp
DtoConfigurationProfileDelete deleterequest = new DtoConfigurationProfileDelete
{
    AccountName = "0000123456-00001",
};

try
{
    ApiResponse<List<DtoProfileResponse>> result = await sensorInsightsDeviceProfileApi.DeleteAProfileAsync(deleterequest);
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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |


# Update a Profile

Partially update a device profile

```csharp
UpdateAProfileAsync(
    Models.DtoConfigurationProfilePath body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoConfigurationProfilePath`](../../doc/models/dto-configuration-profile-path.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.DtoProfileResponse>](../../doc/models/dto-profile-response.md).

## Example Usage

```csharp
DtoConfigurationProfilePath body = new DtoConfigurationProfilePath
{
    ["accountname"] = ApiHelper.JsonDeserialize<object>("\"0000123456-00001\""),
    ["profiles"] = ApiHelper.JsonDeserialize<object>("[{\"kind\":\"the kind of profile being created\",\"version\":\"1.0\",\"modelid\":\"00000000-0000-0000-0000-000000000019\",\"name\":\"Demo Entry sensor 1730928792\",\"configuration\":{\"randomInt\":21,\"resportingInterval\":24}}]"),
};

try
{
    ApiResponse<List<DtoProfileResponse>> result = await sensorInsightsDeviceProfileApi.UpdateAProfileAsync(body);
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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |


# Query a Profile

Query a device profile for an individual device

```csharp
QueryAProfileAsync(
    Models.ResourceResourceQuery body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ResourceResourceQuery`](../../doc/models/resource-resource-query.md) | Body, Required | body |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.DtoProfileResponse>](../../doc/models/dto-profile-response.md).

## Example Usage

```csharp
ResourceResourceQuery body = new ResourceResourceQuery
{
    Filter = new Devicepropertyfilter
    {
        MSelection = new Devicepropertyselection
        {
            Modelid = "00000000-0000-0000-0000-000000000019",
        },
        MQuerytotalcount = true,
    },
};

try
{
    ApiResponse<List<DtoProfileResponse>> result = await sensorInsightsDeviceProfileApi.QueryAProfileAsync(body);
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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |

