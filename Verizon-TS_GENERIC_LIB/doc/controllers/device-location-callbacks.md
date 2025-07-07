# Device Location Callbacks

```ts
const deviceLocationCallbacksApi = new DeviceLocationCallbacksApi(client);
```

## Class Name

`DeviceLocationCallbacksApi`

## Methods

* [Cancel Async Report](../../doc/controllers/device-location-callbacks.md#cancel-async-report)
* [List Registered Callbacks](../../doc/controllers/device-location-callbacks.md#list-registered-callbacks)
* [Register Callback](../../doc/controllers/device-location-callbacks.md#register-callback)
* [Deregister Callback](../../doc/controllers/device-location-callbacks.md#deregister-callback)


# Cancel Async Report

Cancel an asynchronous report request.

```ts
async cancelAsyncReport(
  accountName: string,
  txid: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<TransactionId>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | Account identifier in "##########-#####". |
| `txid` | `string` | Template, Required | The `transactionId` value. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [TransactionId](../../doc/models/transaction-id.md).

## Example Usage

```ts
const accountName = '0000123456-00001';

const txid = '2c90bd28-eeee-ffff-gggg-7e3bd4fbff33';

try {
  const { result, ...httpResponse } = await deviceLocationCallbacksApi.cancelAsyncReport(
  accountName,
  txid
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
  "txid": "2c90bd28-eeee-ffff-gggg-7e3bd4fbff33"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Unexpected error. | [`DeviceLocationResultError`](../../doc/models/device-location-result-error.md) |


# List Registered Callbacks

Returns a list of all registered callback URLs for the account.

```ts
async listRegisteredCallbacks(
  accountName: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DeviceLocationCallback[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account number. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DeviceLocationCallback[]](../../doc/models/device-location-callback.md).

## Example Usage

```ts
const accountName = '0000123456-00001';

try {
  const { result, ...httpResponse } = await deviceLocationCallbacksApi.listRegisteredCallbacks(accountName);
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
    "name": "Location",
    "url": "http://10.120.102.147:50569/CallbackListener/Location.asmx"
  },
  {
    "name": "Location",
    "url": "http://10.120.102.147:50569/CallbackListener/DeviceLocation.asmx"
  }
]
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`DeviceLocationResultError`](../../doc/models/device-location-result-error.md) |


# Register Callback

Provide a URL to receive messages from a ThingSpace callback service.

```ts
async registerCallback(
  accountName: string,
  body: DeviceLocationCallback,
  requestOptions?: RequestOptions
): Promise<ApiResponse<CallbackRegistrationResult>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account number. |
| `body` | [`DeviceLocationCallback`](../../doc/models/device-location-callback.md) | Body, Required | Request to register a callback. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [CallbackRegistrationResult](../../doc/models/callback-registration-result.md).

## Example Usage

```ts
const accountName = '0000123456-00001';

const body: DeviceLocationCallback = {
  name: CallbackServiceName.Location,
  url: 'http://10.120.102.183:50559/CallbackListener/LocationServiceMessages.asmx',
};

try {
  const { result, ...httpResponse } = await deviceLocationCallbacksApi.registerCallback(
  accountName,
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
  "account": "0212312345-00001",
  "name": "Location"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`DeviceLocationResultError`](../../doc/models/device-location-result-error.md) |


# Deregister Callback

Deregister a URL to stop receiving callback messages.

```ts
async deregisterCallback(
  accountName: string,
  service: CallbackServiceName,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DeviceLocationSuccessResult>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Account number. |
| `service` | [`CallbackServiceName`](../../doc/models/callback-service-name.md) | Template, Required | Callback service name. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DeviceLocationSuccessResult](../../doc/models/device-location-success-result.md).

## Example Usage

```ts
const accountName = '0000123456-00001';

const service = CallbackServiceName.Location;

try {
  const { result, ...httpResponse } = await deviceLocationCallbacksApi.deregisterCallback(
  accountName,
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
| 400 | Error response. | [`DeviceLocationResultError`](../../doc/models/device-location-result-error.md) |

