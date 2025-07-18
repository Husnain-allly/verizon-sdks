# 5G BI Device Actions

```php
$m5GBiDeviceActionsApi = $client->getM5GBiDeviceActionsApi();
```

## Class Name

`M5GBiDeviceActionsApi`

## Methods

* [Business Internetlist Device Information](../../doc/controllers/5g-bi-device-actions.md#business-internetlist-device-information)
* [Business Internetactivate Using POST](../../doc/controllers/5g-bi-device-actions.md#business-internetactivate-using-post)
* [Business Internet Serviceplanchange](../../doc/controllers/5g-bi-device-actions.md#business-internet-serviceplanchange)


# Business Internetlist Device Information

Uses the decive's Integrated Circuit Card Identification Number (ICCID) to retrive and display the device's properties.

```php
function businessInternetlistDeviceInformation(M5GBideviceId $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M5GBideviceId`](../../doc/models/m-5g-bidevice-id.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`M5GBideviceDetailsresponse`](../../doc/models/m-5g-bidevice-detailsresponse.md).

## Example Usage

```php
$body = M5GBideviceIdBuilder::init()
    ->deviceId(
        M5GBideviceId1Builder::init()
            ->id('20-digit ICCID')
            ->kind('iccid')
            ->build()
    )
    ->build();

$apiResponse = $m5GBiDeviceActionsApi->businessInternetlistDeviceInformation($body);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`M5GBiRestErrorResponseException`](../../doc/models/m-5g-bi-rest-error-response-exception.md) |


# Business Internetactivate Using POST

Uses the device's ICCID and IMEI to activate service.

```php
function businessInternetactivateUsingPost(M5GBiactivateRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M5GBiactivateRequest`](../../doc/models/m-5g-biactivate-request.md) | Body, Required | Activate 5G BI service. Defining <code>publicIpRestriction</code> as "Unrestricted" or "Restricted" is required for activating as Public Static. Leave  <code>publicIpRestriction</code> undefined to activate as Public Dynamic. Removing <code>publicIpRestriction</code> from the request will activate as Mobile Private Network (MPN). |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`M5GBiRequestResponse`](../../doc/models/m-5g-bi-request-response.md).

## Example Usage

```php
$body = M5GBiactivateRequestBuilder::init()
    ->accountName('0000123456-00001')
    ->servicePlan('service plan name')
    ->deviceListWithServiceAddress(
        [
            DeviceListWithServiceAddress1Builder::init()
                ->deviceId(
                    [
                        M5GBideviceId1Builder::init()
                            ->id('15-digit IMEI')
                            ->kind('imei')
                            ->build(),
                        M5GBideviceId1Builder::init()
                            ->id('20-digit ICCID')
                            ->kind('iccid')
                            ->build()
                    ]
                )
                ->build(),
            DeviceListWithServiceAddress1Builder::init()
                ->primaryPlaceofuse(
                    M5GBiprimaryPlaceofuseBuilder::init()
                        ->address(
                            M5GBiAddressBuilder::init()
                                ->addressLine1('street number and name')
                                ->city('city of address')
                                ->state('2-letter state ID (conforms to ISO 3166-2)')
                                ->zip('5-digit ZIP code')
                                ->zip4('the +4 digits used for ZIP codes')
                                ->phone('a 10-digit phone number')
                                ->phoneType('W')
                                ->build()
                        )
                        ->customerName(
                            M5GBiCustomerNameBuilder::init()
                                ->firstName('First name')
                                ->lastName('Surname or Last Name')
                                ->middleName('middle name or initial')
                                ->title('Mr. or Ms.')
                                ->suffex('Dr or Esq')
                                ->build()
                        )
                        ->build()
                )
                ->build()
        ]
    )
    ->publicIpRestriction('Unrestricted')
    ->carrierName('Verizon Wireless')
    ->mdnZipCode('the 5-digit ZIP code of the Mobile Directory Number (MDN)')
    ->build();

$apiResponse = $m5GBiDeviceActionsApi->businessInternetactivateUsingPost($body);
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
| Default | Error response | [`M5GBiRestErrorResponseException`](../../doc/models/m-5g-bi-rest-error-response-exception.md) |


# Business Internet Serviceplanchange

Change a device's service plan to use 5G BI.

```php
function businessInternetServiceplanchange(M5GBichangeRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M5GBichangeRequest`](../../doc/models/m-5g-bichange-request.md) | Body, Required | This endpoint is for use when changing a device's service plan to a 5G BI service plan. The service plan can change for an active device up to four times per month but will require address validation for each change. The service plan cannot be changed for a device while its service is suspended. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`M5GBiRequestResponse`](../../doc/models/m-5g-bi-request-response.md).

## Example Usage

```php
$body = M5GBichangeRequestBuilder::init()
    ->accountName('0000123456-00001')
    ->servicePlan('5G BI service plan name being changed to')
    ->deviceListWithServiceAddress(
        [
            DeviceListWithServiceAddressBuilder::init()
                ->deviceId(
                    [
                        M5GBideviceId1Builder::init()
                            ->id('15-digit IMEI')
                            ->kind('imei')
                            ->build()
                    ]
                )
                ->build(),
            DeviceListWithServiceAddressBuilder::init()
                ->primaryPlaceofuse(
                    M5GBiaddressAndcustomerinfoBuilder::init()
                        ->additionalProperty('address', ApiHelper::deserialize('{"addressLine1":"street number and name","city":"city of address","state":"2-letter state ID (conforms to ISO 3166-2)","zip":"5-digit ZIP code","zip+4":"the +4 digits used for ZIP codes"}'))
                        ->additionalProperty('customerName', ApiHelper::deserialize('{"firstName":"First name","lastName":"Surname or Last Name"}'))
                        ->build()
                )
                ->build()
        ]
    )
    ->currentServicePlan('Name of the plan being changed from')
    ->build();

$apiResponse = $m5GBiDeviceActionsApi->businessInternetServiceplanchange($body);
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
| Default | Error response | [`M5GBiRestErrorResponseException`](../../doc/models/m-5g-bi-rest-error-response-exception.md) |

