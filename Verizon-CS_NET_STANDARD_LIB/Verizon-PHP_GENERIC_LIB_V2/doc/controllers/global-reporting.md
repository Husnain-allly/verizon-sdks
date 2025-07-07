# Global Reporting

```php
$globalReportingApi = $client->getGlobalReportingApi();
```

## Class Name

`GlobalReportingApi`

## Methods

* [Deviceprovhistory Using POST](../../doc/controllers/global-reporting.md#deviceprovhistory-using-post)
* [Retrieve Global List](../../doc/controllers/global-reporting.md#retrieve-global-list)


# Deviceprovhistory Using POST

Retrieve the provisioning history of a specific device or devices.

```php
function deviceprovhistoryUsingPost(EsimProvhistoryRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`EsimProvhistoryRequest`](../../doc/models/esim-provhistory-request.md) | Body, Required | Device Provisioning History |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`EsimRequestResponse`](../../doc/models/esim-request-response.md).

## Example Usage

```php
$body = EsimProvhistoryRequestBuilder::init()
    ->accountName('0000123456-00001')
    ->earliest(DateTimeHelper::fromRfc3339DateTime('10/15/2021 04:49:35'))
    ->latest(DateTimeHelper::fromRfc3339DateTime('10/15/2021 04:49:49'))
    ->build();

$apiResponse = $globalReportingApi->deviceprovhistoryUsingPost($body);
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


# Retrieve Global List

Retrieve a list of all devices associated with an account.

```php
function retrieveGlobalList(EsimGlobalDeviceList $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`EsimGlobalDeviceList`](../../doc/models/esim-global-device-list.md) | Body, Required | Device List |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`EsimRequestResponse`](../../doc/models/esim-request-response.md).

## Example Usage

```php
$body = EsimGlobalDeviceListBuilder::init()
    ->accountName('0000123456-00001')
    ->carrierNameFilter('VerizonWireless')
    ->build();

$apiResponse = $globalReportingApi->retrieveGlobalList($body);
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

