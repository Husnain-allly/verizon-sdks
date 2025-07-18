# Device Actions

```ts
const deviceActionsApi = new DeviceActionsApi(client);
```

## Class Name

`DeviceActionsApi`

## Methods

* [Aggregate Usage](../../doc/controllers/device-actions.md#aggregate-usage)
* [Daily Usage](../../doc/controllers/device-actions.md#daily-usage)
* [Service Plan List](../../doc/controllers/device-actions.md#service-plan-list)
* [Account Information](../../doc/controllers/device-actions.md#account-information)
* [Retrieve the Global Device List](../../doc/controllers/device-actions.md#retrieve-the-global-device-list)
* [Retrieve Device Provisioning History](../../doc/controllers/device-actions.md#retrieve-device-provisioning-history)
* [Get Asynchronous Request Status](../../doc/controllers/device-actions.md#get-asynchronous-request-status)


# Aggregate Usage

Retrieve the aggregate usage for a device or a number of devices.

```ts
async aggregateUsage(
  body: AggregateUsage,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AggregateUsage`](../../doc/models/aggregate-usage.md) | Body, Required | - |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: AggregateUsage = {
};

try {
  const { result, ...httpResponse } = await deviceActionsApi.aggregateUsage(body);
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


# Daily Usage

Retrieve the daily usage for a device, for a specified period of time, segmented by day

```ts
async dailyUsage(
  body: DailyUsage,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DailyUsageResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DailyUsage`](../../doc/models/daily-usage.md) | Body, Required | - |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DailyUsageResponse](../../doc/models/daily-usage-response.md).

## Example Usage

```ts
const body: DailyUsage = {
};

try {
  const { result, ...httpResponse } = await deviceActionsApi.dailyUsage(body);
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


# Service Plan List

Retrieve all of the service plans, features and carriers associated with the account specified.

```ts
async servicePlanList(
  accountName: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<AccountDetails>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [AccountDetails](../../doc/models/account-details.md).

## Example Usage

```ts
const accountName = 'accountName4';

try {
  const { result, ...httpResponse } = await deviceActionsApi.servicePlanList(accountName);
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


# Account Information

Retrieve all of the service plans, features and carriers associated with the account specified.

```ts
async accountInformation(
  accountName: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<AccountDetails>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [AccountDetails](../../doc/models/account-details.md).

## Example Usage

```ts
const accountName = 'accountName4';

try {
  const { result, ...httpResponse } = await deviceActionsApi.accountInformation(accountName);
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


# Retrieve the Global Device List

Allows the profile to fetch the complete device list. This works with Verizon US and Global profiles.

```ts
async retrieveTheGlobalDeviceList(
  body: GetDeviceListWithProfilesRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDeviceListWithProfilesRequest`](../../doc/models/get-device-list-with-profiles-request.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: GetDeviceListWithProfilesRequest = {
  accountName: '0000123456-00001',
  provisioningStatusFilter: 'ACTIVE',
  profileStatusFilter: 'UNKNOWN',
};

try {
  const { result, ...httpResponse } = await deviceActionsApi.retrieveTheGlobalDeviceList(body);
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


# Retrieve Device Provisioning History

Retrieve the provisioning history of a specific device or devices.

```ts
async retrieveDeviceProvisioningHistory(
  body: ProvhistoryRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProvhistoryRequest`](../../doc/models/provhistory-request.md) | Body, Required | Device Provisioning History |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: ProvhistoryRequest = {
  accountName: '0000123456-00001',
  earliest: '10/15/2021 04:49:35',
  latest: '10/15/2021 04:49:49',
};

try {
  const { result, ...httpResponse } = await deviceActionsApi.retrieveDeviceProvisioningHistory(body);
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


# Get Asynchronous Request Status

Get the status of an asynchronous request made with the Device Actions.

```ts
async getAsynchronousRequestStatus(
  accountName: string,
  requestId: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<StatusResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9\-]{3,32}$` |
| `requestId` | `string` | Template, Required | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9\-]{3,64}$` |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [StatusResponse](../../doc/models/status-response.md).

## Example Usage

```ts
const accountName = '0000123456-00001';

const requestId = 'd1f08526-5443-4054-9a29-4456490ea9f8';

try {
  const { result, ...httpResponse } = await deviceActionsApi.getAsynchronousRequestStatus(
  accountName,
  requestId
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |

