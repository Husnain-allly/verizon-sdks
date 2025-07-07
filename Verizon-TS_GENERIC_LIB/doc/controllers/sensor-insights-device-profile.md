# Sensor Insights Device Profile

```ts
const sensorInsightsDeviceProfileApi = new SensorInsightsDeviceProfileApi(client);
```

## Class Name

`SensorInsightsDeviceProfileApi`

## Methods

* [Create a Profile](../../doc/controllers/sensor-insights-device-profile.md#create-a-profile)
* [Delete a Profile](../../doc/controllers/sensor-insights-device-profile.md#delete-a-profile)
* [Update a Profile](../../doc/controllers/sensor-insights-device-profile.md#update-a-profile)
* [Query a Profile](../../doc/controllers/sensor-insights-device-profile.md#query-a-profile)


# Create a Profile

Create a device profile

```ts
async createAProfile(
  body: DtoConfigurationProfile,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoProfileResponse[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoConfigurationProfile`](../../doc/models/dto-configuration-profile.md) | Body, Required | - |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoProfileResponse[]](../../doc/models/dto-profile-response.md).

## Example Usage

```ts
const body: DtoConfigurationProfile = {
  accountname: '0000123456-00001',
  profiles: [
    {
      kind: 'the kind of profile being created',
      version: '1.0',
      modelid: '00000000-0000-0000-0000-000000000019',
      name: 'Demo Entry sensor 1730928792',
      configuration: { 'randomInt': 21, 'resportingInterval': 24 },
    }
  ],
};

try {
  const { result, ...httpResponse } = await sensorInsightsDeviceProfileApi.createAProfile(body);
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
| 500 | Internal server error. | [`M500ManagementError`](../../doc/models/m500-management-error.md) |


# Delete a Profile

Delete a device profile

```ts
async deleteAProfile(
  deleterequest: DtoConfigurationProfileDelete,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoProfileResponse[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deleterequest` | [`DtoConfigurationProfileDelete`](../../doc/models/dto-configuration-profile-delete.md) | Header, Required | payload for the delete request |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoProfileResponse[]](../../doc/models/dto-profile-response.md).

## Example Usage

```ts
const deleterequest: DtoConfigurationProfileDelete = {
  accountName: '0000123456-00001',
};

try {
  const { result, ...httpResponse } = await sensorInsightsDeviceProfileApi.deleteAProfile(deleterequest);
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
| 500 | Internal server error. | [`M500ManagementError`](../../doc/models/m500-management-error.md) |


# Update a Profile

Partially update a device profile

```ts
async updateAProfile(
  body: DtoConfigurationProfilePath,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoProfileResponse[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoConfigurationProfilePath`](../../doc/models/dto-configuration-profile-path.md) | Body, Required | - |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoProfileResponse[]](../../doc/models/dto-profile-response.md).

## Example Usage

```ts
const body: DtoConfigurationProfilePath = {
  additionalProperties: {
    'accountname': '0000123456-00001',
    'profiles': [{ 'kind': 'the kind of profile being created', 'version': '1.0', 'modelid': '00000000-0000-0000-0000-000000000019', 'name': 'Demo Entry sensor 1730928792', 'configuration': { 'randomInt': 21, 'resportingInterval': 24 } }]
  },
};

try {
  const { result, ...httpResponse } = await sensorInsightsDeviceProfileApi.updateAProfile(body);
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
| 500 | Internal server error. | [`M500ManagementError`](../../doc/models/m500-management-error.md) |


# Query a Profile

Query a device profile for an individual device

```ts
async queryAProfile(
  body: ResourceResourceQuery,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoProfileResponse[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ResourceResourceQuery`](../../doc/models/resource-resource-query.md) | Body, Required | body |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoProfileResponse[]](../../doc/models/dto-profile-response.md).

## Example Usage

```ts
const body: ResourceResourceQuery = {
  filter: {
    mSelection: {
      modelid: '00000000-0000-0000-0000-000000000019',
    },
    mQuerytotalcount: true,
  },
};

try {
  const { result, ...httpResponse } = await sensorInsightsDeviceProfileApi.queryAProfile(body);
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
| 500 | Internal server error. | [`M500ManagementError`](../../doc/models/m500-management-error.md) |

