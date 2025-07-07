# Sensor Insights Users

```csharp
SensorInsightsUsersApi sensorInsightsUsersApi = client.SensorInsightsUsersApi;
```

## Class Name

`SensorInsightsUsersApi`

## Methods

* [Sensor Insights Create User Request](../../doc/controllers/sensor-insights-users.md#sensor-insights-create-user-request)
* [Sensor Insights Delete User](../../doc/controllers/sensor-insights-users.md#sensor-insights-delete-user)
* [Sensor Insights Update User Request](../../doc/controllers/sensor-insights-users.md#sensor-insights-update-user-request)
* [Sensor Insights List User Request](../../doc/controllers/sensor-insights-users.md#sensor-insights-list-user-request)


# Sensor Insights Create User Request

```csharp
SensorInsightsCreateUserRequestAsync(
    Models.DtoCreateUserRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoCreateUserRequest`](../../doc/models/dto-create-user-request.md) | Body, Required | Create a user profile |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ResourceUser](../../doc/models/resource-user.md).

## Example Usage

```csharp
DtoCreateUserRequest body = new DtoCreateUserRequest
{
    Accountname = "0000123456-00001",
    User = new DtoUserDto
    {
        Email = "email@domain.com",
        Firstname = "First name",
        Lastname = "Last name or Surname",
        Mdn = "908-555-1234",
        Customdata = new Dictionary<string, object>
        {
            ["additionalProp1"] = ApiHelper.JsonDeserialize<object>("[100]"),
            ["additionalProp2"] = ApiHelper.JsonDeserialize<object>("[100]"),
            ["additionalProp3"] = ApiHelper.JsonDeserialize<object>("[100]"),
        },
    },
};

try
{
    ApiResponse<ResourceUser> result = await sensorInsightsUsersApi.SensorInsightsCreateUserRequestAsync(body);
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
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Delete User

```csharp
SensorInsightsDeleteUserAsync(
    Models.DtoDeleteUserRequest deleterequestpayload)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deleterequestpayload` | [`DtoDeleteUserRequest`](../../doc/models/dto-delete-user-request.md) | Query, Required | Payload for the delete user request. |

## Response Type

`Task`

## Example Usage

```csharp
DtoDeleteUserRequest deleterequestpayload = new DtoDeleteUserRequest
{
    Accountname = "0000123456-00001",
    Id = "8ea30999-eeee-ffff-gggg-3ea409f5fee4",
};

try
{
    await sensorInsightsUsersApi.SensorInsightsDeleteUserAsync(deleterequestpayload);
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


# Sensor Insights Update User Request

```csharp
SensorInsightsUpdateUserRequestAsync(
    Models.DtoUpdateUserRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoUpdateUserRequest`](../../doc/models/dto-update-user-request.md) | Body, Required | Partially update a user profile |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.ResourceUser](../../doc/models/resource-user.md).

## Example Usage

```csharp
DtoUpdateUserRequest body = new DtoUpdateUserRequest
{
    Accountname = "0000123456-00001",
    Id = "9dd573ba-eeee-ffff-gggg-8009758bcaca",
    User = new DtoUserDto
    {
        Email = "email@domain.com",
        Firstname = "First name",
        Lastname = "Last name or Surname",
        Mdn = "908-555-1234",
        Customdata = new Dictionary<string, object>
        {
            ["additionalProp1"] = ApiHelper.JsonDeserialize<object>("[100]"),
            ["additionalProp2"] = ApiHelper.JsonDeserialize<object>("[100]"),
            ["additionalProp3"] = ApiHelper.JsonDeserialize<object>("[100]"),
        },
    },
};

try
{
    ApiResponse<ResourceUser> result = await sensorInsightsUsersApi.SensorInsightsUpdateUserRequestAsync(body);
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


# Sensor Insights List User Request

```csharp
SensorInsightsListUserRequestAsync(
    Models.DtoListUserRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListUserRequest`](../../doc/models/dto-list-user-request.md) | Body, Required | A summary of user profile records on an account |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [List<Models.ResourceUser>](../../doc/models/resource-user.md).

## Example Usage

```csharp
DtoListUserRequest body = new DtoListUserRequest
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
};

try
{
    ApiResponse<List<ResourceUser>> result = await sensorInsightsUsersApi.SensorInsightsListUserRequestAsync(body);
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

