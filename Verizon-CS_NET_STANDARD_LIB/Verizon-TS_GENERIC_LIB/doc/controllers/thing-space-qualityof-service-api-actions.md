# Thing Space Qualityof Service API Actions

```ts
const thingSpaceQualityofServiceApiActionsApi = new ThingSpaceQualityofServiceApiActionsApi(client);
```

## Class Name

`ThingSpaceQualityofServiceApiActionsApi`

## Methods

* [Create a Thing Space Quality of Service API Subscription](../../doc/controllers/thing-space-qualityof-service-api-actions.md#create-a-thing-space-quality-of-service-api-subscription)
* [Stop a Thing Space Quality of Service API Subscription](../../doc/controllers/thing-space-qualityof-service-api-actions.md#stop-a-thing-space-quality-of-service-api-subscription)


# Create a Thing Space Quality of Service API Subscription

Creates a QoS elevation subscription ID and activates the subscription.

```ts
async createAThingSpaceQualityOfServiceApiSubscription(
  body: SubscribeRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<M201Success>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SubscribeRequest`](../../doc/models/subscribe-request.md) | Body, Required | The request details to create a ThingSpace Quality of Service API subscription. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [M201Success](../../doc/models/m201-success.md).

## Example Usage

```ts
const body: SubscribeRequest = {
  accountName: '0000123456-00001',
  deviceInfo: [
    {
      deviceId: {
        id: '10-digit phone number',
        kind: 'mdn',
      },
      flowInfo: [
        {
          flowServer: '[IPv6 address]:port',
          flowDevice: '[IPv6 address]:port',
          flowDirection: 'UPLINK',
          flowProtocol: 'UDP',
          qciOption: 'Premium',
        }
      ],
      deviceIPv6Addr: 'IPv6 address',
    }
  ],
};

try {
  const { result, ...httpResponse } = await thingSpaceQualityOfServiceApiActionsApi.createAThingSpaceQualityOfServiceApiSubscription(body);
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
| Default | Error Response | [`DefaultResponseError`](../../doc/models/default-response-error.md) |


# Stop a Thing Space Quality of Service API Subscription

Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.

```ts
async stopAThingSpaceQualityOfServiceApiSubscription(
  accountName: string,
  qosSubscriptionId: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<M201Success>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | - |
| `qosSubscriptionId` | `string` | Query, Required | - |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [M201Success](../../doc/models/m201-success.md).

## Example Usage

```ts
const accountName = '0000123456-00001';

const qosSubscriptionId = 'QoS subscription ID';

try {
  const { result, ...httpResponse } = await thingSpaceQualityOfServiceApiActionsApi.stopAThingSpaceQualityOfServiceApiSubscription(
  accountName,
  qosSubscriptionId
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
| Default | Error Response | [`DefaultResponseError`](../../doc/models/default-response-error.md) |

