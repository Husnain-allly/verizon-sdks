# Diagnostics Observations

```ts
const diagnosticsObservationsApi = new DiagnosticsObservationsApi(client);
```

## Class Name

`DiagnosticsObservationsApi`

## Methods

* [Start Diagnostics Observation](../../doc/controllers/diagnostics-observations.md#start-diagnostics-observation)
* [Stop Diagnostics Observation](../../doc/controllers/diagnostics-observations.md#stop-diagnostics-observation)


# Start Diagnostics Observation

This endpoint allows the user to start or change observe diagnostics.

```ts
async startDiagnosticsObservation(
  body: ObservationRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DiagnosticsObservationResult>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ObservationRequest`](../../doc/models/observation-request.md) | Body, Required | Request for device observation information. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DiagnosticsObservationResult](../../doc/models/diagnostics-observation-result.md).

## Example Usage

```ts
const body: ObservationRequest = {
  accountName: 'TestQAAccount',
  devices: [
    {
      id: '864508030026238',
      kind: 'IMEI',
    }
  ],
  attributes: [
    {
      name: AttributeIdentifier.RadioSignalStrength,
    },
    {
      name: AttributeIdentifier.LinkQuality,
    },
    {
      name: AttributeIdentifier.NetworkBearer,
    },
    {
      name: AttributeIdentifier.CellId,
    }
  ],
  frequency: {
    value: 15,
    unit: NumericalDataUnit.Second,
  },
  duration: {
    value: 15,
    unit: NumericalDataUnit.Second,
  },
};

try {
  const { result, ...httpResponse } = await diagnosticsObservationsApi.startDiagnosticsObservation(body);
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
  "createdOn": "2019-09-10T19:05:33.33Z",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "CANCEL_OBSERVE_PENDING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultError`](../../doc/models/device-diagnostics-result-error.md) |


# Stop Diagnostics Observation

This endpoint allows the user to stop or reset observe diagnostics.

```ts
async stopDiagnosticsObservation(
  transactionId: string,
  accountName: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<DiagnosticsObservationResult>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `transactionId` | `string` | Query, Required | The ID value associated with the transaction. |
| `accountName` | `string` | Query, Required | The numeric account name. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [DiagnosticsObservationResult](../../doc/models/diagnostics-observation-result.md).

## Example Usage

```ts
const transactionId = '5f4bd2ff-5d7f-444d-af17-3f6a80bb2a94';

const accountName = '0000123456-00001';

try {
  const { result, ...httpResponse } = await diagnosticsObservationsApi.stopDiagnosticsObservation(
  transactionId,
  accountName
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
  "createdOn": "2019-09-10T19:05:33.33Z",
  "transactionID": "9c7bb124-11f5-4ff3-8a88-0eec1ba99205",
  "status": "CANCEL_OBSERVE_PENDING"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response. | [`DeviceDiagnosticsResultError`](../../doc/models/device-diagnostics-result-error.md) |

