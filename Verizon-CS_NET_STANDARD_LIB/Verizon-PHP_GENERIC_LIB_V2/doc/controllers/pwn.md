# PWN

```php
$pwnApi = $client->getPwnApi();
```

## Class Name

`PwnApi`

## Methods

* [KPI List](../../doc/controllers/pwn.md#kpi-list)
* [Get Profile List](../../doc/controllers/pwn.md#get-profile-list)
* [Change PWN Device State-Activate](../../doc/controllers/pwn.md#change-pwn-device-state-activate)
* [Change PWN Device State-Deactivate](../../doc/controllers/pwn.md#change-pwn-device-state-deactivate)
* [Change PWN Device Profile](../../doc/controllers/pwn.md#change-pwn-device-profile)
* [Change PWN Device IPaddress](../../doc/controllers/pwn.md#change-pwn-device-ipaddress)
* [Get PWN Performance Consent](../../doc/controllers/pwn.md#get-pwn-performance-consent)


# KPI List

```php
function kpiList(string $aname): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`KpiInfoList`](../../doc/models/kpi-info-list.md).

## Example Usage

```php
$aname = '0342351414-00001';

$apiResponse = $pwnApi->kpiList($aname);
```

## Example Response *(as JSON)*

```json
{
  "KpiInfoList": [
    {
      "name": "DOWNLINK_THROUGHPUT",
      "value": "23.2",
      "nodeName": "132924_ENB_VZ_EULESS_OLTE_RD-01",
      "nodeType": "BASEBAND",
      "description": "Downlink throughput (4G)",
      "unit": "Mbps",
      "category": "Network Performance Radio",
      "timeOfLastUpdate": "2022-12-07T08:39:59.228Z"
    }
  ]
}
```


# Get Profile List

```php
function getProfileList(string $aname): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`PwnProfileList`](../../doc/models/pwn-profile-list.md).

## Example Usage

```php
$aname = '0342351414-00001';

$apiResponse = $pwnApi->getProfileList($aname);
```

## Example Response *(as JSON)*

```json
{
  "profiles": [
    {
      "profileId": "HSS-EsmProfile_Enterprise",
      "profileName": "HSS EsmProfile Enterprise"
    }
  ]
}
```


# Change PWN Device State-Activate

```php
function changePwnDeviceStateActivate(ChangePwnDeviceStateActivateRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceStateActivateRequest`](../../doc/models/change-pwn-device-state-activate-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ChangePwnDeviceStateResponse`](../../doc/models/change-pwn-device-state-response.md).

## Example Usage

```php
$body = ChangePwnDeviceStateActivateRequestBuilder::init(
    '0342351414-00001',
    [
        PwnDeviceListBuilder::init(
            [
                PwnDeviceIdBuilder::init(
                    '99948099913024600001',
                    'iccid'
                )->build()
            ]
        )->build()
    ],
    ActivateBuilder::init(
        'HSS EsmProfile Enterprise 5G'
    )->build()
)->build();

$apiResponse = $pwnApi->changePwnDeviceStateActivate($body);
```

## Example Response *(as JSON)*

```json
{
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device State-Deactivate

```php
function changePwnDeviceStateDeactivate(ChangePwnDeviceStateDeactivateRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceStateDeactivateRequest`](../../doc/models/change-pwn-device-state-deactivate-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ChangePwnDeviceStateResponse`](../../doc/models/change-pwn-device-state-response.md).

## Example Usage

```php
$body = ChangePwnDeviceStateDeactivateRequestBuilder::init(
    '0342351414-00001',
    [
        PwnDeviceListBuilder::init(
            [
                PwnDeviceIdBuilder::init(
                    '99948099913031600000',
                    'iccid'
                )->build()
            ]
        )->build(),
        PwnDeviceListBuilder::init(
            [
                PwnDeviceIdBuilder::init(
                    '99948099913031700000',
                    'iccid'
                )->build()
            ]
        )->build()
    ]
)->build();

$apiResponse = $pwnApi->changePwnDeviceStateDeactivate($body);
```

## Example Response *(as JSON)*

```json
{
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device Profile

```php
function changePwnDeviceProfile(ChangePwnDeviceProfileRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceProfileRequest`](../../doc/models/change-pwn-device-profile-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ChangePwnDeviceProfileResponse`](../../doc/models/change-pwn-device-profile-response.md).

## Example Usage

```php
$body = ChangePwnDeviceProfileRequestBuilder::init(
    '0342351414-00001',
    [
        PwnDeviceListBuilder::init(
            [
                PwnDeviceIdBuilder::init(
                    '99948099913024600000',
                    'iccid'
                )->build()
            ]
        )->build()
    ],
    'HSS EsmProfile Enterprise 5G internet'
)->build();

$apiResponse = $pwnApi->changePwnDeviceProfile($body);
```

## Example Response *(as JSON)*

```json
{
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device IPaddress

```php
function changePwnDeviceIpaddress(ChangePwnDeviceIpaddressRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceIpaddressRequest`](../../doc/models/change-pwn-device-ipaddress-request.md) | Body, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`ChangePwnDeviceIpaddressResponse`](../../doc/models/change-pwn-device-ipaddress-response.md).

## Example Usage

```php
$body = ChangePwnDeviceIpaddressRequestBuilder::init(
    '0342351414-00001',
    [
        DeviceListIpBuilder::init(
            [
                PwnDeviceIdBuilder::init(
                    '99948099913024600000',
                    'iccid'
                )->build()
            ],
            '10.3.4.5'
        )->build(),
        DeviceListIpBuilder::init(
            [
                PwnDeviceIdBuilder::init(
                    '999480500019111000001',
                    'iccid'
                )->build()
            ],
            '10.4.5.7'
        )->build()
    ]
)->build();

$apiResponse = $pwnApi->changePwnDeviceIpaddress($body);
```

## Example Response *(as JSON)*

```json
{
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Get PWN Performance Consent

```php
function getPwnPerformanceConsent(string $aname): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`GetPwnPerformanceConsentResponse`](../../doc/models/get-pwn-performance-consent-response.md).

## Example Usage

```php
$aname = '1533445500-00088';

$apiResponse = $pwnApi->getPwnPerformanceConsent($aname);
```

## Example Response *(as JSON)*

```json
{
  "consent": "false"
}
```

