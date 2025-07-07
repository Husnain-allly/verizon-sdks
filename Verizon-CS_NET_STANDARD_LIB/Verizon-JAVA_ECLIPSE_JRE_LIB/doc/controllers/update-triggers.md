# Update Triggers

```java
UpdateTriggersApi updateTriggersApi = client.getUpdateTriggersApi();
```

## Class Name

`UpdateTriggersApi`


# Update All Available Triggers

Updates the promotional triggers for pseudo-MDN.

```java
CompletableFuture<ApiResponse<Success>> updateAllAvailableTriggersAsync(
    final RequestTrigger body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`RequestTrigger`](../../doc/models/request-trigger.md) | Body, Optional | Update the triggers |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`Success`](../../doc/models/success.md).

## Example Usage

```java
RequestTrigger body = new RequestTrigger.Builder()
    .triggerId("2874DEC7-26CF-4797-9C6A-B5A2AC72D526")
    .triggerName("PromoAlerts_0000000000-00001_23456789")
    .accountName("0000123456-000001")
    .organizationName("Optional group name")
    .triggerCategory("PromoAlerts")
    .build();

updateTriggersApi.updateAllAvailableTriggersAsync(body).thenAccept(result -> {
    // TODO success callback handler
    System.out.println(result);
}).exceptionally(exception -> {
    // TODO failure callback handler
    exception.printStackTrace();
    return null;
});
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
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |

