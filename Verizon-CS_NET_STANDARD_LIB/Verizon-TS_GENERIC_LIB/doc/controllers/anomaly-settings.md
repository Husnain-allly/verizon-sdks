# Anomaly Settings

```ts
const anomalySettingsApi = new AnomalySettingsApi(client);
```

## Class Name

`AnomalySettingsApi`

## Methods

* [Activate Anomaly Detection](../../doc/controllers/anomaly-settings.md#activate-anomaly-detection)
* [List Anomaly Detection Settings](../../doc/controllers/anomaly-settings.md#list-anomaly-detection-settings)
* [Reset Anomaly Detection Parameters](../../doc/controllers/anomaly-settings.md#reset-anomaly-detection-parameters)


# Activate Anomaly Detection

Uses the subscribed account ID to activate anomaly detection and set threshold values.

```ts
async activateAnomalyDetection(
  body: AnomalyDetectionRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<IntelligenceSuccessResult>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`AnomalyDetectionRequest`](../../doc/models/anomaly-detection-request.md) | Body, Required | Request to activate anomaly detection. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [IntelligenceSuccessResult](../../doc/models/intelligence-success-result.md).

## Example Usage

```ts
const body: AnomalyDetectionRequest = {
  accountName: '0000123456-00001',
  requestType: 'anomaly',
  sensitivityParameter: {
    abnormalMaxValue: 1.1,
    enableAbnormal: true,
    enableVeryAbnormal: true,
    veryAbnormalMaxValue: 0.55,
  },
};

try {
  const { result, ...httpResponse } = await anomalySettingsApi.activateAnomalyDetection(body);
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
  "status": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | An error occurred. | [`IntelligenceResultError`](../../doc/models/intelligence-result-error.md) |


# List Anomaly Detection Settings

Retrieves the current anomaly detection settings for an account.

```ts
async listAnomalyDetectionSettings(
  accountName: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<AnomalyDetectionSettings>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | The name of the subscribed account. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [AnomalyDetectionSettings](../../doc/models/anomaly-detection-settings.md).

## Example Usage

```ts
const accountName = '0000123456-00001';

try {
  const { result, ...httpResponse } = await anomalySettingsApi.listAnomalyDetectionSettings(accountName);
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
  "accountName": "Success",
  "sensitivityParameter": {
    "abnormalMaxValue": 1.1,
    "enableAbnormal": true,
    "enableVeryAbnormal": true,
    "veryAbnormalMaxValue": 0.55
  },
  "status": "Active"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | An error occurred. | [`IntelligenceResultError`](../../doc/models/intelligence-result-error.md) |


# Reset Anomaly Detection Parameters

Resets the thresholds to zero.

```ts
async resetAnomalyDetectionParameters(
  accountName: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<IntelligenceSuccessResult>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | The name of the subscribed account. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [IntelligenceSuccessResult](../../doc/models/intelligence-success-result.md).

## Example Usage

```ts
const accountName = '0000123456-00001';

try {
  const { result, ...httpResponse } = await anomalySettingsApi.resetAnomalyDetectionParameters(accountName);
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
  "status": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | An error occurred. | [`IntelligenceResultError`](../../doc/models/intelligence-result-error.md) |

