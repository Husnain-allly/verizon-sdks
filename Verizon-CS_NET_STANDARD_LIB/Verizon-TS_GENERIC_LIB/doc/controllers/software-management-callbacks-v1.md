# Software Management Callbacks V1

```ts
const softwareManagementCallbacksV1Api = new SoftwareManagementCallbacksV1Api(client);
```

## Class Name

`SoftwareManagementCallbacksV1Api`

## Methods

* [List Registered Callbacks](../../doc/controllers/software-management-callbacks-v1.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/software-management-callbacks-v1.md#register-callback)
* [Deregister Callback](../../doc/controllers/software-management-callbacks-v1.md#deregister-callback)


# List Registered Callbacks

Returns the name and endpoint URL of the callback listening services registered for a given account.

```ts
async listRegisteredCallbacks(
  account: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<RegisteredCallbacks[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [RegisteredCallbacks[]](../../doc/models/registered-callbacks.md).

## Example Usage

```ts
const account = '0242078689-00001';

try {
  const { result, ...httpResponse } = await softwareManagementCallbacksV1Api.listRegisteredCallbacks(account);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Example Response *(as JSON)*

```json
[
  {
    "aname": "0252012345-00001",
    "name": "Fota",
    "url": "http://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultError`](../../doc/models/fota-v1-result-error.md) |


# Register Callback

Registers a URL to receive RESTful messages from a callback service when new firmware versions are available and when upgrades start and finish.

```ts
async registerCallback(
  account: string,
  body: FotaV1CallbackRegistrationRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<FotaV1CallbackRegistrationResult>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `body` | [`FotaV1CallbackRegistrationRequest`](../../doc/models/fota-v1-callback-registration-request.md) | Body, Required | Callback details. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [FotaV1CallbackRegistrationResult](../../doc/models/fota-v1-callback-registration-result.md).

## Example Usage

```ts
const account = '0242078689-00001';

const body: FotaV1CallbackRegistrationRequest = {
  name: 'Fota',
  url: 'https://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx',
};

try {
  const { result, ...httpResponse } = await softwareManagementCallbacksV1Api.registerCallback(
  account,
  body
);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Example Response *(as JSON)*

```json
{
  "accountName": "0204563412-00001",
  "serviceName": "Fota"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultError`](../../doc/models/fota-v1-result-error.md) |


# Deregister Callback

Deregisters the callback endpoint and stops ThingSpace from sending FOTA callback messages for the specified account.

```ts
async deregisterCallback(
  account: string,
  service: CallbackService,
  requestOptions?: RequestOptions
): Promise<ApiResponse<FotaV1SuccessResult>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account` | `string` | Template, Required | Account identifier in "##########-#####". |
| `service` | [`CallbackService`](../../doc/models/callback-service.md) | Template, Required | Callback type. Must be 'Fota' for Software Management Services API. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [FotaV1SuccessResult](../../doc/models/fota-v1-success-result.md).

## Example Usage

```ts
const account = '0242078689-00001';

const service = CallbackService.Fota;

try {
  const { result, ...httpResponse } = await softwareManagementCallbacksV1Api.deregisterCallback(
  account,
  service
);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
}
```

## Example Response *(as JSON)*

```json
{
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Unexpected error. | [`FotaV1ResultError`](../../doc/models/fota-v1-result-error.md) |

