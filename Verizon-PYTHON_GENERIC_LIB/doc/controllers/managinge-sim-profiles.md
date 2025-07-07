# Managinge SIM Profiles

```python
managinge_sim_profiles_api = client.managinge_sim_profiles
```

## Class Name

`ManagingeSimProfilesApi`

## Methods

* [Resume Profile](../../doc/controllers/managinge-sim-profiles.md#resume-profile)
* [Profile Suspend](../../doc/controllers/managinge-sim-profiles.md#profile-suspend)
* [Device Suspend](../../doc/controllers/managinge-sim-profiles.md#device-suspend)
* [Set Fallback](../../doc/controllers/managinge-sim-profiles.md#set-fallback)
* [Activate a Device Profile](../../doc/controllers/managinge-sim-profiles.md#activate-a-device-profile)
* [Enable a Device Profile](../../doc/controllers/managinge-sim-profiles.md#enable-a-device-profile)
* [Deactivate a Device Profile](../../doc/controllers/managinge-sim-profiles.md#deactivate-a-device-profile)
* [Enable a Device Profile for Download](../../doc/controllers/managinge-sim-profiles.md#enable-a-device-profile-for-download)
* [Download a Device Profile](../../doc/controllers/managinge-sim-profiles.md#download-a-device-profile)
* [Delete a Device Profile](../../doc/controllers/managinge-sim-profiles.md#delete-a-device-profile)


# Resume Profile

Resume service to a device with either a lead or local profile.

```python
def resume_profile(self,
                  body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```python
body = GioProfileRequest(
    devices=[
        GioDeviceList()
    ],
    account_name='0000123456-00001',
    mdn_zip_code='12345',
    service_plan='service plan name'
)

result = managing_e_sim_profiles_api.resume_profile(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Profile Suspend

Suspend a device's Global profile.

```python
def profile_suspend(self,
                   body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```python
body = GioProfileRequest(
    devices=[
        GioDeviceList()
    ],
    account_name='0000123456-00001',
    mdn_zip_code='12345',
    service_plan='service plan name'
)

result = managing_e_sim_profiles_api.profile_suspend(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Device Suspend

Suspend all service to an eUICC device, including the lead and local profile.

```python
def device_suspend(self,
                  body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```python
body = GioProfileRequest(
    devices=[
        GioDeviceList()
    ],
    account_name='0000123456-00001',
    mdn_zip_code='12345',
    service_plan='service plan name'
)

result = managing_e_sim_profiles_api.device_suspend(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Set Fallback

Enable a fallback profile to be set.

```python
def set_fallback(self,
                body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`FallBack`](../../doc/models/fall-back.md) | Body, Required | Set the fallback attributes to allow a fallback profile to be activated. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```python
body = FallBack(
    additional_properties=None
)

result = managing_e_sim_profiles_api.set_fallback(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Activate a Device Profile

Activate a device with either a lead or local profile.

```python
def activate_a_device_profile(self,
                             body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```python
body = GioProfileRequest(
    devices=[
        GioDeviceList()
    ],
    account_name='0000123456-00001',
    mdn_zip_code='12345',
    service_plan='service plan name'
)

result = managing_e_sim_profiles_api.activate_a_device_profile(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Enable a Device Profile

Enable a device lead or local profile.

```python
def enable_a_device_profile(self,
                           body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```python
body = DeviceProfileRequest(
    account_name='0000123456-00001',
    service_plan='service plan name'
)

result = managing_e_sim_profiles_api.enable_a_device_profile(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Deactivate a Device Profile

Deactivate the lead or local profile. **Note:** to reactivate the profile, use the **Activate** endpoint above.

```python
def deactivate_a_device_profile(self,
                               body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioDeactivateDeviceProfileRequest`](../../doc/models/gio-deactivate-device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```python
body = GioDeactivateDeviceProfileRequest(
    account_name='0000123456-00001',
    service_plan='service plan name',
    etf_waiver=False,
    reason_code='FF'
)

result = managing_e_sim_profiles_api.deactivate_a_device_profile(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Enable a Device Profile for Download

Enable the Global IoT Orchestration device profile for download.

```python
def enable_a_device_profile_for_download(self,
                                        body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```python
body = DeviceProfileRequest(
    account_name='0000123456-00001',
    service_plan='service plan name'
)

result = managing_e_sim_profiles_api.enable_a_device_profile_for_download(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Download a Device Profile

Download a Global IoT Orchestration device profile.

```python
def download_a_device_profile(self,
                             body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```python
body = DeviceProfileRequest(
    account_name='0000123456-00001',
    service_plan='service plan name'
)

result = managing_e_sim_profiles_api.download_a_device_profile(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Delete a Device Profile

Delete a device profile for Global IoT Orchestration. **Note:** the profile must be deactivated first!

```python
def delete_a_device_profile(self,
                           body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`GioRequestResponse`](../../doc/models/gio-request-response.md).

## Example Usage

```python
body = DeviceProfileRequest(
    account_name='0000123456-00001',
    service_plan='service plan name'
)

result = managing_e_sim_profiles_api.delete_a_device_profile(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |

