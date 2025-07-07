# SIM Actions

```ts
const simActionsApi = new SimActionsApi(client);
```

## Class Name

`SimActionsApi`

## Methods

* [Newactivatecode](../../doc/controllers/sim-actions.md#newactivatecode)
* [Setactivate Using POST](../../doc/controllers/sim-actions.md#setactivate-using-post)
* [Setdeactivate Using POST](../../doc/controllers/sim-actions.md#setdeactivate-using-post)


# Newactivatecode

System assign a new activation code to reactivate a deactivated device. **Note:** the previously assigned ICCID must be used to request a new activation code.

```ts
async newactivatecode(
  body: EsimProfileRequest2,
  requestOptions?: RequestOptions
): Promise<ApiResponse<EsimRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`EsimProfileRequest2`](../../doc/models/esim-profile-request-2.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [EsimRequestResponse](../../doc/models/esim-request-response.md).

## Example Usage

```ts
const body: EsimProfileRequest2 = {
  devices: [
    {
      deviceIds: [
        {
          id: '15-digit IMEI',
          kind: 'imei',
        },
        {
          id: '20-digit ICCID',
          kind: 'iccid',
        }
      ],
    }
  ],
  accountName: '0000123456-00001',
  servicePlan: 'the service plan name',
  mdnZipCode: 'five digit zip code',
};

try {
  const { result, ...httpResponse } = await simActionsApi.newactivatecode(body);
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 403 | Forbidden | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 429 | Too many requests | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| Default | Error response | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |


# Setactivate Using POST

Uses the profile to activate the SIM.

```ts
async setactivateUsingPost(
  body: EsimProfileRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<EsimRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`EsimProfileRequest`](../../doc/models/esim-profile-request.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [EsimRequestResponse](../../doc/models/esim-request-response.md).

## Example Usage

```ts
const body: EsimProfileRequest = {
  devices: [
    {
      deviceIds: [
        {
          id: '32-digit EID',
          kind: 'eid',
        },
        {
          id: '15-digit IMEI',
          kind: 'imei',
        },
        {
          id: '20-digit ICCID',
          kind: 'iccid (ICCID is only used for reactivation)',
        }
      ],
    }
  ],
  carrierName: 'Verizon Wireless',
  accountName: '0000123456-00001',
  servicePlan: 'the service plan name',
  mdnZipCode: 'five digit zip code',
};

try {
  const { result, ...httpResponse } = await simActionsApi.setactivateUsingPost(body);
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 403 | Forbidden | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 429 | Too many requests | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| Default | Error response | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |


# Setdeactivate Using POST

Uses the profile to deactivate the SIM.

```ts
async setdeactivateUsingPost(
  body: ProfileRequest2,
  requestOptions?: RequestOptions
): Promise<ApiResponse<EsimRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProfileRequest2`](../../doc/models/profile-request-2.md) | Body, Required | Device Profile Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [EsimRequestResponse](../../doc/models/esim-request-response.md).

## Example Usage

```ts
const body: ProfileRequest2 = {
  accountName: '0000123456-00001',
  carrierName: 'Verizon Wireless',
  reasonCode: 'FF',
  etfWaiver: true,
  checkFallbackProfile: false,
};

try {
  const { result, ...httpResponse } = await simActionsApi.setdeactivateUsingPost(body);
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
  "requestId": "d1f08526-5443-4054-9a29-4456490ea9f8"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 401 | Unauthorized | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 403 | Forbidden | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 404 | Not Found / Does not exist | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 406 | Format / Request Unacceptable | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| 429 | Too many requests | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |
| Default | Error response | [`EsimRestErrorResponseError`](../../doc/models/esim-rest-error-response-error.md) |

