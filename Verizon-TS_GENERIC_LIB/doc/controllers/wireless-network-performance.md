# Wireless Network Performance

```ts
const wirelessNetworkPerformanceApi = new WirelessNetworkPerformanceApi(client);
```

## Class Name

`WirelessNetworkPerformanceApi`

## Methods

* [Near Real Time Network Conditions](../../doc/controllers/wireless-network-performance.md#near-real-time-network-conditions)
* [Domestic 4 G and 5G Nationwide Network Coverage](../../doc/controllers/wireless-network-performance.md#domestic-4-g-and-5g-nationwide-network-coverage)
* [Site Proximity](../../doc/controllers/wireless-network-performance.md#site-proximity)
* [Device Experience 30 Days History](../../doc/controllers/wireless-network-performance.md#device-experience-30-days-history)
* [Device Experience Bulk Latest](../../doc/controllers/wireless-network-performance.md#device-experience-bulk-latest)


# Near Real Time Network Conditions

WNP Query for current network condition.

```ts
async nearRealTimeNetworkConditions(
  body: GetNetworkConditionsRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<WnpRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetNetworkConditionsRequest`](../../doc/models/get-network-conditions-request.md) | Body, Required | Request for current network health. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [WnpRequestResponse](../../doc/models/wnp-request-response.md).

## Example Usage

```ts
const body: GetNetworkConditionsRequest = {
  accountName: '0000123456-00001',
  locationType: 'LONGLAT',
  coordinates: {
    latitude: '-33.84819',
    longitude: '151.22049',
  },
};

try {
  const { result, ...httpResponse } = await wirelessNetworkPerformanceApi.nearRealTimeNetworkConditions(body);
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
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseError`](../../doc/models/wnp-rest-error-response-error.md) |


# Domestic 4 G and 5G Nationwide Network Coverage

Run a report for FWA Address qualification or to determine network types available and available coverage. Network types covered include: CAT-M, NB-IOT, LTE, LTE-AWS, 5GNW, MMWAVE and C-BAND.

```ts
async domestic4GAnd5GNationwideNetworkCoverage(
  body: M2MV1IntelligenceWirelessCoverageRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<WnpRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`M2MV1IntelligenceWirelessCoverageRequest`](../../doc/models/m2m-v1-intelligence-wireless-coverage-request.md) | Body, Required | Request for network coverage details. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [WnpRequestResponse](../../doc/models/wnp-request-response.md).

## Example Usage

```ts
const body: M2MV1IntelligenceWirelessCoverageRequest = {
  accountName: '0000123456-00001',
  requestType: 'FWA',
  locationType: 'ADDRESS',
  locations: {
    addressList: [
      {
        addressLine1: 'street address',
        city: 'city',
        state: 'LA',
        country: 'USA',
        zip: '00000',
      }
    ],
  },
  networkTypesList: [
    {
      networkType: 'LTE',
    }
  ],
};

try {
  const { result, ...httpResponse } = await wirelessNetworkPerformanceApi.domestic4GAnd5GNationwideNetworkCoverage(body);
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
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseError`](../../doc/models/wnp-rest-error-response-error.md) |


# Site Proximity

Identify the direction and general distance of nearby cell sites and the technology supported by the equipment.

```ts
async siteProximity(
  body: GetNetworkConditionsRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<WnpRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetNetworkConditionsRequest`](../../doc/models/get-network-conditions-request.md) | Body, Required | Request for cell site proximity. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [WnpRequestResponse](../../doc/models/wnp-request-response.md).

## Example Usage

```ts
const body: GetNetworkConditionsRequest = {
  accountName: '0000123456-00001',
  locationType: 'LONGLAT',
  coordinates: {
    latitude: '-33.84819',
    longitude: '151.22049',
  },
};

try {
  const { result, ...httpResponse } = await wirelessNetworkPerformanceApi.siteProximity(body);
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
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseError`](../../doc/models/wnp-rest-error-response-error.md) |


# Device Experience 30 Days History

A report of a specific device's service scores over a 30 day period.

```ts
async deviceExperience30DaysHistory(
  body: GetDeviceExperienceScoreHistoryRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<WnpRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDeviceExperienceScoreHistoryRequest`](../../doc/models/get-device-experience-score-history-request.md) | Body, Required | Request for a device's 30 day experience. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [WnpRequestResponse](../../doc/models/wnp-request-response.md).

## Example Usage

```ts
const body: GetDeviceExperienceScoreHistoryRequest = {
  accountName: '0000123456-00001',
  deviceId: {
    kind: 'iccid',
    id: '01234567899876543210',
    mdn: '0123456789',
  },
};

try {
  const { result, ...httpResponse } = await wirelessNetworkPerformanceApi.deviceExperience30DaysHistory(body);
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
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseError`](../../doc/models/wnp-rest-error-response-error.md) |


# Device Experience Bulk Latest

Run a report to view the latest device experience score for specific devices.

```ts
async deviceExperienceBulkLatest(
  body: GetDeviceExperienceScoreBulkRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<WnpRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GetDeviceExperienceScoreBulkRequest`](../../doc/models/get-device-experience-score-bulk-request.md) | Body, Required | Request for bulk latest history details. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [WnpRequestResponse](../../doc/models/wnp-request-response.md).

## Example Usage

```ts
const body: GetDeviceExperienceScoreBulkRequest = {
  accountName: '0000123456-00001',
  deviceList: [
    {
      kind: 'iccid',
      id: '01234567899876543210',
      mdn: '0123456789',
    }
  ],
};

try {
  const { result, ...httpResponse } = await wirelessNetworkPerformanceApi.deviceExperienceBulkLatest(body);
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
  "requestId": "d1f08526-eeee-ffff-gggg-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`WnpRestErrorResponseError`](../../doc/models/wnp-rest-error-response-error.md) |

