# Device SMS Messaging

```ts
const deviceSmsMessagingApi = new DeviceSmsMessagingApi(client);
```

## Class Name

`DeviceSmsMessagingApi`

## Methods

* [Send an Sms Message](../../doc/controllers/device-sms-messaging.md#send-an-sms-message)
* [Get Sms Messages](../../doc/controllers/device-sms-messaging.md#get-sms-messages)
* [Start Sms Message Delivery](../../doc/controllers/device-sms-messaging.md#start-sms-message-delivery)
* [List Sms Message History](../../doc/controllers/device-sms-messaging.md#list-sms-message-history)


# Send an Sms Message

Sends an SMS message to one device. Messages are queued on the M2M MC Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.

```ts
async sendAnSmsMessage(
  body: GiosmsSendRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GiosmsSendRequest`](../../doc/models/giosms-send-request.md) | Body, Required | SMS message to an indiividual device. |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: GiosmsSendRequest = {
  smsMessage: 'the body or text of the message itself',
  accountName: '0000123456-00001',
  customFields: [
    {
      key: 'CustomField1',
      value: 'value of the field',
    }
  ],
  dataEncoding: 'optional 7 or 8-bit encoding',
  timeToLive: '000000010000000R',
  deviceIds: [
    {
      kind: 'iccid',
      id: '20-digit ICCID',
    }
  ],
};

try {
  const { result, ...httpResponse } = await deviceSmsMessagingApi.sendAnSmsMessage(body);
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
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |


# Get Sms Messages

Retrieves queued SMS messages sent by all M2M MC devices associated with an account.

```ts
async getSmsMessages(
  accountName: string,
  next?: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<SmsMessagesResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Numeric account name<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9\-]{3,32}$` |
| `next` | `string \| undefined` | Query, Optional | Continue the previous query from the pageUrl in Location Header<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [SmsMessagesResponse](../../doc/models/sms-messages-response.md).

## Example Usage

```ts
const accountName = '0000123456-00001';

const next = 'TheURLForTheNextQuery';

try {
  const { result, ...httpResponse } = await deviceSmsMessagingApi.getSmsMessages(
  accountName,
  next
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
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |


# Start Sms Message Delivery

Starts delivery of SMS messages for the specified account.

```ts
async startSmsMessageDelivery(
  accountName: string,
  requestOptions?: RequestOptions
): Promise<ApiResponse<SuccessResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Numeric account name<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9\-]{3,32}$` |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [SuccessResponse](../../doc/models/success-response.md).

## Example Usage

```ts
const accountName = '0000123456-00001';

try {
  const { result, ...httpResponse } = await deviceSmsMessagingApi.startSmsMessageDelivery(accountName);
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
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |


# List Sms Message History

Returns a list of sms history for a given device during a specified time frame.

```ts
async listSmsMessageHistory(
  body: SmsEventHistoryRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<GioRequestResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SmsEventHistoryRequest`](../../doc/models/sms-event-history-request.md) | Body, Required | Device Query |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```ts
const body: SmsEventHistoryRequest = {
  deviceId: {
    kind: 'eid',
    id: '12345678901234567890123456789012',
  },
};

try {
  const { result, ...httpResponse } = await deviceSmsMessagingApi.listSmsMessageHistory(body);
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
| Default | Error response | [`GioRestErrorResponseError`](../../doc/models/gio-rest-error-response-error.md) |

