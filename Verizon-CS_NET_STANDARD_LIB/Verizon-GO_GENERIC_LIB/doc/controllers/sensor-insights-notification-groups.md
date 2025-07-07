# Sensor Insights Notification Groups

```go
sensorInsightsNotificationGroupsApi := client.SensorInsightsNotificationGroupsApi()
```

## Class Name

`SensorInsightsNotificationGroupsApi`

## Methods

* [Sensor Insights List Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-list-notification-group-request)
* [Sensor Insights Update Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-update-notification-group-request)
* [Sensor Insights Create Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-create-notification-group-request)
* [Sensor Insights Delete Notification Group](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-delete-notification-group)
* [Sensor Insights Add Users to Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-add-users-to-notification-group-request)
* [Sensor Insights Remove Users From Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-remove-users-from-notification-group-request)


# Sensor Insights List Notification Group Request

```go
SensorInsightsListNotificationGroupRequest(
    ctx context.Context,
    body models.DtoListNotificationGroupRequest) (
    models.ApiResponse[[]models.DtoNotificationGroupResponseEntity],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoListNotificationGroupRequest`](../../doc/models/dto-list-notification-group-request.md) | Body, Required | Retrieve a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [[]models.DtoNotificationGroupResponseEntity](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoListNotificationGroupRequest{
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

apiResponse, err := sensorInsightsNotificationGroupsApi.SensorInsightsListNotificationGroupRequest(ctx, body)
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


# Sensor Insights Update Notification Group Request

```go
SensorInsightsUpdateNotificationGroupRequest(
    ctx context.Context,
    body models.DtoUpdateNotificationGroupRequest) (
    models.ApiResponse[models.DtoNotificationGroupResponseEntity],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoUpdateNotificationGroupRequest`](../../doc/models/dto-update-notification-group-request.md) | Body, Required | Partially update a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DtoNotificationGroupResponseEntity](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoUpdateNotificationGroupRequest{
    Accountname: models.ToPointer("0000123456-00001"),
    Group:       models.DtoNotificationGroupRequestEntity{
        Description: models.ToPointer("a short description"),
        Groupemail:  models.ToPointer("email@domain.com"),
        Name:        models.ToPointer("User defined name of the record"),
    },
    Id:          models.ToPointer("7b0b9c53-eeee-ffff-gggg-bde5e44f4b12"),
    Userids:     []string{
        "ee70a869-eeee-ffff-gggg-07c14c31f96e",
        "131501ff-eeee-ffff-gggg-647d19179a12",
    },
}

apiResponse, err := sensorInsightsNotificationGroupsApi.SensorInsightsUpdateNotificationGroupRequest(ctx, body)
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


# Sensor Insights Create Notification Group Request

```go
SensorInsightsCreateNotificationGroupRequest(
    ctx context.Context,
    body models.DtoCreateNotificationGroupRequest) (
    models.ApiResponse[models.DtoNotificationGroupResponseEntity],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoCreateNotificationGroupRequest`](../../doc/models/dto-create-notification-group-request.md) | Body, Required | Create a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DtoNotificationGroupResponseEntity](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```go
ctx := context.Background()

body := models.DtoCreateNotificationGroupRequest{
    Accountname: models.ToPointer("0000123456-00001"),
    Group:       models.DtoNotificationGroupRequestEntity{
        Description: models.ToPointer("a short description"),
        Groupemail:  models.ToPointer("email@domain.com"),
        Name:        models.ToPointer("User defined name of the record"),
    },
    Userids:     []string{
        "ee70a869-eeee-ffff-gggg-07c14c31f96e",
        "131501ff-eeee-ffff-gggg-647d19179a12",
    },
}

apiResponse, err := sensorInsightsNotificationGroupsApi.SensorInsightsCreateNotificationGroupRequest(ctx, body)
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


# Sensor Insights Delete Notification Group

```go
SensorInsightsDeleteNotificationGroup(
    ctx context.Context,
    payload models.DtoDeleteNotificationGroupRequest) (
    http.Response,
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `payload` | [`models.DtoDeleteNotificationGroupRequest`](../../doc/models/dto-delete-notification-group-request.md) | Query, Required | Payload for the delete request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```go
ctx := context.Background()

payload := models.DtoDeleteNotificationGroupRequest{
    Accountname: models.ToPointer("0000123456-00001"),
    Force:       models.ToPointer(true),
    Id:          models.ToPointer("6737ca22-eeee-ffff-gggg-84c09f2ede8e"),
}

resp, err := sensorInsightsNotificationGroupsApi.SensorInsightsDeleteNotificationGroup(ctx, payload)
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


# Sensor Insights Add Users to Notification Group Request

```go
SensorInsightsAddUsersToNotificationGroupRequest(
    ctx context.Context,
    body models.DtoAddUsersToNotificationGroupRequest) (
    http.Response,
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoAddUsersToNotificationGroupRequest`](../../doc/models/dto-add-users-to-notification-group-request.md) | Body, Required | Add users to a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```go
ctx := context.Background()

body := models.DtoAddUsersToNotificationGroupRequest{
    Accountname:           models.ToPointer("0000123456-00001"),
    Id:                    models.ToPointer("45f1a56e-eeee-ffff-gggg-68cb994feb5f"),
    Userids:               []string{
        "ee70a869-eeee-ffff-gggg-07c14c31f96e",
        "131501ff-eeee-ffff-gggg-647d19179a12",
    },
}

resp, err := sensorInsightsNotificationGroupsApi.SensorInsightsAddUsersToNotificationGroupRequest(ctx, body)
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
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |


# Sensor Insights Remove Users From Notification Group Request

```go
SensorInsightsRemoveUsersFromNotificationGroupRequest(
    ctx context.Context,
    body models.DtoRemoveUsersFromNotificationGroupRequest) (
    http.Response,
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.DtoRemoveUsersFromNotificationGroupRequest`](../../doc/models/dto-remove-users-from-notification-group-request.md) | Body, Required | Remove users from a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```go
ctx := context.Background()

body := models.DtoRemoveUsersFromNotificationGroupRequest{
    Accountname:           models.ToPointer("0000123456-00001"),
    Id:                    models.ToPointer("111538a8-eeee-ffff-gggg-3b72804403e8"),
    Userids:               []string{
        "ee70a869-eeee-ffff-gggg-07c14c31f96e",
        "131501ff-eeee-ffff-gggg-647d19179a12",
    },
}

resp, err := sensorInsightsNotificationGroupsApi.SensorInsightsRemoveUsersFromNotificationGroupRequest(ctx, body)
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
| 406 | Not Acceptable | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 415 | Unsupported media type | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 429 | Too many requests | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |
| Default | Unexpected error | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |

