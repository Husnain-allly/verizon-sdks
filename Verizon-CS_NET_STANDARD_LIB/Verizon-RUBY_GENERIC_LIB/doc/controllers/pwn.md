# PWN

```ruby
pwn_api = client.pwn
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

```ruby
def kpi_list(aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`KpiInfoList`](../../doc/models/kpi-info-list.md).

## Example Usage

```ruby
aname = '0342351414-00001'

result = pwn_api.kpi_list(aname)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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

```ruby
def get_profile_list(aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`PwnProfileList`](../../doc/models/pwn-profile-list.md).

## Example Usage

```ruby
aname = '0342351414-00001'

result = pwn_api.get_profile_list(aname)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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

```ruby
def change_pwn_device_state_activate(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceStateActivateRequest`](../../doc/models/change-pwn-device-state-activate-request.md) | Body, Required | - |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`ChangePwnDeviceStateResponse`](../../doc/models/change-pwn-device-state-response.md).

## Example Usage

```ruby
body = ChangePwnDeviceStateActivateRequest.new(
  account_name: '0342351414-00001',
  device_list: [
    PwnDeviceList.new(
      device_ids: [
        PwnDeviceId.new(
          id: '99948099913024600001',
          kind: 'iccid'
        )
      ]
    )
  ],
  activate: Activate.new(
    profile: 'HSS EsmProfile Enterprise 5G'
  )
)

result = pwn_api.change_pwn_device_state_activate(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device State-Deactivate

```ruby
def change_pwn_device_state_deactivate(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceStateDeactivateRequest`](../../doc/models/change-pwn-device-state-deactivate-request.md) | Body, Required | - |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`ChangePwnDeviceStateResponse`](../../doc/models/change-pwn-device-state-response.md).

## Example Usage

```ruby
body = ChangePwnDeviceStateDeactivateRequest.new(
  account_name: '0342351414-00001',
  device_list: [
    PwnDeviceList.new(
      device_ids: [
        PwnDeviceId.new(
          id: '99948099913031600000',
          kind: 'iccid'
        )
      ]
    ),
    PwnDeviceList.new(
      device_ids: [
        PwnDeviceId.new(
          id: '99948099913031700000',
          kind: 'iccid'
        )
      ]
    )
  ]
)

result = pwn_api.change_pwn_device_state_deactivate(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device Profile

```ruby
def change_pwn_device_profile(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceProfileRequest`](../../doc/models/change-pwn-device-profile-request.md) | Body, Required | - |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`ChangePwnDeviceProfileResponse`](../../doc/models/change-pwn-device-profile-response.md).

## Example Usage

```ruby
body = ChangePwnDeviceProfileRequest.new(
  account_name: '0342351414-00001',
  device_list: [
    PwnDeviceList.new(
      device_ids: [
        PwnDeviceId.new(
          id: '99948099913024600000',
          kind: 'iccid'
        )
      ]
    )
  ],
  new_profile: 'HSS EsmProfile Enterprise 5G internet'
)

result = pwn_api.change_pwn_device_profile(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Change PWN Device IPaddress

```ruby
def change_pwn_device_ipaddress(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ChangePwnDeviceIpaddressRequest`](../../doc/models/change-pwn-device-ipaddress-request.md) | Body, Required | - |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`ChangePwnDeviceIpaddressResponse`](../../doc/models/change-pwn-device-ipaddress-response.md).

## Example Usage

```ruby
body = ChangePwnDeviceIpaddressRequest.new(
  account_name: '0342351414-00001',
  device_list: [
    DeviceListIp.new(
      device_ids: [
        PwnDeviceId.new(
          id: '99948099913024600000',
          kind: 'iccid'
        )
      ],
      ipaddress: '10.3.4.5'
    ),
    DeviceListIp.new(
      device_ids: [
        PwnDeviceId.new(
          id: '999480500019111000001',
          kind: 'iccid'
        )
      ],
      ipaddress: '10.4.5.7'
    )
  ]
)

result = pwn_api.change_pwn_device_ipaddress(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "requestId": "c7b45cf2-cab1-4e42-82f8-20350f4c4ea3"
}
```


# Get PWN Performance Consent

```ruby
def get_pwn_performance_consent(aname)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `String` | Template, Required | Account name. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`GetPwnPerformanceConsentResponse`](../../doc/models/get-pwn-performance-consent-response.md).

## Example Usage

```ruby
aname = '1533445500-00088'

result = pwn_api.get_pwn_performance_consent(aname)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "consent": "false"
}
```

