# E UICC Device Profile Management

```ruby
e_uicc_device_profile_management_api = client.e_uicc_device_profile_management
```

## Class Name

`EuiccDeviceProfileManagementApi`

## Methods

* [Download Local Profile to Enable](../../doc/controllers/e-uicc-device-profile-management.md#download-local-profile-to-enable)
* [Download Local Profile to Disable](../../doc/controllers/e-uicc-device-profile-management.md#download-local-profile-to-disable)
* [Enable Local Profile](../../doc/controllers/e-uicc-device-profile-management.md#enable-local-profile)
* [Disable Local Profile](../../doc/controllers/e-uicc-device-profile-management.md#disable-local-profile)
* [Delete Local Profile](../../doc/controllers/e-uicc-device-profile-management.md#delete-local-profile)


# Download Local Profile to Enable

Downloads an eUICC local profile to devices and enables the profile.

```ruby
def download_local_profile_to_enable(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Device Profile Query |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DeviceManagementResult`](../../doc/models/device-management-result.md).

## Example Usage

```ruby
body = ProfileChangeStateRequest.new(
  devices: [
    DeviceList.new(
      device_ids: [
        DeviceId.new(
          id: '678912789123453456784008666456',
          kind: 'eid'
        ),
        DeviceId.new(
          id: '78425989148000000840',
          kind: 'iccid'
        )
      ]
    )
  ],
  account_name: '1223334444-00001',
  smsr_oid: '1.3.6.1.4.1.31746.1.500.200.101.5'
)

result = e_uicc_device_profile_management_api.download_local_profile_to_enable(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Download Local Profile to Disable

Downloads an eUICC local profile to devices and leaves the profile disabled.

```ruby
def download_local_profile_to_disable(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Device Profile Query |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`DeviceManagementResult`](../../doc/models/device-management-result.md).

## Example Usage

```ruby
body = ProfileChangeStateRequest.new(
  devices: [
    DeviceList.new(
      device_ids: [
        DeviceId.new(
          id: '678912789123453456784008666456',
          kind: 'eid'
        ),
        DeviceId.new(
          id: '78425989148000000840',
          kind: 'iccid'
        )
      ]
    )
  ],
  account_name: '1223334444-00001',
  smsr_oid: '1.3.6.1.4.1.31746.1.500.200.101.5'
)

result = e_uicc_device_profile_management_api.download_local_profile_to_disable(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Example Response *(as JSON)*

```json
{
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Enable Local Profile

Enable a local profile that has been downloaded to eUICC devices.

```ruby
def enable_local_profile(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Update state |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```ruby
body = ProfileChangeStateRequest.new(
  devices: [
    DeviceList.new(
      device_ids: [
        DeviceId.new(
          id: '678912789123453456784008666456',
          kind: 'eid'
        ),
        DeviceId.new(
          id: '78425989148000000840',
          kind: 'iccid'
        )
      ]
    )
  ],
  account_name: '1223334444-00001',
  smsr_oid: '1.3.6.1.4.1.31746.1.500.200.101.5'
)

result = e_uicc_device_profile_management_api.enable_local_profile(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Disable Local Profile

Disable a local profile on eUICC devices. The default or boot profile will become the enabled profile.

```ruby
def disable_local_profile(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Update state |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```ruby
body = ProfileChangeStateRequest.new(
  devices: [
    DeviceList.new(
      device_ids: [
        DeviceId.new(
          id: '678912789123453456784008666456',
          kind: 'eid'
        ),
        DeviceId.new(
          id: '78425989148000000840',
          kind: 'iccid'
        )
      ]
    )
  ],
  account_name: '1223334444-00001',
  smsr_oid: '1.3.6.1.4.1.31746.1.500.200.101.5'
)

result = e_uicc_device_profile_management_api.disable_local_profile(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Delete Local Profile

Delete a local profile from eUICC devices. If the local profile is enabled, it will first be disabled and the boot or default profile will be enabled.

```ruby
def delete_local_profile(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileChangeStateRequest`](../../doc/models/profile-change-state-request.md) | Body, Required | Update state |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```ruby
body = ProfileChangeStateRequest.new(
  devices: [
    DeviceList.new(
      device_ids: [
        DeviceId.new(
          id: '678912789123453456784008666456',
          kind: 'eid'
        ),
        DeviceId.new(
          id: '78425989148000000840',
          kind: 'iccid'
        )
      ]
    )
  ],
  account_name: '1223334444-00001',
  smsr_oid: '1.3.6.1.4.1.31746.1.500.200.101.5'
)

result = e_uicc_device_profile_management_api.delete_local_profile(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error Response | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

