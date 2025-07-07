# Device SMS Messaging

```csharp
DeviceSmsMessagingApi deviceSmsMessagingApi = client.DeviceSmsMessagingApi;
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

```csharp
SendAnSmsMessageAsync(
    Models.GiosmsSendRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`GiosmsSendRequest`](../../doc/models/giosms-send-request.md) | Body, Required | SMS message to an indiividual device. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```csharp
GiosmsSendRequest body = new GiosmsSendRequest
{
    SmsMessage = "the body or text of the message itself",
    AccountName = "0000123456-00001",
    CustomFields = new List<KvPair>
    {
        new KvPair
        {
            Key = "CustomField1",
            MValue = "value of the field",
        },
    },
    DataEncoding = "optional 7 or 8-bit encoding",
    TimeToLive = "000000010000000R",
    DeviceIds = new List<GioDeviceId>
    {
        new GioDeviceId
        {
            Kind = "iccid",
            Id = "20-digit ICCID",
        },
    },
};

try
{
    ApiResponse<GioRequestResponse> result = await deviceSmsMessagingApi.SendAnSmsMessageAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Get Sms Messages

Retrieves queued SMS messages sent by all M2M MC devices associated with an account.

```csharp
GetSmsMessagesAsync(
    string accountName,
    string next = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Numeric account name<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9\-]{3,32}$` |
| `next` | `string` | Query, Optional | Continue the previous query from the pageUrl in Location Header<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SmsMessagesResponse](../../doc/models/sms-messages-response.md).

## Example Usage

```csharp
string accountName = "0000123456-00001";
string next = "TheURLForTheNextQuery";
try
{
    ApiResponse<SmsMessagesResponse> result = await deviceSmsMessagingApi.GetSmsMessagesAsync(
        accountName,
        next
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Start Sms Message Delivery

Starts delivery of SMS messages for the specified account.

```csharp
StartSmsMessageDeliveryAsync(
    string accountName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Numeric account name<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9\-]{3,32}$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.SuccessResponse](../../doc/models/success-response.md).

## Example Usage

```csharp
string accountName = "0000123456-00001";
try
{
    ApiResponse<SuccessResponse> result = await deviceSmsMessagingApi.StartSmsMessageDeliveryAsync(accountName);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# List Sms Message History

Returns a list of sms history for a given device during a specified time frame.

```csharp
ListSmsMessageHistoryAsync(
    Models.SmsEventHistoryRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SmsEventHistoryRequest`](../../doc/models/sms-event-history-request.md) | Body, Required | Device Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```csharp
SmsEventHistoryRequest body = new SmsEventHistoryRequest
{
    DeviceId = new GioDeviceId
    {
        Kind = "eid",
        Id = "12345678901234567890123456789012",
    },
};

try
{
    ApiResponse<GioRequestResponse> result = await deviceSmsMessagingApi.ListSmsMessageHistoryAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |

