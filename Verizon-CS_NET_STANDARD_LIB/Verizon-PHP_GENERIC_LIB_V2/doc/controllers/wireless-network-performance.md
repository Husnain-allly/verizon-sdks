# Wireless Network Performance

```php
$wirelessNetworkPerformanceApi = $client->getWirelessNetworkPerformanceApi();
```

## Class Name

`WirelessNetworkPerformanceApi`

## Methods

* [Near Real Time Network Conditions](../../doc/controllers/wireless-network-performance.md#near-real-time-network-conditions)
* [Domestic 4 G and 5G Nationwide Network Coverage](../../doc/controllers/wireless-network-performance.md#domestic-4-g-and-5g-nationwide-network-coverage)
* [Site Proximity](../../doc/controllers/wireless-network-performance.md#site-proximity)
* [Device Experience 30 Days History](../../doc/controllers/wireless-network-performance.md#device-experience-30-days-history)
* [Device Experience Bulk Latest](../../doc/controllers/wireless-network-performance.md#device-experience-bulk-latest)


# Near Real Time Network Conditions

WNP Query for current network condition.

```php
function nearRealTimeNetworkConditions(GetNetworkConditionsRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetNetworkConditionsRequest`](../../doc/models/get-network-conditions-request.md) | Body, Required | Request for current network health. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`WnpRequestResponse`](../../doc/models/wnp-request-response.md).

## Example Usage

```php
$body = GetNetworkConditionsRequestBuilder::init(
    '0000123456-00001',
    'LONGLAT',
    CoordinatesBuilder::init()
        ->latitude('-33.84819')
        ->longitude('151.22049')
        ->build()
)->build();

$apiResponse = $wirelessNetworkPerformanceApi->nearRealTimeNetworkConditions($body);
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Domestic 4 G and 5G Nationwide Network Coverage

Run a report for FWA Address qualification or to determine network types available and available coverage. Network types covered include: CAT-M, NB-IOT, LTE, LTE-AWS, 5GNW, MMWAVE and C-BAND.

```php
function domestic4GAnd5GNationwideNetworkCoverage($body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [GetWirelessCoverageRequest](../../doc/models/get-wireless-coverage-request.md)\|[GetWirelessCoverageRequest](../../doc/models/get-wireless-coverage-request.md)Fwa | Body, Required | This is a container for any-of cases. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`WnpRequestResponse`](../../doc/models/wnp-request-response.md).

## Example Usage

```php
$body = GetWirelessCoverageRequestFwaBuilder::init(
    '0000123456-00001',
    'FWA',
    'ADDRESS',
    LocationsBuilder::init()
        ->addressList(
            [
                AddressItemBuilder::init()
                    ->addressLine1('street address')
                    ->city('city')
                    ->state('LA')
                    ->country('USA')
                    ->zip('00000')
                    ->build()
            ]
        )
        ->build(),
    [
        NetworkTypeObjectBuilder::init()
            ->networkType('LTE')
            ->build()
    ]
)->build();

$apiResponse = $wirelessNetworkPerformanceApi->domestic4GAnd5GNationwideNetworkCoverage($body);
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Site Proximity

Identify the direction and general distance of nearby cell sites and the technology supported by the equipment.

```php
function siteProximity(GetNetworkConditionsRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetNetworkConditionsRequest`](../../doc/models/get-network-conditions-request.md) | Body, Required | Request for cell site proximity. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`WnpRequestResponse`](../../doc/models/wnp-request-response.md).

## Example Usage

```php
$body = GetNetworkConditionsRequestBuilder::init(
    '0000123456-00001',
    'LONGLAT',
    CoordinatesBuilder::init()
        ->latitude('-33.84819')
        ->longitude('151.22049')
        ->build()
)->build();

$apiResponse = $wirelessNetworkPerformanceApi->siteProximity($body);
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Device Experience 30 Days History

A report of a specific device's service scores over a 30 day period.

```php
function deviceExperience30DaysHistory(GetDeviceExperienceScoreHistoryRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDeviceExperienceScoreHistoryRequest`](../../doc/models/get-device-experience-score-history-request.md) | Body, Required | Request for a device's 30 day experience. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`WnpRequestResponse`](../../doc/models/wnp-request-response.md).

## Example Usage

```php
$body = GetDeviceExperienceScoreHistoryRequestBuilder::init(
    '0000123456-00001',
    DeviceIdentifierBuilder::init(
        'iccid',
        '01234567899876543210'
    )
        ->mdn('0123456789')
        ->build()
)->build();

$apiResponse = $wirelessNetworkPerformanceApi->deviceExperience30DaysHistory($body);
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |


# Device Experience Bulk Latest

Run a report to view the latest device experience score for specific devices.

```php
function deviceExperienceBulkLatest(GetDeviceExperienceScoreBulkRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDeviceExperienceScoreBulkRequest`](../../doc/models/get-device-experience-score-bulk-request.md) | Body, Required | Request for bulk latest history details. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`WnpRequestResponse`](../../doc/models/wnp-request-response.md).

## Example Usage

```php
$body = GetDeviceExperienceScoreBulkRequestBuilder::init(
    '0000123456-00001',
    [
        DeviceIdentifierBuilder::init(
            'iccid',
            '01234567899876543210'
        )
            ->mdn('0123456789')
            ->build()
    ]
)->build();

$apiResponse = $wirelessNetworkPerformanceApi->deviceExperienceBulkLatest($body);
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseException`](../../doc/models/wnp-rest-error-response-exception.md) |

