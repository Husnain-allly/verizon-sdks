# Sensor Insights Sensors

```php
$sensorInsightsSensorsApi = $client->getSensorInsightsSensorsApi();
```

## Class Name

`SensorInsightsSensorsApi`

## Methods

* [Sensor Insights List Sensor Devices Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-list-sensor-devices-request)
* [Sensor Insights on Board Sensor Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-on-board-sensor-request)
* [Sensor Insights Sensor on Board Status Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-sensor-on-board-status-request)
* [Sensor Insights Off Board Sensor Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-off-board-sensor-request)
* [Sensor Insights Sensor Off Boarding Status Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-sensor-off-boarding-status-request)


# Sensor Insights List Sensor Devices Request

```php
function sensorInsightsListSensorDevicesRequest(DtoListSensorDevicesRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListSensorDevicesRequest`](../../doc/models/dto-list-sensor-devices-request.md) | Body, Required | List details of the sensors |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ResourceDevice[]`](../../doc/models/resource-device.md).

## Example Usage

```php
$body = DtoListSensorDevicesRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->filter(
        DtoFilterBuilder::init()
            ->mExpand('device detail(s)')
            ->mLimitnumber(100)
            ->mNopagination(true)
            ->mPage('The number of pages')
            ->mPagenumber(1)
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
    ->resourceidentifier(
        DtoDeviceResourceIdentifierBuilder::init()
            ->deveui('The unique EUI64 address of the device')
            ->deviceid('The UUID of the device')
            ->esn(223372036854775800)
            ->iccid('The 20-digit Integrated Circuit Card ID (SIM card ID)')
            ->imei(223372036854775)
            ->imsi(223372036854775800)
            ->mac('The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX')
            ->manufacturer('REOLINK')
            ->meid('The 56-bit Mobile Equipment ID')
            ->msisdn('The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number')
            ->nodeUuid('The UUID of the node the device is associated with')
            ->qrcode('The Quick Response (QR) code')
            ->serial('The device\'s serial number')
            ->build()
    )
    ->build();

$apiResponse = $sensorInsightsSensorsApi->sensorInsightsListSensorDevicesRequest($body);
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


# Sensor Insights on Board Sensor Request

```php
function sensorInsightsOnBoardSensorRequest(DtoOnBoardSensorRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOnBoardSensorRequest`](../../doc/models/dto-on-board-sensor-request.md) | Body, Required | Onboarding a sensor |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```php
$body = DtoOnBoardSensorRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->payload(
        PayloadBuilder::init()
            ->addsensor(
                ResourceOnBoardSensorBuilder::init(
                    'The unique EUI64 address of the device',
                    'global application ID in IEEE EUI64 address space that uniquely identifies the entity able to process the JoinReq frame',
                    'Encryption key used for messages during every over the air activation',
                    'A',
                    'ts.device.sensor.lorawan.radiobridge.RBS301-DWS-US',
                    'used to identify water leaks',
                    'Water Leak sensor'
                )
                    ->customdata(
                        [
                            'additionalProp1' => ApiHelper::deserialize('[100]'),
                            'additionalProp2' => ApiHelper::deserialize('[100]'),
                            'additionalProp3' => ApiHelper::deserialize('[100]')
                        ]
                    )
                    ->build()
            )
            ->build()
    )
    ->build();

$apiResponse = $sensorInsightsSensorsApi->sensorInsightsOnBoardSensorRequest($body);
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


# Sensor Insights Sensor on Board Status Request

```php
function sensorInsightsSensorOnBoardStatusRequest(DtoSensorOnBoardStatusRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoSensorOnBoardStatusRequest`](../../doc/models/dto-sensor-on-board-status-request.md) | Body, Required | Get the sensor's onboarding status |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`DtoSensorOnBoardingStatusResponse`](../../doc/models/dto-sensor-on-boarding-status-response.md).

## Example Usage

```php
$body = DtoSensorOnBoardStatusRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->gatewayidentifier(
        GatewayidentifierBuilder::init()
            ->deviceid('00000000-0000-0000-0000-000000000255')
            ->build()
    )
    ->onboarding(
        OnboardingBuilder::init()
            ->additionalProperty('sensoridentifiers', ApiHelper::deserialize('{"deveui":"The unique EUI64 address of the device"}'))
            ->build()
    )
    ->build();

$apiResponse = $sensorInsightsSensorsApi->sensorInsightsSensorOnBoardStatusRequest($body);
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


# Sensor Insights Off Board Sensor Request

```php
function sensorInsightsOffBoardSensorRequest(DtoOffBoardSensorRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOffBoardSensorRequest`](../../doc/models/dto-off-board-sensor-request.md) | Body, Required | Offboard a sensor |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```php
$body = DtoOffBoardSensorRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->configuration(
        SensorinsightsconfigBuilder::init()
            ->removesensor(
                DtoOffBoardSensorBuilder::init()
                    ->deveui('The unique EUI64 address of the device')
                    ->build()
            )
            ->build()
    )
    ->build();

$apiResponse = $sensorInsightsSensorsApi->sensorInsightsOffBoardSensorRequest($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`M400ManagementErrorException`](../../doc/models/m400-management-error-exception.md) |
| 401 | UnAuthorized | [`ManagementErrorException`](../../doc/models/management-error-exception.md) |
| 403 | Forbidden | [`M403ManagementErrorException`](../../doc/models/m403-management-error-exception.md) |


# Sensor Insights Sensor Off Boarding Status Request

```php
function sensorInsightsSensorOffBoardingStatusRequest(DtoSensorOffBoardStatusRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoSensorOffBoardStatusRequest`](../../doc/models/dto-sensor-off-board-status-request.md) | Body, Required | Get a sensor's offboarding status |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`DtoSensorOffBoardingStatusResponse`](../../doc/models/dto-sensor-off-boarding-status-response.md).

## Example Usage

```php
$body = DtoSensorOffBoardStatusRequestBuilder::init()
    ->accountname('0000123456-00001')
    ->gatewayidentifier(
        GatewayidentifierBuilder::init()
            ->deviceid('UUID of the Gateway device')
            ->build()
    )
    ->offboarding(
        OffboardingBuilder::init()
            ->additionalProperty('sensoridentifiers', ApiHelper::deserialize('{"deveui":"The unique EUI64 address of the device"}'))
            ->build()
    )
    ->build();

$apiResponse = $sensorInsightsSensorsApi->sensorInsightsSensorOffBoardingStatusRequest($body);
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

