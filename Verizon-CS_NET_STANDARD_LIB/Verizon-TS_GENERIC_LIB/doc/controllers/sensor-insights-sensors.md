# Sensor Insights Sensors

```ts
const sensorInsightsSensorsApi = new SensorInsightsSensorsApi(client);
```

## Class Name

`SensorInsightsSensorsApi`

## Methods

* [Sensor Insights List Sensor Devices Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-list-sensor-devices-request)
* [Sensor Insights on Board Sensor Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-on-board-sensor-request)
* [Sensor Insights Sensor on Board Status Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-sensor-on-board-status-request)
* [Sensor Insights Off Board Sensor Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-off-board-sensor-request)
* [Sensor Insights Sensor Off Boarding Status Request](../../doc/controllers/sensor-insights-sensors.md#sensor-insights-sensor-off-boarding-status-request)


# Sensor Insights List Sensor Devices Request

```ts
async sensorInsightsListSensorDevicesRequest(
  body: DtoListSensorDevicesRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<ResourceDevice[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListSensorDevicesRequest`](../../doc/models/dto-list-sensor-devices-request.md) | Body, Required | List details of the sensors |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [ResourceDevice[]](../../doc/models/resource-device.md).

## Example Usage

```ts
const body: DtoListSensorDevicesRequest = {
  accountname: '0000123456-00001',
  filter: {
    mExpand: 'device detail(s)',
    mLimitnumber: 100,
    mNopagination: true,
    mPage: 'The number of pages',
    mPagenumber: 1,
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
    deveui: 'The unique EUI64 address of the device',
    deviceid: 'The UUID of the device',
    esn: 223372036854775800,
    iccid: 'The 20-digit Integrated Circuit Card ID (SIM card ID)',
    imei: 223372036854775,
    imsi: 223372036854775800,
    mac: 'The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX',
    manufacturer: 'REOLINK',
    meid: 'The 56-bit Mobile Equipment ID',
    msisdn: 'The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number',
    nodeUuid: 'The UUID of the node the device is associated with',
    qrcode: 'The Quick Response (QR) code',
    serial: 'The device\'s serial number',
  },
};

try {
  const { result, ...httpResponse } = await sensorInsightsSensorsApi.sensorInsightsListSensorDevicesRequest(body);
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


# Sensor Insights on Board Sensor Request

```ts
async sensorInsightsOnBoardSensorRequest(
  body: DtoOnBoardSensorRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<void>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOnBoardSensorRequest`](../../doc/models/dto-on-board-sensor-request.md) | Body, Required | Onboarding a sensor |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ts
const body: DtoOnBoardSensorRequest = {
  accountname: '0000123456-00001',
  payload: {
    addsensor: {
      deveui: 'The unique EUI64 address of the device',
      appeui: 'global application ID in IEEE EUI64 address space that uniquely identifies the entity able to process the JoinReq frame',
      appkey: 'Encryption key used for messages during every over the air activation',
      mClass: 'A',
      kind: 'ts.device.sensor.lorawan.radiobridge.RBS301-DWS-US',
      description: 'used to identify water leaks',
      name: 'Water Leak sensor',
      customdata: {
        'additionalProp1': [100],
        'additionalProp2': [100],
        'additionalProp3': [100]
      },
    },
  },
};

try {
  const { result, ...httpResponse } = await sensorInsightsSensorsApi.sensorInsightsOnBoardSensorRequest(body);
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


# Sensor Insights Sensor on Board Status Request

```ts
async sensorInsightsSensorOnBoardStatusRequest(
  body: DtoSensorOnBoardStatusRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoSensorOnBoardingStatusResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoSensorOnBoardStatusRequest`](../../doc/models/dto-sensor-on-board-status-request.md) | Body, Required | Get the sensor's onboarding status |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoSensorOnBoardingStatusResponse](../../doc/models/dto-sensor-on-boarding-status-response.md).

## Example Usage

```ts
const body: DtoSensorOnBoardStatusRequest = {
  accountname: '0000123456-00001',
  gatewayidentifier: {
    deviceid: '00000000-0000-0000-0000-000000000255',
  },
  onboarding: {
    additionalProperties: {
      'sensoridentifiers': { 'deveui': 'The unique EUI64 address of the device' }
    },
  },
};

try {
  const { result, ...httpResponse } = await sensorInsightsSensorsApi.sensorInsightsSensorOnBoardStatusRequest(body);
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


# Sensor Insights Off Board Sensor Request

```ts
async sensorInsightsOffBoardSensorRequest(
  body: DtoOffBoardSensorRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<void>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOffBoardSensorRequest`](../../doc/models/dto-off-board-sensor-request.md) | Body, Required | Offboard a sensor |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance.

## Example Usage

```ts
const body: DtoOffBoardSensorRequest = {
  accountname: '0000123456-00001',
  configuration: {
    removesensor: {
      deveui: 'The unique EUI64 address of the device',
    },
  },
};

try {
  const { result, ...httpResponse } = await sensorInsightsSensorsApi.sensorInsightsOffBoardSensorRequest(body);
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


# Sensor Insights Sensor Off Boarding Status Request

```ts
async sensorInsightsSensorOffBoardingStatusRequest(
  body: DtoSensorOffBoardStatusRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoSensorOffBoardingStatusResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoSensorOffBoardStatusRequest`](../../doc/models/dto-sensor-off-board-status-request.md) | Body, Required | Get a sensor's offboarding status |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoSensorOffBoardingStatusResponse](../../doc/models/dto-sensor-off-boarding-status-response.md).

## Example Usage

```ts
const body: DtoSensorOffBoardStatusRequest = {
  accountname: '0000123456-00001',
  gatewayidentifier: {
    deviceid: 'UUID of the Gateway device',
  },
  offboarding: {
    additionalProperties: {
      'sensoridentifiers': { 'deveui': 'The unique EUI64 address of the device' }
    },
  },
};

try {
  const { result, ...httpResponse } = await sensorInsightsSensorsApi.sensorInsightsSensorOffBoardingStatusRequest(body);
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

