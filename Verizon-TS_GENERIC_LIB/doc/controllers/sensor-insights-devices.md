# Sensor Insights Devices

```ts
const sensorInsightsDevicesApi = new SensorInsightsDevicesApi(client);
```

## Class Name

`SensorInsightsDevicesApi`

## Methods

* [Sensor Insights List Devices Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-list-devices-request)
* [Sensor Insights Patch Device Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-patch-device-request)
* [Sensor Insights Last Reported Time Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-last-reported-time-request)
* [Sensor Insights Device Action Set Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-device-action-set-request)
* [Sensor Insights List Device Experience History Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-list-device-experience-history-request)
* [Sensor Insights List Network Experience History Request](../../doc/controllers/sensor-insights-devices.md#sensor-insights-list-network-experience-history-request)


# Sensor Insights List Devices Request

```ts
async sensorInsightsListDevicesRequest(
  body: DtoListDevicesRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoExpandedDeviceResponse[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListDevicesRequest`](../../doc/models/dto-list-devices-request.md) | Body, Required | List all device details on an account |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoExpandedDeviceResponse[]](../../doc/models/dto-expanded-device-response.md).

## Example Usage

```ts
const body: DtoListDevicesRequest = {
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
  const { result, ...httpResponse } = await sensorInsightsDevicesApi.sensorInsightsListDevicesRequest(body);
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
| 400 | Bad Request | [`ManagementError`](../../doc/models/management-error.md) |
| 401 | UnAuthorized | [`ManagementError`](../../doc/models/management-error.md) |
| 403 | Forbidden | [`ManagementError`](../../doc/models/management-error.md) |
| 404 | Not Found | [`ManagementError`](../../doc/models/management-error.md) |
| 406 | Not Acceptable | [`ManagementError`](../../doc/models/management-error.md) |
| 415 | Unsupported media type | [`ManagementError`](../../doc/models/management-error.md) |
| 429 | Too many requests | [`ManagementError`](../../doc/models/management-error.md) |
| 500 | Internal server error. | [`ManagementError`](../../doc/models/management-error.md) |
| Default | Unexpected error | [`ManagementError`](../../doc/models/management-error.md) |


# Sensor Insights Patch Device Request

```ts
async sensorInsightsPatchDeviceRequest(
  body: DtoPatchDeviceRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<ResourceDevice>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoPatchDeviceRequest`](../../doc/models/dto-patch-device-request.md) | Body, Required | Partially update a device's details |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [ResourceDevice](../../doc/models/resource-device.md).

## Example Usage

```ts
const body: DtoPatchDeviceRequest = {
  accountname: '0000123456-00001',
  device: {
    createdon: '2023-10-02T15:46:34.562Z',
    foreignid: 'c1f178d3-eeee-ffff-gggg-0d6b7ae6022a',
    lastupdated: '2023-10-02T15:46:34.562Z',
    state: 'success',
    versionid: '337bd2e8-eeee-ffff-gggg-5207992fd395',
    accountclientid: 'null',
    billingaccountid: '0000123456-00001',
    chipset: 'The chipset used by the device',
    customdata: {
      'additionalProp1': [100],
      'additionalProp2': [100],
      'additionalProp3': [100]
    },
    description: 'The number of days to retaing the event data',
    esn: 223372036854775800,
    fields: {
      additionalProp1: 'string',
      additionalProp2: 'string',
      additionalProp3: 'string',
    },
    hardwareversion: '1.0',
    iccid: 'The 20-digit Integrated Circuit Card ID (SIM card ID)',
    id: '33e21f61-a44a-44c9-b7a0-a63f5d19bd4f',
    imei: 223372036854775,
    imsi: 223372036854775800,
    licenses: [
      'licenses assigned to the device'
    ],
    mac: 'The Media Access Control address of the device, listed on the device in the format XX-XX-XX-XX-XX-XX or XX:XX:XX:XX:XX:XX',
    manufacturer: 'REOLINK',
    meid: 'The 56-bit Mobile Equipment ID',
    msisdn: 'The Mobile Station International Subscriber Directory Number. In the USA, this is 1+ a 10-digit phone number',
    name: 'User defined name of the record',
    parentdeviceid: 'BLE device ID',
    productmodel: 'Model name of the device',
    providerid: 'Verizon Wireless',
    qrcode: 'The Quick Response (QR) code',
    refid: 'P3730-1422323050860',
    refidtype: 'The type of value represented by `refid`',
    serial: 'The device\'s serial number',
    services: [
      'configuration'
    ],
    sku: 'The Stock Keeping Unit (SKU) number',
    softwareversion: 'the current device software version',
    version: '1.0',
    eventretention: 90,
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
  const { result, ...httpResponse } = await sensorInsightsDevicesApi.sensorInsightsPatchDeviceRequest(body);
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


# Sensor Insights Last Reported Time Request

```ts
async sensorInsightsLastReportedTimeRequest(
  body: DtoLastReportedTimeRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoLastReportedTimeResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoLastReportedTimeRequest`](../../doc/models/dto-last-reported-time-request.md) | Body, Required | Get the last reported information for a device |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoLastReportedTimeResponse](../../doc/models/dto-last-reported-time-response.md).

## Example Usage

```ts
const body: DtoLastReportedTimeRequest = {
  accountname: '0000123456-00001',
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
  const { result, ...httpResponse } = await sensorInsightsDevicesApi.sensorInsightsLastReportedTimeRequest(body);
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
| 403 | Forbidden | [`M403ManagementError`](../../doc/models/m403-management-error.md) |
| 404 | Not Found | [`M404ManagementError`](../../doc/models/m404-management-error.md) |


# Sensor Insights Device Action Set Request

```ts
async sensorInsightsDeviceActionSetRequest(
  body: DmV1DevicesActionsSetRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DtoDeviceActionSetResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DmV1DevicesActionsSetRequest`](../../doc/models/dm-v1-devices-actions-set-request.md) | Body, Required | Set device configuration |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DtoDeviceActionSetResponse](../../doc/models/dto-device-action-set-response.md).

## Example Usage

```ts
const body: DmV1DevicesActionsSetRequest = {
  accountname: '0000123456-00001',
  configuration: {
    deviceConfig: {
      ble: {
        dataMode: 1,
        manufacturerId: 13200,
        maxNumScan: 100,
        minSigStr: -115,
        monitorPeriod: 300,
        moreManufId: [
          {  }
        ],
        opMode: 1,
        reportOffset: 0,
        reportPeriod: 300,
        reportType: 2,
        scanDuration: 20,
      },
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
  const { result, ...httpResponse } = await sensorInsightsDevicesApi.sensorInsightsDeviceActionSetRequest(body);
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
| 403 | Forbidden | [`M403ManagementError`](../../doc/models/m403-management-error.md) |
| 404 | Not Found | [`M404ManagementError`](../../doc/models/m404-management-error.md) |


# Sensor Insights List Device Experience History Request

```ts
async sensorInsightsListDeviceExperienceHistoryRequest(
  body: DtoListDeviceExperienceHistoryRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<UserDeviceExperienceHistory[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListDeviceExperienceHistoryRequest`](../../doc/models/dto-list-device-experience-history-request.md) | Body, Required | List the device experience |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [UserDeviceExperienceHistory[]](../../doc/models/user-device-experience-history.md).

## Example Usage

```ts
const body: DtoListDeviceExperienceHistoryRequest = {
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
  const { result, ...httpResponse } = await sensorInsightsDevicesApi.sensorInsightsListDeviceExperienceHistoryRequest(body);
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


# Sensor Insights List Network Experience History Request

```ts
async sensorInsightsListNetworkExperienceHistoryRequest(
  body: DtoListNetworkExperienceHistoryRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<UserNetworkExperienceHistory[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListNetworkExperienceHistoryRequest`](../../doc/models/dto-list-network-experience-history-request.md) | Body, Required | List the network experience |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [UserNetworkExperienceHistory[]](../../doc/models/user-network-experience-history.md).

## Example Usage

```ts
const body: DtoListNetworkExperienceHistoryRequest = {
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
  const { result, ...httpResponse } = await sensorInsightsDevicesApi.sensorInsightsListNetworkExperienceHistoryRequest(body);
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

