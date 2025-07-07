# Sensor Insights Gateways

```php
$sensorInsightsGatewaysApi = $client->getSensorInsightsGatewaysApi();
```

## Class Name

`SensorInsightsGatewaysApi`


# Sensor Insights List Gateway Devices Request

```php
function sensorInsightsListGatewayDevicesRequest(DtoListDevicesRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListDevicesRequest`](../../doc/models/dto-list-devices-request.md) | Body, Required | Get gateway information |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ResourceDevice[]`](../../doc/models/resource-device.md).

## Example Usage

```php
$body = DtoListDevicesRequestBuilder::init()
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

$apiResponse = $sensorInsightsGatewaysApi->sensorInsightsListGatewayDevicesRequest($body);
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

