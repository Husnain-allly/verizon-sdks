# SMS

Exchange Short Message Service (SMS) messages with devices.

```go
smsApi := client.SmsApi()
```

## Class Name

`SmsApi`

## Methods

* [Send SMS to Device](../../doc/controllers/sms.md#send-sms-to-device)
* [List Devices SMS Messages](../../doc/controllers/sms.md#list-devices-sms-messages)
* [Start Queued SMS Delivery](../../doc/controllers/sms.md#start-queued-sms-delivery)


# Send SMS to Device

The messages are queued on the ThingSpace Platform and sent as soon as possible, but they may be delayed due to traffic and routing considerations.

```go
SendSmsToDevice(
    ctx context.Context,
    body models.SmsSendRequest) (
    models.ApiResponse[models.DeviceManagementResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.SmsSendRequest`](../../doc/models/sms-send-request.md) | Body, Required | Request to send SMS. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.DeviceManagementResult](../../doc/models/device-management-result.md).

## Example Usage

```go
ctx := context.Background()

body := models.SmsSendRequest{
    AccountName:           "0000123456-00001",
    SmsMessage:            "the body or text of the message itself",
    CustomFields:          []models.CustomFields{
        models.CustomFields{
            Key:                   "CustomField1",
            Value:                 "value of the field",
        },
    },
    DataEncoding:          models.ToPointer("optional 7 or 8-bit encoding"),
    DeviceIds:             []models.DeviceId{
        models.DeviceId{
            Id:                    "20-digit ICCID",
            Kind:                  "iccid",
        },
    },
    TimeToLive:            models.ToPointer("a000000010000000R"),
}

apiResponse, err := smsApi.SendSmsToDevice(ctx, body)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "requestId": "595f5c44-c31c-4552-8670-020a1545a84d"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# List Devices SMS Messages

When HTTP status is 202, a URL will be returned in the Location header of the form /sms/{aname}/history?next={token}. This URL can be used to request the next set of messages.

```go
ListDevicesSmsMessages(
    ctx context.Context,
    aname string,
    next *int64) (
    models.ApiResponse[models.SmsMessagesQueryResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |
| `next` | `*int64` | Query, Optional | Continue the previous query from the URL in Location Header. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.SmsMessagesQueryResult](../../doc/models/sms-messages-query-result.md).

## Example Usage

```go
ctx := context.Background()

aname := "0252012345-00001"



apiResponse, err := smsApi.ListDevicesSmsMessages(ctx, aname, nil)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "messages": [
    {
      "deviceIds": [
        {
          "id": "09623489171",
          "kind": "esn"
        }
      ],
      "message": "testmessage1",
      "timestamp": "2016-01-01T12:29:49-08:00"
    },
    {
      "deviceIds": [
        {
          "id": "09623489171",
          "kind": "esn"
        }
      ],
      "message": "testmessage2",
      "timestamp": "2016-01-01T12:31:02-08:00"
    }
  ],
  "hasMoreData": false
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |


# Start Queued SMS Delivery

Tells the ThingSpace Platform to start sending mobile-originated SMS messages through the EnhancedConnectivityService callback service. SMS messages from devices are queued until they are retrieved by your application, either by callback or synchronously with GET /sms/{accountName}/history.

```go
StartQueuedSmsDelivery(
    ctx context.Context,
    aname string) (
    models.ApiResponse[models.ConnectivityManagementSuccessResult],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `aname` | `string` | Template, Required | Account name. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.ConnectivityManagementSuccessResult](../../doc/models/connectivity-management-success-result.md).

## Example Usage

```go
ctx := context.Background()

aname := "0252012345-00001"

apiResponse, err := smsApi.StartQueuedSmsDelivery(ctx, aname)
if err != nil {
    log.Fatalln(err)
} else {
    // Printing the result and response
    fmt.Println(apiResponse.Data)
    fmt.Println(apiResponse.Response.StatusCode)
}
```

## Example Response *(as JSON)*

```json
{
  "success": true
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Error response. | [`ConnectivityManagementResultException`](../../doc/models/connectivity-management-result-exception.md) |

