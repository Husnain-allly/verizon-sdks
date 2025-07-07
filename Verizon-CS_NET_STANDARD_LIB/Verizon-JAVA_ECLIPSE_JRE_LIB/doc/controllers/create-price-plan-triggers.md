# Create Price Plan Triggers

```java
CreatePricePlanTriggersApi createPricePlanTriggersApi = client.getCreatePricePlanTriggersApi();
```

## Class Name

`CreatePricePlanTriggersApi`


# Create Trigger Rules

Create a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```java
CompletableFuture<ApiResponse<TriggerResponse>> createTriggerRulesAsync(
    final CreateTriggerRulesBody body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateTriggerRulesBody`](../../doc/models/containers/create-trigger-rules-body.md) | Body, Required | This is a container for any-of cases. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`TriggerResponse`](../../doc/models/trigger-response.md).

## Example Usage

```java
CreateTriggerRulesBody body = CreateTriggerRulesBody.fromAccountLevelObject(
    new AccountLevelObject.Builder()
    .additionalProperty("triggerName", ApiHelper.deserialize("\"name of the trigger\""))
    .additionalProperty("ecpdId", ApiHelper.deserialize("\"Verizon profile ID\""))
    .additionalProperty("triggerCategory", ApiHelper.deserialize("\"AccountUsage\""))
    .additionalProperty("dataTrigger", ApiHelper.deserialize("{\"accountLevel\":{\"filterCriteria\":{\"separateOrCombined\":\"Separate\",\"accountNames\":{\"accountNameList\":[\"0000123456-00001\"]}},\"condition\":{\"comparator\":\"gt\",\"threshold\":100,\"thresholdUnit\":\"KB\",\"cycleType\":\"Daily\"},\"action\":{\"suspend\":true,\"suspendDetails\":{\"suspendFromAccounts\":[\"0000123456-00001\"],\"suspendDuration\":\"90\",\"suspendOption\":\"withBilling\",\"threshold\":50,\"thresholdUnit\":\"KB\"}}}}"))
    .additionalProperty("notification", ApiHelper.deserialize("{\"notificationType\":\"PerEvent\",\"callback\":true,\"emailNotification\":false,\"notificationGroupName\":\"NotificationGroupName\",\"notificationFrequencyFactor\":3,\"notificationFrequencyInterval\":\"Daily\",\"externalEmailRecipients\":\"ExternalEmailRecipients\",\"smsNotification\":true,\"smsNumbers\":[{\"number\":\"10-digit mobile number\",\"carrier\":\"mobile service provider\"},{\"number\":\"10-digit mobile number\",\"carrier\":\"mobile service provider\"}],\"reminder\":true,\"severity\":\"Notice\"}"))
    .additionalProperty("active", ApiHelper.deserialize("\"true\""))
        .build()
);

createPricePlanTriggersApi.createTriggerRulesAsync(body).thenAccept(result -> {
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
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`RuleRestErrorResponseException`](../../doc/models/rule-rest-error-response-exception.md) |

