# Sensor Insights Notification Groups

```php
$sensorInsightsNotificationGroupsApi = $client->getSensorInsightsNotificationGroupsApi();
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

```php
function sensorInsightsListNotificationGroupRequest(DtoListNotificationGroupRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListNotificationGroupRequest`](../../doc/models/dto-list-notification-group-request.md) | Body, Required | Retrieve a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`DtoNotificationGroupResponseEntity[]`](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```php
$body = DtoListNotificationGroupRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->filter(
        DtoFilterBuilder::init()
            ->mExpand('device detail(s)')
            ->mLimitnumber(100)
            ->mNopagination(true)
            ->mPage('The number of pages')
            ->mPagenumber(100)
            ->mProjection(
                [
                    'specific device fields requested'
                ]
            )
            ->mSelection(
                [
                    'additionalProp1' => ApiHelper::deserialize('"string"'),
                    'additionalProp2' => ApiHelper::deserialize('"string"'),
                    'additionalProp3' => ApiHelper::deserialize('"string"')
                ]
            )
            ->build()
    )
    ->build();

$apiResponse = $sensorInsightsNotificationGroupsApi->sensorInsightsListNotificationGroupRequest($body);
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

```php
function sensorInsightsUpdateNotificationGroupRequest(DtoUpdateNotificationGroupRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoUpdateNotificationGroupRequest`](../../doc/models/dto-update-notification-group-request.md) | Body, Required | Partially update a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`DtoNotificationGroupResponseEntity`](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```php
$body = DtoUpdateNotificationGroupRequestBuilder::init(
    DtoNotificationGroupRequestEntityBuilder::init()
        ->description('a short description')
        ->groupemail('email@domain.com')
        ->name('User defined name of the record')
        ->build()
)
    ->accountname('0000123456-00001')
    ->id('7b0b9c53-eeee-ffff-gggg-bde5e44f4b12')
    ->userids(
        [
            'ee70a869-eeee-ffff-gggg-07c14c31f96e',
            '131501ff-eeee-ffff-gggg-647d19179a12'
        ]
    )
    ->build();

$apiResponse = $sensorInsightsNotificationGroupsApi->sensorInsightsUpdateNotificationGroupRequest($body);
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

```php
function sensorInsightsCreateNotificationGroupRequest(DtoCreateNotificationGroupRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoCreateNotificationGroupRequest`](../../doc/models/dto-create-notification-group-request.md) | Body, Required | Create a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`DtoNotificationGroupResponseEntity`](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```php
$body = DtoCreateNotificationGroupRequestBuilder::init(
    DtoNotificationGroupRequestEntityBuilder::init()
        ->description('a short description')
        ->groupemail('email@domain.com')
        ->name('User defined name of the record')
        ->build()
)
    ->accountname('0000123456-00001')
    ->userids(
        [
            'ee70a869-eeee-ffff-gggg-07c14c31f96e',
            '131501ff-eeee-ffff-gggg-647d19179a12'
        ]
    )
    ->build();

$apiResponse = $sensorInsightsNotificationGroupsApi->sensorInsightsCreateNotificationGroupRequest($body);
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

```php
function sensorInsightsDeleteNotificationGroup(DtoDeleteNotificationGroupRequest $payload): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `payload` | [`DtoDeleteNotificationGroupRequest`](../../doc/models/dto-delete-notification-group-request.md) | Query, Required | Payload for the delete request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```php
$payload = DtoDeleteNotificationGroupRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->force(true)
    ->id('6737ca22-eeee-ffff-gggg-84c09f2ede8e')
    ->build();

$apiResponse = $sensorInsightsNotificationGroupsApi->sensorInsightsDeleteNotificationGroup($payload);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |


# Sensor Insights Add Users to Notification Group Request

```php
function sensorInsightsAddUsersToNotificationGroupRequest(
    DtoAddUsersToNotificationGroupRequest $body
): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoAddUsersToNotificationGroupRequest`](../../doc/models/dto-add-users-to-notification-group-request.md) | Body, Required | Add users to a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```php
$body = DtoAddUsersToNotificationGroupRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->id('45f1a56e-eeee-ffff-gggg-68cb994feb5f')
    ->userids(
        [
            'ee70a869-eeee-ffff-gggg-07c14c31f96e',
            '131501ff-eeee-ffff-gggg-647d19179a12'
        ]
    )
    ->build();

$apiResponse = $sensorInsightsNotificationGroupsApi->sensorInsightsAddUsersToNotificationGroupRequest($body);
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

```php
function sensorInsightsRemoveUsersFromNotificationGroupRequest(
    DtoRemoveUsersFromNotificationGroupRequest $body
): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoRemoveUsersFromNotificationGroupRequest`](../../doc/models/dto-remove-users-from-notification-group-request.md) | Body, Required | Remove users from a notification group |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```php
$body = DtoRemoveUsersFromNotificationGroupRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->id('111538a8-eeee-ffff-gggg-3b72804403e8')
    ->userids(
        [
            'ee70a869-eeee-ffff-gggg-07c14c31f96e',
            '131501ff-eeee-ffff-gggg-647d19179a12'
        ]
    )
    ->build();

$apiResponse = $sensorInsightsNotificationGroupsApi->sensorInsightsRemoveUsersFromNotificationGroupRequest($body);
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

