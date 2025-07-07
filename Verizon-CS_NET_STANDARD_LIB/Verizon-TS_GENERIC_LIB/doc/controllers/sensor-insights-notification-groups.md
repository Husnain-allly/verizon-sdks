# Sensor Insights Notification Groups

```ts
const sensorInsightsNotificationGroupsApi = new SensorInsightsNotificationGroupsApi(client);
```

## Class Name

`SensorInsightsNotificationGroupsApi`

## Methods

* [Sensor Insights List Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-list-notification-group-request)
* [Sensor Insights Update Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-update-notification-group-request)
* [Sensor Insights Create Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-create-notification-group-request)
* [Sensor Insights Delete Notification Group](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-delete-notification-group)
* [Sensor Insights Add Users to Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-add-users-to-notification-group-request)
* [Sensor Insights Remove Users From Notification Group Request](../../doc/controllers/sensor-insights-notification-groups.md#sensor-insights-remove-users-from-notification-group-request)


# Sensor Insights List Notification Group Request

```ts
async sensorInsightsListNotificationGroupRequest(
  body: DtoListNotificationGroupRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoNotificationGroupResponseEntity[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListNotificationGroupRequest`](../../doc/models/dto-list-notification-group-request.md) | Body, Required | Retrieve a notification group |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoNotificationGroupResponseEntity[]](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```ts
const body: DtoListNotificationGroupRequest = {
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
};

try {
  const { result, ...httpResponse } = await sensorInsightsNotificationGroupsApi.sensorInsightsListNotificationGroupRequest(body);
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


# Sensor Insights Update Notification Group Request

```ts
async sensorInsightsUpdateNotificationGroupRequest(
  body: DtoUpdateNotificationGroupRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoNotificationGroupResponseEntity>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoUpdateNotificationGroupRequest`](../../doc/models/dto-update-notification-group-request.md) | Body, Required | Partially update a notification group |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoNotificationGroupResponseEntity](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```ts
const body: DtoUpdateNotificationGroupRequest = {
  group: {
    description: 'a short description',
    groupemail: 'email@domain.com',
    name: 'User defined name of the record',
  },
  accountname: '0000123456-00001',
  id: '7b0b9c53-eeee-ffff-gggg-bde5e44f4b12',
  userids: [
    'ee70a869-eeee-ffff-gggg-07c14c31f96e',
    '131501ff-eeee-ffff-gggg-647d19179a12'
  ],
};

try {
  const { result, ...httpResponse } = await sensorInsightsNotificationGroupsApi.sensorInsightsUpdateNotificationGroupRequest(body);
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


# Sensor Insights Create Notification Group Request

```ts
async sensorInsightsCreateNotificationGroupRequest(
  body: DtoCreateNotificationGroupRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoNotificationGroupResponseEntity>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoCreateNotificationGroupRequest`](../../doc/models/dto-create-notification-group-request.md) | Body, Required | Create a notification group |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoNotificationGroupResponseEntity](../../doc/models/dto-notification-group-response-entity.md).

## Example Usage

```ts
const body: DtoCreateNotificationGroupRequest = {
  group: {
    description: 'a short description',
    groupemail: 'email@domain.com',
    name: 'User defined name of the record',
  },
  accountname: '0000123456-00001',
  userids: [
    'ee70a869-eeee-ffff-gggg-07c14c31f96e',
    '131501ff-eeee-ffff-gggg-647d19179a12'
  ],
};

try {
  const { result, ...httpResponse } = await sensorInsightsNotificationGroupsApi.sensorInsightsCreateNotificationGroupRequest(body);
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
| 406 | Not Acceptable | [`ManagementError`](../../doc/models/management-error.md) |
| 415 | Unsupported media type | [`ManagementError`](../../doc/models/management-error.md) |
| 429 | Too many requests | [`ManagementError`](../../doc/models/management-error.md) |
| 500 | Internal server error. | [`M500ManagementError`](../../doc/models/m500-management-error.md) |
| Default | Unexpected error | [`ManagementError`](../../doc/models/management-error.md) |


# Sensor Insights Delete Notification Group

```ts
async sensorInsightsDeleteNotificationGroup(
  payload: DtoDeleteNotificationGroupRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<void>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `payload` | [`DtoDeleteNotificationGroupRequest`](../../doc/models/dto-delete-notification-group-request.md) | Query, Required | Payload for the delete request. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ts
const payload: DtoDeleteNotificationGroupRequest = {
  accountname: '0000123456-00001',
  force: true,
  id: '6737ca22-eeee-ffff-gggg-84c09f2ede8e',
};

try {
  const { result, ...httpResponse } = await sensorInsightsNotificationGroupsApi.sensorInsightsDeleteNotificationGroup(payload);
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


# Sensor Insights Add Users to Notification Group Request

```ts
async sensorInsightsAddUsersToNotificationGroupRequest(
  body: DtoAddUsersToNotificationGroupRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<void>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoAddUsersToNotificationGroupRequest`](../../doc/models/dto-add-users-to-notification-group-request.md) | Body, Required | Add users to a notification group |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ts
const body: DtoAddUsersToNotificationGroupRequest = {
  accountname: '0000123456-00001',
  id: '45f1a56e-eeee-ffff-gggg-68cb994feb5f',
  userids: [
    'ee70a869-eeee-ffff-gggg-07c14c31f96e',
    '131501ff-eeee-ffff-gggg-647d19179a12'
  ],
};

try {
  const { result, ...httpResponse } = await sensorInsightsNotificationGroupsApi.sensorInsightsAddUsersToNotificationGroupRequest(body);
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


# Sensor Insights Remove Users From Notification Group Request

```ts
async sensorInsightsRemoveUsersFromNotificationGroupRequest(
  body: DtoRemoveUsersFromNotificationGroupRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<void>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoRemoveUsersFromNotificationGroupRequest`](../../doc/models/dto-remove-users-from-notification-group-request.md) | Body, Required | Remove users from a notification group |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ts
const body: DtoRemoveUsersFromNotificationGroupRequest = {
  accountname: '0000123456-00001',
  id: '111538a8-eeee-ffff-gggg-3b72804403e8',
  userids: [
    'ee70a869-eeee-ffff-gggg-07c14c31f96e',
    '131501ff-eeee-ffff-gggg-647d19179a12'
  ],
};

try {
  const { result, ...httpResponse } = await sensorInsightsNotificationGroupsApi.sensorInsightsRemoveUsersFromNotificationGroupRequest(body);
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

