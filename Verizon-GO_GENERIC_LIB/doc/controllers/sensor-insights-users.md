# Sensor Insights Users

```go
sensorInsightsUsersApi := client.SensorInsightsUsersApi()
```

## Class Name

`SensorInsightsUsersApi`

## Methods

* [Sensor Insights Create User Request](../../doc/controllers/sensor-insights-users.md#sensor-insights-create-user-request)
* [Sensor Insights Delete User](../../doc/controllers/sensor-insights-users.md#sensor-insights-delete-user)
* [Sensor Insights Update User Request](../../doc/controllers/sensor-insights-users.md#sensor-insights-update-user-request)
* [Sensor Insights List User Request](../../doc/controllers/sensor-insights-users.md#sensor-insights-list-user-request)


# Sensor Insights Create User Request

```go
SensorInsightsCreateUserRequest(
    ctx context.Context,
    body models.DtoCreateUserRequest) (
    models.ApiResponse[models.ResourceUser],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoCreateUserRequest`](../../doc/models/dto-create-user-request.md) | Body, Required | Create a user profile |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ResourceUser](../../doc/models/resource-user.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoCreateUserRequest{
    Accountname: models.ToPointer("0000123456-00001"),
    User:        models.ToPointer(models.DtoUserDto{
        Email:      models.ToPointer("email@domain.com"),
        Firstname:  models.ToPointer("First name"),
        Lastname:   models.ToPointer("Last name or Surname"),
        Mdn:        models.ToPointer("908-555-1234"),
        Customdata: map[string]interface{}{
            "additionalProp1": interface{}("100"),
            "additionalProp2": interface{}("100"),
            "additionalProp3": interface{}("100"),
        },
    }),
}

apiResponse, err := sensorInsightsUsersApi.SensorInsightsCreateUserRequest(ctx, body)
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
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Delete User

```go
SensorInsightsDeleteUser(
    ctx context.Context,
    deleterequestpayload models.DtoDeleteUserRequest) (
    http.Response,
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deleterequestpayload` | [`models.DtoDeleteUserRequest`](../../doc/models/dto-delete-user-request.md) | Query, Required | Payload for the delete user request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```go
ctx := context.Background()

deleterequestpayload := models.DtoDeleteUserRequest{
    Accountname: models.ToPointer("0000123456-00001"),
    Id:          models.ToPointer("8ea30999-eeee-ffff-gggg-3ea409f5fee4"),
}

resp, err := sensorInsightsUsersApi.SensorInsightsDeleteUser(ctx, deleterequestpayload)
if err != nil {
    log.Fatalln(err)
} else {
    fmt.Println(resp.StatusCode)
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

```go
SensorInsightsUpdateUserRequest(
    ctx context.Context,
    body models.DtoUpdateUserRequest) (
    models.ApiResponse[models.ResourceUser],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoUpdateUserRequest`](../../doc/models/dto-update-user-request.md) | Body, Required | Partially update a user profile |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ResourceUser](../../doc/models/resource-user.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoUpdateUserRequest{
    Accountname: models.ToPointer("0000123456-00001"),
    Id:          models.ToPointer("9dd573ba-eeee-ffff-gggg-8009758bcaca"),
    User:        models.ToPointer(models.DtoUserDto{
        Email:      models.ToPointer("email@domain.com"),
        Firstname:  models.ToPointer("First name"),
        Lastname:   models.ToPointer("Last name or Surname"),
        Mdn:        models.ToPointer("908-555-1234"),
        Customdata: map[string]interface{}{
            "additionalProp1": interface{}("100"),
            "additionalProp2": interface{}("100"),
            "additionalProp3": interface{}("100"),
        },
    }),
}

apiResponse, err := sensorInsightsUsersApi.SensorInsightsUpdateUserRequest(ctx, body)
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


# Sensor Insights List User Request

```go
SensorInsightsListUserRequest(
    ctx context.Context,
    body models.DtoListUserRequest) (
    models.ApiResponse[[]models.ResourceUser],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoListUserRequest`](../../doc/models/dto-list-user-request.md) | Body, Required | A summary of user profile records on an account |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.ResourceUser](../../doc/models/resource-user.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoListUserRequest{
    Accountname: models.ToPointer("0000123456-00001"),
    Filter:      models.ToPointer(models.DtoFilter{
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
}

apiResponse, err := sensorInsightsUsersApi.SensorInsightsListUserRequest(ctx, body)
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

