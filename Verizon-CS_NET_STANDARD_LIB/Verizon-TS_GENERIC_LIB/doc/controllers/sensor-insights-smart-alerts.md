# Sensor Insights Smart Alerts

```ts
const sensorInsightsSmartAlertsApi = new SensorInsightsSmartAlertsApi(client);
```

## Class Name

`SensorInsightsSmartAlertsApi`

## Methods

* [Sensor Insights List Smart Alerts Request](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-list-smart-alerts-request)
* [Sensor Insights Patch Smart Alert Request](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-patch-smart-alert-request)
* [Sensor Insights Bulk Update](../../doc/controllers/sensor-insights-smart-alerts.md#sensor-insights-bulk-update)


# Sensor Insights List Smart Alerts Request

```ts
async sensorInsightsListSmartAlertsRequest(
  body: DtoListSmartAlertsRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<UserSmartAlert[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListSmartAlertsRequest`](../../doc/models/dto-list-smart-alerts-request.md) | Body, Required | Retrieve a smart alert |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [UserSmartAlert[]](../../doc/models/user-smart-alert.md).

## Example Usage

```ts
const body: DtoListSmartAlertsRequest = {
  accountname: '0000123456-00001',
  filter: {
    mExpand: 'device detail(s)',
    mLimitnumber: 100,
    mNopagination: true,
    mPage: 'The number of pages',
    mPagenumber: 100,
    mProjection: [
      'specific device fields requested'
    ],
    mSelection: {
      'additionalProp1': 'string',
      'additionalProp2': 'string',
      'additionalProp3': 'string'
    },
  },
  resourceidentifier: {
    id: 'cb3eea68-eeee-ffff-gggg-ac4463ccd073',
  },
};

try {
  const { result, ...httpResponse } = await sensorInsightsSmartAlertsApi.sensorInsightsListSmartAlertsRequest(body);
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
| 400 | Bad Request | [`M400ManagementError`](../../doc/models/m400-management-error.md) |
| 401 | UnAuthorized | [`ManagementError`](../../doc/models/management-error.md) |
| 403 | Forbidden | [`M403ManagementError`](../../doc/models/m403-management-error.md) |
| 404 | Not Found | [`M404ManagementError`](../../doc/models/m404-management-error.md) |
| 406 | Not Acceptable | [`ManagementError`](../../doc/models/management-error.md) |
| 415 | Unsupported media type | [`ManagementError`](../../doc/models/management-error.md) |
| 429 | Too many requests | [`ManagementError`](../../doc/models/management-error.md) |
| 500 | Internal server error. | [`M500ManagementError`](../../doc/models/m500-management-error.md) |
| Default | Unexpected error | [`ManagementError`](../../doc/models/management-error.md) |


# Sensor Insights Patch Smart Alert Request

```ts
async sensorInsightsPatchSmartAlertRequest(
  body: DtoPatchSmartAlertRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<UserSmartAlert>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoPatchSmartAlertRequest`](../../doc/models/dto-patch-smart-alert-request.md) | Body, Required | Partially update a smart alert |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [UserSmartAlert](../../doc/models/user-smart-alert.md).

## Example Usage

```ts
const body: DtoPatchSmartAlertRequest = {
  accountname: '0000123456-00001',
  resourceidentifier: {
    id: '0b37ab8b-eeee-ffff-gggg-e0149af43f43',
  },
  smartalert: {
    createdon: '2023-10-02T15:46:34.562Z',
    lastupdated: '2023-10-02T15:46:34.562Z',
    versionid: '337bd2e8-eeee-ffff-gggg-5207992fd395',
    accountclientid: 'null',
    billingaccountid: '0000123456-00001',
    category: 'telemetry',
    condition: 2592000,
    description: 'a short description',
    deviceid: 'The UUID of the device',
    foreignid: 'c1f178d3-eeee-ffff-gggg-0d6b7ae6022a',
    id: 'fecbe450-eeee-ffff-gggg-aa166fd5f8e3',
    isacknowledged: true,
    iscleared: true,
    isdisabled: false,
    name: 'User defined name of the record',
    ruleid: 'The UUID of a rule',
    severity: 'minor',
    state: 'success',
    template: 'The template ID',
    version: '1.0',
  },
};

try {
  const { result, ...httpResponse } = await sensorInsightsSmartAlertsApi.sensorInsightsPatchSmartAlertRequest(body);
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
| 400 | Bad Request | [`M400ManagementError`](../../doc/models/m400-management-error.md) |
| 401 | UnAuthorized | [`ManagementError`](../../doc/models/management-error.md) |
| 403 | Forbidden | [`M403ManagementError`](../../doc/models/m403-management-error.md) |
| 404 | Not Found | [`M404ManagementError`](../../doc/models/m404-management-error.md) |
| 406 | Not Acceptable | [`ManagementError`](../../doc/models/management-error.md) |
| 415 | Unsupported media type | [`ManagementError`](../../doc/models/management-error.md) |
| 429 | Too many requests | [`ManagementError`](../../doc/models/management-error.md) |
| 500 | Internal server error. | [`M500ManagementError`](../../doc/models/m500-management-error.md) |
| Default | Unexpected error | [`ManagementError`](../../doc/models/management-error.md) |


# Sensor Insights Bulk Update

```ts
async sensorInsightsBulkUpdate(
  body: DtoBulkUpdate,
  requestOptions?: RequestOptions
): Promise<ApiResponse<UserSmartAlert>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoBulkUpdate`](../../doc/models/dto-bulk-update.md) | Body, Required | Bulk update smart alerts |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [UserSmartAlert](../../doc/models/user-smart-alert.md).

## Example Usage

```ts
const body: DtoBulkUpdate = {
  accountname: '0000123456-00001',
  resourceidentifiers: [
    {
      id: 'ee70a869-eeee-ffff-gggg-07c14c31f96e',
    },
    {
      deviceid: 'The UUID of the device',
    }
  ],
  smartalert: {
    name: 'User defined name of the record',
  },
};

try {
  const { result, ...httpResponse } = await sensorInsightsSmartAlertsApi.sensorInsightsBulkUpdate(body);
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
| 400 | Bad Request | [`M400ManagementError`](../../doc/models/m400-management-error.md) |
| 401 | UnAuthorized | [`ManagementError`](../../doc/models/management-error.md) |
| 403 | Forbidden | [`M403ManagementError`](../../doc/models/m403-management-error.md) |
| 404 | Not Found | [`M404ManagementError`](../../doc/models/m404-management-error.md) |
| 406 | Not Acceptable | [`ManagementError`](../../doc/models/management-error.md) |
| 415 | Unsupported media type | [`ManagementError`](../../doc/models/management-error.md) |
| 429 | Too many requests | [`ManagementError`](../../doc/models/management-error.md) |
| 500 | Internal server error. | [`M500ManagementError`](../../doc/models/m500-management-error.md) |
| Default | Unexpected error | [`ManagementError`](../../doc/models/management-error.md) |

