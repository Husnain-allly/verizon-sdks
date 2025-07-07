# SIM Actions

```php
$simActionsApi = $client->getSimActionsApi();
```

## Class Name

`SimActionsApi`

## Methods

* [Newactivatecode](../../doc/controllers/sim-actions.md#newactivatecode)
* [Setactivate Using POST](../../doc/controllers/sim-actions.md#setactivate-using-post)
* [Setdeactivate Using POST](../../doc/controllers/sim-actions.md#setdeactivate-using-post)


# Newactivatecode

System assign a new activation code to reactivate a deactivated device. **Note:** the previously assigned ICCID must be used to request a new activation code.

```php
function newactivatecode(EsimProfileRequest2 $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`EsimProfileRequest2`](../../doc/models/esim-profile-request-2.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`EsimRequestResponse`](../../doc/models/esim-request-response.md).

## Example Usage

```php
$body = EsimProfileRequest2Builder::init()
    ->devices(
        [
            EsimDeviceListBuilder::init()
                ->deviceIds(
                    [
                        DeviceId2Builder::init()
                            ->id('15-digit IMEI')
                            ->kind('imei')
                            ->build(),
                        DeviceId2Builder::init()
                            ->id('20-digit ICCID')
                            ->kind('iccid')
                            ->build()
                    ]
                )
                ->build()
        ]
    )
    ->accountName('0000123456-00001')
    ->servicePlan('the service plan name')
    ->mdnZipCode('five digit zip code')
    ->build();

$apiResponse = $simActionsApi->newactivatecode($body);
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |


# Setactivate Using POST

Uses the profile to activate the SIM.

```php
function setactivateUsingPost(EsimProfileRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`EsimProfileRequest`](../../doc/models/esim-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`EsimRequestResponse`](../../doc/models/esim-request-response.md).

## Example Usage

```php
$body = EsimProfileRequestBuilder::init()
    ->devices(
        [
            EsimDeviceListBuilder::init()
                ->deviceIds(
                    [
                        DeviceId2Builder::init()
                            ->id('32-digit EID')
                            ->kind('eid')
                            ->build(),
                        DeviceId2Builder::init()
                            ->id('15-digit IMEI')
                            ->kind('imei')
                            ->build(),
                        DeviceId2Builder::init()
                            ->id('20-digit ICCID')
                            ->kind('iccid (ICCID is only used for reactivation)')
                            ->build()
                    ]
                )
                ->build()
        ]
    )
    ->carrierName('Verizon Wireless')
    ->accountName('0000123456-00001')
    ->servicePlan('the service plan name')
    ->mdnZipCode('five digit zip code')
    ->build();

$apiResponse = $simActionsApi->setactivateUsingPost($body);
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |


# Setdeactivate Using POST

Uses the profile to deactivate the SIM.

```php
function setdeactivateUsingPost(ProfileRequest2 $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileRequest2`](../../doc/models/profile-request-2.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`EsimRequestResponse`](../../doc/models/esim-request-response.md).

## Example Usage

```php
$body = ProfileRequest2Builder::init()
    ->accountName('0000123456-00001')
    ->carrierName('Verizon Wireless')
    ->reasonCode('FF')
    ->etfWaiver(true)
    ->checkFallbackProfile(false)
    ->build();

$apiResponse = $simActionsApi->setdeactivateUsingPost($body);
```

## Example Response *(as JSON)*

```json
{
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 403 | Forbidden | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| 429 | Too many requests | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |
| Default | Error response | [`EsimRestErrorResponseException`](../../doc/models/esim-rest-error-response-exception.md) |

