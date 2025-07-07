# Managinge SIM Profiles

```ts
const managingeSimProfilesApi = new ManagingeSimProfilesApi(client);
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

```ts
async resumeProfile(
  body: GioProfileRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: GioProfileRequest = {
  devices: [
    {
    }
  ],
  accountName: '0000123456-00001',
  mdnZipCode: '12345',
  servicePlan: 'service plan name',
};

try {
  const { result, ...httpResponse } = await managingEsimProfilesApi.resumeProfile(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |


# Profile Suspend

Suspend a device's Global profile.

```ts
async profileSuspend(
  body: GioProfileRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: GioProfileRequest = {
  devices: [
    {
    }
  ],
  accountName: '0000123456-00001',
  mdnZipCode: '12345',
  servicePlan: 'service plan name',
};

try {
  const { result, ...httpResponse } = await managingEsimProfilesApi.profileSuspend(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |


# Device Suspend

Suspend all service to an eUICC device, including the lead and local profile.

```ts
async deviceSuspend(
  body: GioProfileRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: GioProfileRequest = {
  devices: [
    {
    }
  ],
  accountName: '0000123456-00001',
  mdnZipCode: '12345',
  servicePlan: 'service plan name',
};

try {
  const { result, ...httpResponse } = await managingEsimProfilesApi.deviceSuspend(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |


# Set Fallback

Enable a fallback profile to be set.

```ts
async setFallback(
  body: FallBack,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`FallBack`](../../doc/models/fall-back.md) | Body, Required | Set the fallback attributes to allow a fallback profile to be activated. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: FallBack = {
};

try {
  const { result, ...httpResponse } = await managingEsimProfilesApi.setFallback(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |


# Activate a Device Profile

Activate a device with either a lead or local profile.

```ts
async activateADeviceProfile(
  body: GioProfileRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioProfileRequest`](../../doc/models/gio-profile-request.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: GioProfileRequest = {
  devices: [
    {
    }
  ],
  accountName: '0000123456-00001',
  mdnZipCode: '12345',
  servicePlan: 'service plan name',
};

try {
  const { result, ...httpResponse } = await managingEsimProfilesApi.activateADeviceProfile(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |


# Enable a Device Profile

Enable a device lead or local profile.

```ts
async enableADeviceProfile(
  body: DeviceProfileRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: DeviceProfileRequest = {
  accountName: '0000123456-00001',
  servicePlan: 'service plan name',
};

try {
  const { result, ...httpResponse } = await managingEsimProfilesApi.enableADeviceProfile(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |


# Deactivate a Device Profile

Deactivate the lead or local profile. **Note:** to reactivate the profile, use the **Activate** endpoint above.

```ts
async deactivateADeviceProfile(
  body: GioDeactivateDeviceProfileRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GioDeactivateDeviceProfileRequest`](../../doc/models/gio-deactivate-device-profile-request.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: GioDeactivateDeviceProfileRequest = {
  accountName: '0000123456-00001',
  servicePlan: 'service plan name',
  etfWaiver: false,
  reasonCode: 'FF',
};

try {
  const { result, ...httpResponse } = await managingEsimProfilesApi.deactivateADeviceProfile(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |


# Enable a Device Profile for Download

Enable the Global IoT Orchestration device profile for download.

```ts
async enableADeviceProfileForDownload(
  body: DeviceProfileRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: DeviceProfileRequest = {
  accountName: '0000123456-00001',
  servicePlan: 'service plan name',
};

try {
  const { result, ...httpResponse } = await managingEsimProfilesApi.enableADeviceProfileForDownload(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |


# Download a Device Profile

Download a Global IoT Orchestration device profile.

```ts
async downloadADeviceProfile(
  body: DeviceProfileRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: DeviceProfileRequest = {
  accountName: '0000123456-00001',
  servicePlan: 'service plan name',
};

try {
  const { result, ...httpResponse } = await managingEsimProfilesApi.downloadADeviceProfile(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |


# Delete a Device Profile

Delete a device profile for Global IoT Orchestration. **Note:** the profile must be deactivated first!

```ts
async deleteADeviceProfile(
  body: DeviceProfileRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DeviceProfileRequest`](../../doc/models/device-profile-request.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: DeviceProfileRequest = {
  accountName: '0000123456-00001',
  servicePlan: 'service plan name',
};

try {
  const { result, ...httpResponse } = await managingEsimProfilesApi.deleteADeviceProfile(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |

