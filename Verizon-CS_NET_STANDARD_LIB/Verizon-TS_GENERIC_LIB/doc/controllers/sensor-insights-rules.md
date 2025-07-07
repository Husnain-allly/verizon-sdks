# Sensor Insights Rules

```ts
const sensorInsightsRulesApi = new SensorInsightsRulesApi(client);
```

## Class Name

`SensorInsightsRulesApi`

## Methods

* [Sensor Insights Overwrite Rule Request](../../doc/controllers/sensor-insights-rules.md#sensor-insights-overwrite-rule-request)
* [Sensor Insights List Rules Request](../../doc/controllers/sensor-insights-rules.md#sensor-insights-list-rules-request)


# Sensor Insights Overwrite Rule Request

```ts
async sensorInsightsOverwriteRuleRequest(
  body: DtoOverwriteRuleRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<ResourceRule>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoOverwriteRuleRequest`](../../doc/models/dto-overwrite-rule-request.md) | Body, Required | Overwrite a rule |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [ResourceRule](../../doc/models/resource-rule.md).

## Example Usage

```ts
const body: DtoOverwriteRuleRequest = {
  accountname: '0000123456-00001',
  resourceidentifier: {
    id: '7f5f610a-eeee-ffff-gggg-4d20cf3dcfbc',
  },
  rule: {
    createdon: '2023-10-02T15:46:34.562Z',
    foreignid: 'c1f178d3-eeee-ffff-gggg-0d6b7ae6022a',
    lastupdated: '2023-10-02T15:46:34.562Z',
    rulechain: {  },
    versionid: '337bd2e8-eeee-ffff-gggg-5207992fd395',
    accountclientid: 'null',
    billingaccountid: 'The billing account ID',
    description: 'a short description',
    deviceid: 'The UUID of the device',
    disabled: true,
    id: 'bc5b5b5a-eeee-ffff-gggg-cb2cb2533d47',
    name: 'User defined name of the record',
    rulesyntax: 'The rule syntax',
    version: '1.0',
  },
};

try {
  const { result, ...httpResponse } = await sensorInsightsRulesApi.sensorInsightsOverwriteRuleRequest(body);
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


# Sensor Insights List Rules Request

```ts
async sensorInsightsListRulesRequest(
  body: DtoListRulesRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<ResourceRule[]>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`DtoListRulesRequest`](../../doc/models/dto-list-rules-request.md) | Body, Required | Retrieve a rule |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [ResourceRule[]](../../doc/models/resource-rule.md).

## Example Usage

```ts
const body: DtoListRulesRequest = {
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
    id: 'ffb86390-eeee-ffff-gggg-9d1180882d63',
  },
};

try {
  const { result, ...httpResponse } = await sensorInsightsRulesApi.sensorInsightsListRulesRequest(body);
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

