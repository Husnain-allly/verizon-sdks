# Managinge SIM Profiles

```php
$managingeSimProfilesApi = $client->getManagingeSimProfilesApi();
```

## Class Name

`ManagingeSimProfilesApi`

## Methods

* [Resume Profile](../../doc/controllers/managinge-sim-profiles.md#resume-profile)
* [Profile Suspend](../../doc/controllers/managinge-sim-profiles.md#profile-suspend)
* [Device Suspend](../../doc/controllers/managinge-sim-profiles.md#device-suspend)
* [Set Fallback](../../doc/controllers/managinge-sim-profiles.md#set-fallback)
* [Activate a Device Profile](../../doc/controllers/managinge-sim-profiles.md#activate-a-device-profile)
* [Enable a Device Profile](../../doc/controllers/managinge-sim-profiles.md#enable-a-device-profile)
* [Deactivate a Device Profile](../../doc/controllers/managinge-sim-profiles.md#deactivate-a-device-profile)
* [Enable a Device Profile for Download](../../doc/controllers/managinge-sim-profiles.md#enable-a-device-profile-for-download)
* [Download a Device Profile](../../doc/controllers/managinge-sim-profiles.md#download-a-device-profile)
* [Delete a Device Profile](../../doc/controllers/managinge-sim-profiles.md#delete-a-device-profile)


# Resume Profile

Resume service to a device with either a lead or local profile.

```php
function resumeProfile(GioProfileRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```php
$body = GioProfileRequestBuilder::init(
    [
        GioDeviceListBuilder::init()->build()
    ],
    '0000123456-00001'
)
    ->mdnZipCode('12345')
    ->servicePlan('service plan name')
    ->build();

$apiResponse = $managingEsimProfilesApi->resumeProfile($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Profile Suspend

Suspend a device's Global profile.

```php
function profileSuspend(GioProfileRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```php
$body = GioProfileRequestBuilder::init(
    [
        GioDeviceListBuilder::init()->build()
    ],
    '0000123456-00001'
)
    ->mdnZipCode('12345')
    ->servicePlan('service plan name')
    ->build();

$apiResponse = $managingEsimProfilesApi->profileSuspend($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Device Suspend

Suspend all service to an eUICC device, including the lead and local profile.

```php
function deviceSuspend(GioProfileRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```php
$body = GioProfileRequestBuilder::init(
    [
        GioDeviceListBuilder::init()->build()
    ],
    '0000123456-00001'
)
    ->mdnZipCode('12345')
    ->servicePlan('service plan name')
    ->build();

$apiResponse = $managingEsimProfilesApi->deviceSuspend($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Set Fallback

Enable a fallback profile to be set.

```php
function setFallback(FallBack $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`FallBack`](../../doc/models/fall-back.md) | Body, Required | Set the fallback attributes to allow a fallback profile to be activated. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```php
$body = FallBackBuilder::init()->build();

$apiResponse = $managingEsimProfilesApi->setFallback($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Activate a Device Profile

Activate a device with either a lead or local profile.

```php
function activateADeviceProfile(GioProfileRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```php
$body = GioProfileRequestBuilder::init(
    [
        GioDeviceListBuilder::init()->build()
    ],
    '0000123456-00001'
)
    ->mdnZipCode('12345')
    ->servicePlan('service plan name')
    ->build();

$apiResponse = $managingEsimProfilesApi->activateADeviceProfile($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Enable a Device Profile

Enable a device lead or local profile.

```php
function enableADeviceProfile(DeviceProfileRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```php
$body = DeviceProfileRequestBuilder::init()
    ->accountName('0000123456-00001')
    ->servicePlan('service plan name')
    ->build();

$apiResponse = $managingEsimProfilesApi->enableADeviceProfile($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Deactivate a Device Profile

Deactivate the lead or local profile. **Note:** to reactivate the profile, use the **Activate** endpoint above.

```php
function deactivateADeviceProfile(GioDeactivateDeviceProfileRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioDeactivateDeviceProfileRequest`](../../doc/models/gio-deactivate-device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```php
$body = GioDeactivateDeviceProfileRequestBuilder::init()
    ->accountName('0000123456-00001')
    ->servicePlan('service plan name')
    ->etfWaiver(false)
    ->reasonCode('FF')
    ->build();

$apiResponse = $managingEsimProfilesApi->deactivateADeviceProfile($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Enable a Device Profile for Download

Enable the Global IoT Orchestration device profile for download.

```php
function enableADeviceProfileForDownload(DeviceProfileRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```php
$body = DeviceProfileRequestBuilder::init()
    ->accountName('0000123456-00001')
    ->servicePlan('service plan name')
    ->build();

$apiResponse = $managingEsimProfilesApi->enableADeviceProfileForDownload($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Download a Device Profile

Download a Global IoT Orchestration device profile.

```php
function downloadADeviceProfile(DeviceProfileRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```php
$body = DeviceProfileRequestBuilder::init()
    ->accountName('0000123456-00001')
    ->servicePlan('service plan name')
    ->build();

$apiResponse = $managingEsimProfilesApi->downloadADeviceProfile($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Delete a Device Profile

Delete a device profile for Global IoT Orchestration. **Note:** the profile must be deactivated first!

```php
function deleteADeviceProfile(DeviceProfileRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```php
$body = DeviceProfileRequestBuilder::init()
    ->accountName('0000123456-00001')
    ->servicePlan('service plan name')
    ->build();

$apiResponse = $managingEsimProfilesApi->deleteADeviceProfile($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |

