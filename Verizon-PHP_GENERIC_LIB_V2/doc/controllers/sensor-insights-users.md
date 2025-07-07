# Sensor Insights Users

```php
$sensorInsightsUsersApi = $client->getSensorInsightsUsersApi();
```

## Class Name

`SensorInsightsUsersApi`

## Methods

* [Sensor Insights Create User Request](../../doc/controllers/sensor-insights-users.md#sensor-insights-create-user-request)
* [Sensor Insights Delete User](../../doc/controllers/sensor-insights-users.md#sensor-insights-delete-user)
* [Sensor Insights Update User Request](../../doc/controllers/sensor-insights-users.md#sensor-insights-update-user-request)
* [Sensor Insights List User Request](../../doc/controllers/sensor-insights-users.md#sensor-insights-list-user-request)


# Sensor Insights Create User Request

```php
function sensorInsightsCreateUserRequest(DtoCreateUserRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoCreateUserRequest`](../../doc/models/dto-create-user-request.md) | Body, Required | Create a user profile |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ResourceUser`](../../doc/models/resource-user.md).

## Example Usage

```php
$body = DtoCreateUserRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->user(
        DtoUserDtoBuilder::init()
            ->email('email@domain.com')
            ->firstname('First name')
            ->lastname('Last name or Surname')
            ->mdn('908-555-1234')
            ->customdata(
                [
                    'additionalProp1' => ApiHelper::deserialize('[100]'),
                    'additionalProp2' => ApiHelper::deserialize('[100]'),
                    'additionalProp3' => ApiHelper::deserialize('[100]')
                ]
            )
            ->build()
    )
    ->build();

$apiResponse = $sensorInsightsUsersApi->sensorInsightsCreateUserRequest($body);
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

```php
function sensorInsightsDeleteUser(DtoDeleteUserRequest $deleterequestpayload): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deleterequestpayload` | [`DtoDeleteUserRequest`](../../doc/models/dto-delete-user-request.md) | Query, Required | Payload for the delete user request. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```php
$deleterequestpayload = DtoDeleteUserRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->id('8ea30999-eeee-ffff-gggg-3ea409f5fee4')
    ->build();

$apiResponse = $sensorInsightsUsersApi->sensorInsightsDeleteUser($deleterequestpayload);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 404 | Not Found | [`M404ManagementErrorException`](../../doc/models/m404-management-error-exception.md) |


# Sensor Insights Update User Request

```php
function sensorInsightsUpdateUserRequest(DtoUpdateUserRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoUpdateUserRequest`](../../doc/models/dto-update-user-request.md) | Body, Required | Partially update a user profile |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ResourceUser`](../../doc/models/resource-user.md).

## Example Usage

```php
$body = DtoUpdateUserRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->id('9dd573ba-eeee-ffff-gggg-8009758bcaca')
    ->user(
        DtoUserDtoBuilder::init()
            ->email('email@domain.com')
            ->firstname('First name')
            ->lastname('Last name or Surname')
            ->mdn('908-555-1234')
            ->customdata(
                [
                    'additionalProp1' => ApiHelper::deserialize('[100]'),
                    'additionalProp2' => ApiHelper::deserialize('[100]'),
                    'additionalProp3' => ApiHelper::deserialize('[100]')
                ]
            )
            ->build()
    )
    ->build();

$apiResponse = $sensorInsightsUsersApi->sensorInsightsUpdateUserRequest($body);
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

```php
function sensorInsightsListUserRequest(DtoListUserRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListUserRequest`](../../doc/models/dto-list-user-request.md) | Body, Required | A summary of user profile records on an account |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ResourceUser[]`](../../doc/models/resource-user.md).

## Example Usage

```php
$body = DtoListUserRequestBuilder::init()
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

$apiResponse = $sensorInsightsUsersApi->sensorInsightsListUserRequest($body);
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

