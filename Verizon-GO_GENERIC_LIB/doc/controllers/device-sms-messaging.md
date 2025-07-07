# Device SMS Messaging

```go
deviceSmsMessagingApi := client.DeviceSmsMessagingApi()
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

```go
SendAnSmsMessage(
    ctx context.Context,
    body models.GiosmsSendRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.GiosmsSendRequest`](../../doc/models/giosms-send-request.md) | Body, Required | SMS message to an indiividual device. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.GiosmsSendRequest{
    AccountName:  models.ToPointer("0000123456-00001"),
    CustomFields: []models.KvPair{
        models.KvPair{
            Key:   models.ToPointer("CustomField1"),
            Value: models.ToPointer("value of the field"),
        },
    },
    DataEncoding: models.ToPointer("optional 7 or 8-bit encoding"),
    TimeToLive:   models.ToPointer("000000010000000R"),
    DeviceIds:    []models.GioDeviceId{
        models.GioDeviceId{
            Kind: "iccid",
            Id:   "20-digit ICCID",
        },
    },
    SmsMessage:   "the body or text of the message itself",
}

apiResponse, err := deviceSmsMessagingApi.SendAnSmsMessage(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Get Sms Messages

Retrieves queued SMS messages sent by all M2M MC devices associated with an account.

```go
GetSmsMessages(
    ctx context.Context,
    accountName string,
    next *string) (
    models.ApiResponse[models.SmsMessagesResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Numeric account name<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9\-]{3,32}$` |
| `next` | `*string` | Query, Optional | Continue the previous query from the pageUrl in Location Header<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `64`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.SmsMessagesResponse](../../doc/models/sms-messages-response.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

next := "TheURLForTheNextQuery"

apiResponse, err := deviceSmsMessagingApi.GetSmsMessages(ctx, accountName, &next)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# Start Sms Message Delivery

Starts delivery of SMS messages for the specified account.

```go
StartSmsMessageDelivery(
    ctx context.Context,
    accountName string) (
    models.ApiResponse[models.SuccessResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Template, Required | Numeric account name<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9\-]{3,32}$` |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.SuccessResponse](../../doc/models/success-response.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

apiResponse, err := deviceSmsMessagingApi.StartSmsMessageDelivery(ctx, accountName)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |


# List Sms Message History

Returns a list of sms history for a given device during a specified time frame.

```go
ListSmsMessageHistory(
    ctx context.Context,
    body models.SmsEventHistoryRequest) (
    models.ApiResponse[models.GioRequestResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.SmsEventHistoryRequest`](../../doc/models/sms-event-history-request.md) | Body, Required | Device Query |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.GioRequestResponse](../../doc/models/gio-request-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.SmsEventHistoryRequest{
    DeviceId: models.GioDeviceId{
        Kind: "eid",
        Id:   "12345678901234567890123456789012",
    },
}

apiResponse, err := deviceSmsMessagingApi.ListSmsMessageHistory(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`GioRestErrorResponseException`](../../doc/models/gio-rest-error-response-exception.md) |

