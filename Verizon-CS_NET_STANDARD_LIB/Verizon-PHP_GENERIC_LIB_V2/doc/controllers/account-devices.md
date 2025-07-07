# Account Devices

```php
$accountDevicesApi = $client->getAccountDevicesApi();
```

## Class Name

`AccountDevicesApi`

## Methods

* [Get Account Device Information](../../doc/controllers/account-devices.md#get-account-device-information)
* [List Account Devices Information](../../doc/controllers/account-devices.md#list-account-devices-information)


# Get Account Device Information

Retrieve account device information such as reported firmware on the devices.

```php
function getAccountDeviceInformation(
    string $acc,
    ?string $lastSeenDeviceId = null,
    ?string $protocol = DevicesProtocol::LW_M2M
): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `lastSeenDeviceId` | `?string` | Query, Optional | Last seen device identifier. |
| `protocol` | [`?string(DevicesProtocol)`](../../doc/models/devices-protocol.md) | Query, Optional | Filter to retrieve a specific protocol type used.<br><br>**Default**: `DevicesProtocol::LW_M2M` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`V3AccountDeviceList`](../../doc/models/v3-account-device-list.md).

## Example Usage

```php
$acc = '0000123456-00001';

$lastSeenDeviceId = '0';

$protocol = DevicesProtocol::LW_M2M;

$apiResponse = $accountDevicesApi->getAccountDeviceInformation(
    $acc,
    $lastSeenDeviceId,
    $protocol
);
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |


# List Account Devices Information

Retrieve device information for a list of devices on an account.

```php
function listAccountDevicesInformation(string $acc, DeviceImei $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `acc` | `string` | Template, Required | Account identifier. |
| `body` | [`DeviceImei`](../../doc/models/device-imei.md) | Body, Required | Request device list information. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`DeviceListResult`](../../doc/models/device-list-result.md).

## Example Usage

```php
$acc = '0000123456-00001';

$body = DeviceImeiBuilder::init(
    [
        '15-digit IMEI'
    ]
)->build();

$apiResponse = $accountDevicesApi->listAccountDevicesInformation(
    $acc,
    $body
);
```

## Example Response *(as JSON)*

```json
{
  "accountName": "0000123456-00001",
  "deviceCount": 1,
  "deviceList": [
    {
      "deviceId": "15-digit IMEI",
      "mdn": "10-digit MDN",
      "model": "GM01Q",
      "make": "SEQUANS COMMUNICATIONS",
      "firmware": "SR1.2.0.0-10657",
      "fotaEligible": true,
      "licenseAssigned": true,
      "status": "Active",
      "protocol": "LWM2M",
      "createTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "statusTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "refreshTime": "2021-06-03 00:03:56.079 +0000 UTC",
      "lastConnectionTime": "2012-04-23T18:25:43.511Z"
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV3ResultException`](../../doc/models/fota-v3-result-exception.md) |

