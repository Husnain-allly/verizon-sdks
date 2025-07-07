# Sensor Insights Device Profile

```go
sensorInsightsDeviceProfileApi := client.SensorInsightsDeviceProfileApi()
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

```go
CreateAProfile(
    ctx context.Context,
    body models.DtoConfigurationProfile) (
    models.ApiResponse[[]models.DtoProfileResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoConfigurationProfile`](../../doc/models/dto-configuration-profile.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DtoProfileResponse](../../doc/models/dto-profile-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoConfigurationProfile{
    Accountname:           models.ToPointer("0000123456-00001"),
    Profiles:              []models.DtoProfile{
        models.DtoProfile{
            Kind:                  models.ToPointer("the kind of profile being created"),
            Version:               models.ToPointer("1.0"),
            Modelid:               models.ToPointer("00000000-0000-0000-0000-000000000019"),
            Name:                  models.ToPointer("Demo Entry sensor 1730928792"),
            Configuration:         models.ToPointer(interface{}("[randomInt, 21][resportingInterval, 24]")),
        },
    },
}

apiResponse, err := sensorInsightsDeviceProfileApi.CreateAProfile(ctx, body)
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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |


# Delete a Profile

Delete a device profile

```go
DeleteAProfile(
    ctx context.Context,
    deleterequest models.DtoConfigurationProfileDelete) (
    models.ApiResponse[[]models.DtoProfileResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deleterequest` | [`models.DtoConfigurationProfileDelete`](../../doc/models/dto-configuration-profile-delete.md) | Header, Required | payload for the delete request |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DtoProfileResponse](../../doc/models/dto-profile-response.md).

## Example Usage

```go
ctx := context.Background()

deleterequest := models.DtoConfigurationProfileDelete{
    AccountName:           models.ToPointer("0000123456-00001"),
}

apiResponse, err := sensorInsightsDeviceProfileApi.DeleteAProfile(ctx, deleterequest)
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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |


# Update a Profile

Partially update a device profile

```go
UpdateAProfile(
    ctx context.Context,
    body models.DtoConfigurationProfilePath) (
    models.ApiResponse[[]models.DtoProfileResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoConfigurationProfilePath`](../../doc/models/dto-configuration-profile-path.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DtoProfileResponse](../../doc/models/dto-profile-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoConfigurationProfilePath{
    AdditionalProperties:  map[string]interface{}{
        "accountname": interface{}("0000123456-00001"),
        "profiles": interface{}("System.Collections.Generic.Dictionary`2[System.String,System.Object]"),
    },
}

apiResponse, err := sensorInsightsDeviceProfileApi.UpdateAProfile(ctx, body)
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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |


# Query a Profile

Query a device profile for an individual device

```go
QueryAProfile(
    ctx context.Context,
    body models.ResourceResourceQuery) (
    models.ApiResponse[[]models.DtoProfileResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.ResourceResourceQuery`](../../doc/models/resource-resource-query.md) | Body, Required | body |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DtoProfileResponse](../../doc/models/dto-profile-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.ResourceResourceQuery{
    Filter: models.ToPointer(models.Devicepropertyfilter{
        MSelection:            models.ToPointer(models.Devicepropertyselection{
            Modelid:               models.ToPointer("00000000-0000-0000-0000-000000000019"),
        }),
        MQuerytotalcount:      models.ToPointer(true),
    }),
}

apiResponse, err := sensorInsightsDeviceProfileApi.QueryAProfile(ctx, body)
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
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |

