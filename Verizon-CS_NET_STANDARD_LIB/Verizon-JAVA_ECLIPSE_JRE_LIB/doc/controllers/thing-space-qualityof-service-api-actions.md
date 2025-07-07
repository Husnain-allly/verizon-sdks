# Thing Space Qualityof Service API Actions

```java
ThingSpaceQualityofServiceApiActionsApi thingSpaceQualityofServiceApiActionsApi = client.getThingSpaceQualityofServiceApiActionsApi();
```

## Class Name

`ThingSpaceQualityofServiceApiActionsApi`

## Methods

* [Create a Thing Space Quality of Service API Subscription](../../doc/controllers/thing-space-qualityof-service-api-actions.md#create-a-thing-space-quality-of-service-api-subscription)
* [Stop a Thing Space Quality of Service API Subscription](../../doc/controllers/thing-space-qualityof-service-api-actions.md#stop-a-thing-space-quality-of-service-api-subscription)


# Create a Thing Space Quality of Service API Subscription

Creates a QoS elevation subscription ID and activates the subscription.

```java
CompletableFuture<ApiResponse<M201Success>> createAThingSpaceQualityOfServiceApiSubscriptionAsync(
    final SubscribeRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SubscribeRequest`](../../doc/models/subscribe-request.md) | Body, Required | The request details to create a ThingSpace Quality of Service API subscription. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`M201Success`](../../doc/models/m201-success.md).

## Example Usage

```java
SubscribeRequest body = new SubscribeRequest.Builder(
    "0000123456-00001",
    Arrays.asList(
        new QosDeviceInfo.Builder(
            new QosDeviceId.Builder()
                .id("10-digit phone number")
                .kind("mdn")
                .build(),
            Arrays.asList(
                new FlowInfo.Builder()
                    .flowServer("[IPv6 address]:port")
                    .flowDevice("[IPv6 address]:port")
                    .flowDirection("UPLINK")
                    .flowProtocol("UDP")
                    .qciOption("Premium")
                    .build()
            )
        )
        .deviceIPv6Addr("IPv6 address")
        .build()
    )
)
.build();

thingSpaceQualityofServiceApiActionsApi.createAThingSpaceQualityOfServiceApiSubscriptionAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error Response | [`DefaultResponseException`](../../doc/models/default-response-exception.md) |


# Stop a Thing Space Quality of Service API Subscription

Stops an active ThingSpace Quality of Service API subscription using the account name and the subscription ID.

```java
CompletableFuture<ApiResponse<M201Success>> stopAThingSpaceQualityOfServiceApiSubscriptionAsync(
    final String accountName,
    final String qosSubscriptionId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `String` | Query, Required | - |
| `qosSubscriptionId` | `String` | Query, Required | - |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`M201Success`](../../doc/models/m201-success.md).

## Example Usage

```java
String accountName = "0000123456-00001";
String qosSubscriptionId = "QoS subscription ID";

thingSpaceQualityofServiceApiActionsApi.stopAThingSpaceQualityOfServiceApiSubscriptionAsync(accountName, qosSubscriptionId).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error Response | [`DefaultResponseException`](../../doc/models/default-response-exception.md) |

