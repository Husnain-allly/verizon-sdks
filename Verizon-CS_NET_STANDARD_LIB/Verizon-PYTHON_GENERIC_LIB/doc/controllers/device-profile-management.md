# Device Profile Management

```python
device_profile_management_api = client.device_profile_management
```

## Class Name

`DeviceProfileManagementApi`

## Methods

* [Activate Device Through Profile](../../doc/controllers/device-profile-management.md#activate-device-through-profile)
* [Profile to Activate Device](../../doc/controllers/device-profile-management.md#profile-to-activate-device)
* [Profile to Deactivate Device](../../doc/controllers/device-profile-management.md#profile-to-deactivate-device)
* [Profile to Set Fallback Attribute](../../doc/controllers/device-profile-management.md#profile-to-set-fallback-attribute)


# Activate Device Through Profile

Uses the profile to bring the device under management.

```python
def activate_device_through_profile(self,
                                   body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ActivateDeviceProfileRequest`](../../doc/models/activate-device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```python
body = ActivateDeviceProfileRequest(
    devices=[
        DeviceList(
            device_ids=[
                DeviceId(
                    id='32-digit EID',
                    kind='eid',
                    additional_properties=None
                ),
                DeviceId(
                    id='15-digit IMEI',
                    kind='imei',
                    additional_properties=None
                )
            ]
        )
    ],
    account_name='0000123456-00001',
    service_plan='The service plan name',
    mdn_zip_code='five digit zip code'
)

result = device_profile_management_api.activate_device_through_profile(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Profile to Activate Device

Uses the profile to activate the device.

```python
def profile_to_activate_device(self,
                              body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileRequest`](../../doc/models/profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```python
body = ProfileRequest(
    account_name='0000123456-00001',
    devices=[
        DeviceList()
    ],
    carrier_name='the name of the mobile service provider',
    service_plan='The service plan name',
    mdn_zip_code='five digit zip code'
)

result = device_profile_management_api.profile_to_activate_device(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Profile to Deactivate Device

Uses the profile to deactivate the device.

```python
def profile_to_deactivate_device(self,
                                body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeactivateDeviceProfileRequest`](../../doc/models/deactivate-device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```python
body = DeactivateDeviceProfileRequest(
    account_name='0000123456-00001',
    reason_code='a short code for the reason action was taken',
    carrier_name='the name of the mobile service provider',
    etf_waiver=True,
    check_fallback_profile=False
)

result = device_profile_management_api.profile_to_deactivate_device(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |


# Profile to Set Fallback Attribute

Allows the profile to set the fallback attribute to the device.

```python
def profile_to_set_fallback_attribute(self,
                                     body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SetFallbackAttributeRequest`](../../doc/models/set-fallback-attribute-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`RequestResponse`](../../doc/models/request-response.md).

## Example Usage

```python
body = SetFallbackAttributeRequest(
    devices=[
        DeviceList()
    ],
    account_name='0000123456-00001',
    carrier_name='the name of the mobile service provider'
)

result = device_profile_management_api.profile_to_set_fallback_attribute(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`RestErrorResponseException`](../../doc/models/rest-error-response-exception.md) |

