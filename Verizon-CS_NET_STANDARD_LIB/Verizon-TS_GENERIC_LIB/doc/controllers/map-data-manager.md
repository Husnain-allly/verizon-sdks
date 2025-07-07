# Map Data Manager

```ts
const mapDataManagerApi = new MapDataManagerApi(client);
```

## Class Name

`MapDataManagerApi`

## Methods

* [Upload Map Data Message](../../doc/controllers/map-data-manager.md#upload-map-data-message)
* [Download Map Data Message](../../doc/controllers/map-data-manager.md#download-map-data-message)


# Upload Map Data Message

This endpoint allows the user to upload map messages in SAE J2735 MAP messages in ASN.1 UPER or JER (JSON) formats. The MAP data message can have more than one intersections in it.
Note: The user needs to authenticate with their ThingSpace credentials using the Access/Bearer and Session/M2M tokens in order to call this API.

```ts
async uploadMapDataMessage(
  vendorId: string,
  body: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<string>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `body` | `string` | Body, Required | **Constraints**: *Maximum Length*: `1000000` |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type string.

## Example Usage

```ts
const vendorId = 'VerizonETX';

const body = '{"messageId":18,"value":{"intersections":[{"id":{"region":0,"id":156},"laneSet":[{"connectsTo":[{"connectingLane":{"lane":25,"maneuver":"8000"},"signalGroup":2},{"connectingLane":{"lane":29,"maneuver":"2000"},"signalGroup":2}],"laneAttributes":{"directionalUse":"80","laneType":{"parking":"0000"},"sharedWith":"0000"},"laneID":1,"maneuvers":"a000","nodeList":{"nodes":[{"delta":{"node-XY6":{"x":-4012,"y":365}}},{"delta":{"node-XY6":{"x":-5541,"y":7249}}},{"delta":{"node-XY6":{"x":-4379,"y":5828}}},{"delta":{"node-XY6":{"x":-3590,"y":4729}}},{"delta":{"node-XY6":{"x":-5012,"y":6994}}}]}}],"laneWidth":366,"refPoint":{"lat":389284111,"long":-772410713},"revision":3}],"msgIssueRevision":3}}\n';

try {
  const { result, ...httpResponse } = await mapDataManagerApi.uploadMapDataMessage(
  vendorId,
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

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid request | [`MapDataResponseError`](../../doc/models/map-data-response-error.md) |
| 401 | Unauthorized | [`MapDataResponseError`](../../doc/models/map-data-response-error.md) |
| 403 | Forbidden Request | [`MapDataResponseError`](../../doc/models/map-data-response-error.md) |
| 429 | Too Many Requests | [`MapDataResponseError`](../../doc/models/map-data-response-error.md) |
| 503 | Internal server Error | [`MapDataResponseError`](../../doc/models/map-data-response-error.md) |
| Default | Unexpected Error | [`MapDataResponseError`](../../doc/models/map-data-response-error.md) |


# Download Map Data Message

This endpoint allows user to download SAE J2735 MAP messages in ASN.1 UPER format. The area for the MAP messages is needed to be defined in the query.

```ts
async downloadMapDataMessage(
  vendorId: string,
  geofence: Geofence,
  requestOptions?: RequestOptions
): Promise<ApiResponse<string>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `vendorId` | `string` | Header, Required | The VendorID set during the Vendor registration call.<br><br>**Constraints**: *Maximum Length*: `64`, *Pattern*: `^[a-zA-Z0-9]+$` |
| `geofence` | [`Geofence`](../../doc/models/geofence.md) | Query, Required | The area where the user wants to receive MAP data from. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type string.

## Example Usage

```ts
const vendorId = 'VerizonETX';

const geofence: Geofence = {
  type: 'Polygon',
  coordinates: [
    -77.47939538.990773,
    -77.11456638.99944,
    -77.10022838.817204,
    -77.41805938.827754,
    -77.47939538.990773
  ],
};

try {
  const { result, ...httpResponse } = await mapDataManagerApi.downloadMapDataMessage(
  vendorId,
  geofence
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
| 400 | Invalid request | [`MapDataResponseError`](../../doc/models/map-data-response-error.md) |
| 401 | Unauthorized | [`MapDataResponseError`](../../doc/models/map-data-response-error.md) |
| 403 | Forbidden Request | [`MapDataResponseError`](../../doc/models/map-data-response-error.md) |
| 429 | Too Many Requests | [`MapDataResponseError`](../../doc/models/map-data-response-error.md) |
| 503 | Internal server Error | [`MapDataResponseError`](../../doc/models/map-data-response-error.md) |
| Default | Unexpected Error | [`MapDataResponseError`](../../doc/models/map-data-response-error.md) |

