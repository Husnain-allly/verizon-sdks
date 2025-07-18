# Thing Space Qualityof Service API Actions

```go
thingSpaceQualityofServiceApiActionsApi := client.ThingSpaceQualityofServiceApiActionsApi()
```

## Class Name

`ThingSpaceQualityofServiceApiActionsApi`

## Methods

* [Create a Thing Space Quality of Service API Subscription](../../doc/controllers/thing-space-qualityof-service-api-actions.md#create-a-thing-space-quality-of-service-api-subscription)
* [Stop a Thing Space Quality of Service API Subscription](../../doc/controllers/thing-space-qualityof-service-api-actions.md#stop-a-thing-space-quality-of-service-api-subscription)


# Create a Thing Space Quality of Service API Subscription

Creates a QoS elevation subscription ID and activates the subscription.

```go
CreateAThingSpaceQualityOfServiceApiSubscription(
    ctx context.Context,
    body models.SubscribeRequest) (
    models.ApiResponse[models.M201Success],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.SubscribeRequest`](../../doc/models/subscribe-request.md) | Body, Required | The request details to create a ThingSpace Quality of Service API subscription. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.M201Success](../../doc/models/m201-success.md).

## Example Usage

```go
ctx := context.Background()

body := models.SubscribeRequest{
    AccountName:           "0000123456-00001",
    DeviceInfo:            []models.QosDeviceInfo{
        models.QosDeviceInfo{
            DeviceId:              models.QosDeviceId{
                Id:                    models.ToPointer("10-digit phone number"),
                Kind:                  models.ToPointer("mdn"),
            },
            DeviceIPv6Addr:        models.ToPointer("IPv6 address"),
            FlowInfo:              []models.FlowInfo{
                models.FlowInfo{
                    FlowServer:            models.ToPointer("[IPv6 address]:port"),
                    FlowDevice:            models.ToPointer("[IPv6 address]:port"),
                    FlowDirection:         models.ToPointer("UPLINK"),
                    FlowProtocol:          models.ToPointer("UDP"),
                    QciOption:             models.ToPointer("Premium"),
                },
            },
        },
    },
}

apiResponse, err := thingSpaceQualityOfServiceApiActionsApi.CreateAThingSpaceQualityOfServiceApiSubscription(ctx, body)
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
| Default | Error Response | [`DefaultResponseException`](../../doc/models/default-response-exception.md) |


# Stop a Thing Space Quality of Service API Subscription

Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.

```go
StopAThingSpaceQualityOfServiceApiSubscription(
    ctx context.Context,
    accountName string,
    qosSubscriptionId string) (
    models.ApiResponse[models.M201Success],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string` | Query, Required | - |
| `qosSubscriptionId` | `string` | Query, Required | - |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.M201Success](../../doc/models/m201-success.md).

## Example Usage

```go
ctx := context.Background()

accountName := "0000123456-00001"

qosSubscriptionId := "QoS subscription ID"

apiResponse, err := thingSpaceQualityOfServiceApiActionsApi.StopAThingSpaceQualityOfServiceApiSubscription(ctx, accountName, qosSubscriptionId)
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
| Default | Error Response | [`DefaultResponseException`](../../doc/models/default-response-exception.md) |

