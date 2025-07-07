# App Config Service

```php
$appConfigServiceApi = $client->getAppConfigServiceApi();
```

## Class Name

`AppConfigServiceApi`

## Methods

* [Get Configuration List](../../doc/controllers/app-config-service.md#get-configuration-list)
* [Get Configuration](../../doc/controllers/app-config-service.md#get-configuration)
* [Create Configuration](../../doc/controllers/app-config-service.md#create-configuration)
* [Update Configuration](../../doc/controllers/app-config-service.md#update-configuration)
* [Delete Configuration](../../doc/controllers/app-config-service.md#delete-configuration)


# Get Configuration List

This endpoint fetches and returns the list of configurations defined by the Vendor. The list contains the configurations' identifier, name, description, and active flag. The vendor ID is provided when the configuration is created through the POST request.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```php
function getConfigurationList(string $vendorId): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ConfigurationListItem[]`](../../doc/models/configuration-list-item.md).

## Example Usage

```php
$vendorId = 'VerizonETX';

$apiResponse = $appConfigServiceApi->getConfigurationList($vendorId);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 404 | Configuration not found | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 429 | Too many requests | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| Default | unexpected error | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |


# Get Configuration

This endpoint fetches and returns a specific configuration's details. The configuration ID parameter, which was provided when the configuration was created through the POST request, is need to retrieve the configuration details.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```php
function getConfiguration(string $id, string $vendorId): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `vendorId` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GeoFenceConfigurationResponse`](../../doc/models/geo-fence-configuration-response.md).

## Example Usage

```php
$id = '18bac1ff-c7bd-44d9-a7ad-06a093a94713';

$vendorId = 'VerizonETX';

$apiResponse = $appConfigServiceApi->getConfiguration(
    $id,
    $vendorId
);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 404 | Configuration not found | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 429 | Too many requests | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| Default | unexpected error | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |


# Create Configuration

This endpoint creates a new configuration in the system. The data for the new configuration should be provided as JSON in the body of the POST request. The system will return with a unique ID for the configuration, which is needed for any further manipulation (update or delete) of the configuration.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```php
function createConfiguration(string $vendorId, GeoFenceConfigurationRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | [`GeoFenceConfigurationRequest`](../../doc/models/geo-fence-configuration-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GeoFenceConfigurationResponse`](../../doc/models/geo-fence-configuration-response.md).

## Example Usage

```php
$vendorId = 'VerizonETX';

$body = GeoFenceConfigurationRequestBuilder::init(
    EtxGeofenceBuilder::init(
        FeatureCollectionType::FEATURECOLLECTION,
        [
            GeoFeatureBuilder::init(
                FeatureType::FEATURE,
                ApiHelper::deserialize('{"key1":"val1","key2":"val2"}'),
                ApiHelper::deserialize('{"key1":"val1","key2":"val2"}')
            )->build()
        ]
    )->build(),
    [
        ApiHelper::deserialize('{"key1":"val1","key2":"val2"}')
    ],
    false
)->build();

$apiResponse = $appConfigServiceApi->createConfiguration(
    $vendorId,
    $body
);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid configuration | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 403 | Forbidden | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 429 | Too many requests | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| Default | unexpected error | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |


# Update Configuration

This endpoint updates an existing configuration. Similar to POST, the updated data for the configuration should be provided as JSON in the body of the PUT request. The configuration ID parameter, which was provided by the POST (create) operation, is required to do any updates on the configuration.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```php
function updateConfiguration(
    string $vendorId,
    string $id,
    GeoFenceConfigurationUpdateRequest $body
): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `id` | `string` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |
| `body` | [`GeoFenceConfigurationUpdateRequest`](../../doc/models/geo-fence-configuration-update-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```php
$vendorId = 'VerizonETX';

$id = '18bac1ff-c7bd-44d9-a7ad-06a093a94713';

$body = GeoFenceConfigurationUpdateRequestBuilder::init()->build();

$apiResponse = $appConfigServiceApi->updateConfiguration(
    $vendorId,
    $id,
    $body
);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid configuration | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 403 | Forbidden | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 404 | Configuration not found | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 429 | Too many requests | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| Default | unexpected error | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |


# Delete Configuration

This endpoint deletes a specific configuration from the system. It requires the configuration ID parameter, which was provided by the POST (create) operation.

Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```php
function deleteConfiguration(string $vendorId, string $id): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The vendor's identifier<br><br>**Constraints**: *Minimum Length*: `1`, *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `id` | `string` | Query, Required | The configuration identifier<br><br>**Constraints**: *Minimum Length*: `32`, *Maximum Length*: `36`, *Pattern*: `^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```php
$vendorId = 'VerizonETX';

$id = '18bac1ff-c7bd-44d9-a7ad-06a093a94713';

$apiResponse = $appConfigServiceApi->deleteConfiguration(
    $vendorId,
    $id
);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 403 | Forbidden | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| 429 | Too many requests | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |
| Default | unexpected error | [`AppConfigResponseErrorException`](../../doc/models/app-config-response-error-exception.md) |

