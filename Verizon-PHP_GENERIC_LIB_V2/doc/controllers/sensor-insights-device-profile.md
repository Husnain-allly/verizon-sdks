# Sensor Insights Device Profile

```php
$sensorInsightsDeviceProfileApi = $client->getSensorInsightsDeviceProfileApi();
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

```php
function createAProfile(DtoConfigurationProfile $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoConfigurationProfile`](../../doc/models/dto-configuration-profile.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`DtoProfileResponse[]`](../../doc/models/dto-profile-response.md).

## Example Usage

```php
$body = DtoConfigurationProfileBuilder::init()
    ->accountname('0000123456-00001')
    ->profiles(
        [
            DtoProfileBuilder::init()
                ->kind('the kind of profile being created')
                ->version('1.0')
                ->modelid('00000000-0000-0000-0000-000000000019')
                ->name('Demo Entry sensor 1730928792')
                ->configuration(ApiHelper::deserialize('{"randomInt":21,"resportingInterval":24}'))
                ->build()
        ]
    )
    ->build();

$apiResponse = $sensorInsightsDeviceProfileApi->createAProfile($body);
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

```php
function deleteAProfile(DtoConfigurationProfileDelete $deleterequest): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deleterequest` | [`DtoConfigurationProfileDelete`](../../doc/models/dto-configuration-profile-delete.md) | Header, Required | payload for the delete request |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`DtoProfileResponse[]`](../../doc/models/dto-profile-response.md).

## Example Usage

```php
$deleterequest = DtoConfigurationProfileDeleteBuilder::init()
    ->accountName('0000123456-00001')
    ->build();

$apiResponse = $sensorInsightsDeviceProfileApi->deleteAProfile($deleterequest);
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

```php
function updateAProfile(DtoConfigurationProfilePath $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoConfigurationProfilePath`](../../doc/models/dto-configuration-profile-path.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`DtoProfileResponse[]`](../../doc/models/dto-profile-response.md).

## Example Usage

```php
$body = DtoConfigurationProfilePathBuilder::init()
    ->additionalProperty('accountname', ApiHelper::deserialize('"0000123456-00001"'))
    ->additionalProperty('profiles', ApiHelper::deserialize('[{"kind":"the kind of profile being created","version":"1.0","modelid":"00000000-0000-0000-0000-000000000019","name":"Demo Entry sensor 1730928792","configuration":{"randomInt":21,"resportingInterval":24}}]'))
    ->build();

$apiResponse = $sensorInsightsDeviceProfileApi->updateAProfile($body);
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

```php
function queryAProfile(ResourceResourceQuery $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ResourceResourceQuery`](../../doc/models/resource-resource-query.md) | Body, Required | body |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`DtoProfileResponse[]`](../../doc/models/dto-profile-response.md).

## Example Usage

```php
$body = ResourceResourceQueryBuilder::init()
    ->filter(
        DevicepropertyfilterBuilder::init()
            ->mSelection(
                DevicepropertyselectionBuilder::init()
                    ->modelid('00000000-0000-0000-0000-000000000019')
                    ->build()
            )
            ->mQuerytotalcount(true)
            ->build()
    )
    ->build();

$apiResponse = $sensorInsightsDeviceProfileApi->queryAProfile($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |
| 500 | Internal server error. | [`M500ManagementErrorException`](../../doc/models/m500-management-error-exception.md) |

