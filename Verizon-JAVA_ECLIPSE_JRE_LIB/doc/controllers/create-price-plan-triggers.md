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
    final V2TriggersRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V2TriggersRequest`](../../doc/models/v2-triggers-request.md) | Body, Required | Create a trigger |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`TriggerResponse`](../../doc/models/trigger-response.md).

## Example Usage

```java
V2TriggersRequest body = new V2TriggersRequest.Builder()
    .triggerName("name of the trigger")
    .ecpdId("Verizon profile ID")
    .triggerCategory(TriggerCategory.DEVICEGROUPUSAGE)
    .dataTrigger(new DataTrigger4.Builder()
        .deviceGroup(new DeviceGroupFilterCriteria.Builder()
            .filterCriteria(new DeviceGroupFilter.Builder()
                .deviceGroupName("User defined group name")
                .individualOrCombined("Combined")
                .accountName("0000123456-00001")
                .build())
            .build())
        .action(new Actionobject.Builder()
            .suspend(true)
            .suspendDetails(new Suspenddetailsobject.Builder()
                .suspendDuration(90)
                .suspendOption("withBilling")
                .threshold(50)
                .thresholdUnit(ThresholdUnit.KB)
                .build())
            .build())
    .additionalProperty("condition", ApiHelper.deserialize("{\"comparator\":\"gt\",\"threshold\":100,\"thresholdUnit\":\"KB\",\"cycleType\":\"Daily\"}"))
        .build())
    .notification(new Notificationarray.Builder()
        .notificationType("PerEvent")
        .callback(true)
        .emailNotification(false)
        .notificationGroupName("NotificationGroupName")
        .notificationFrequencyFactor(3)
        .notificationFrequencyInterval("Daily")
        .externalEmailRecipients("ExternalEmailRecipients")
        .smsNotification(true)
        .smsNumbers(Arrays.asList(
            new Cellphonenumber.Builder()
                .number("10-digit mobile number")
                .carrier("mobile service provider")
                .build(),
            new Cellphonenumber.Builder()
                .number("10-digit mobile number")
                .carrier("mobile service provider")
                .build()
        ))
        .reminder(true)
        .severity("Notice")
        .build())
    .active(Active.ENUM_TRUE)
    .build();

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

