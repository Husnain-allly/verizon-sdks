# Update Price Plan Triggers

```java
UpdatePricePlanTriggersApi updatePricePlanTriggersApi = client.getUpdatePricePlanTriggersApi();
```

## Class Name

`UpdatePricePlanTriggersApi`


# Update Trigger Rules

Updates a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```java
CompletableFuture<ApiResponse<TriggerResponse>> updateTriggerRulesAsync(
    final UpdateTriggerRulesBody body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UpdateTriggerRulesBody`](../../doc/models/containers/update-trigger-rules-body.md) | Body, Required | This is a container for any-of cases. |

## Server

`Server.THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` getter of this instance returns the response data which is of type [`TriggerResponse`](../../doc/models/trigger-response.md).

## Example Usage

```java
UpdateTriggerRulesBody body = UpdateTriggerRulesBody.fromAccountLevelUpdateTriggerRequest(
    new AccountLevelUpdateTriggerRequest.Builder()
        .triggerId("b9cc1da6-ffff-eeee-gggg-7eba8859ab5e")
        .triggerName("name of the trigger")
        .ecpdId("Verizon profile ID")
        .triggerCategory(TriggerCategory.ACCOUNTUSAGE)
        .dataTrigger(new DataTrigger1.Builder()
            .conditionType(ConditionType.AGING)
        .additionalProperty("accountLevel", ApiHelper.deserialize("{\"filterCriteria\":{\"separateOrCombined\":\"Separate\",\"accountNames\":{\"accountNameList\":[\"0000123456-00001\"]}},\"condition\":{\"comparator\":\"gt\",\"threshold\":100,\"thresholdUnit\":\"KB\",\"cycleType\":\"Daily\"},\"action\":{\"suspend\":true,\"suspendDetails\":{\"suspendFromAccounts\":[\"0000123456-00001\"],\"suspendDuration\":\"90\",\"suspendOption\":\"withBilling\",\"threshold\":50,\"thresholdUnit\":\"KB\"}}}"))
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
                NotificationarraySmsNumbers.fromCellphonenumber(
                    new Cellphonenumber.Builder()
                        .number("10-digit mobile number")
                        .carrier("mobile service provider")
                        .build()
                ),
                NotificationarraySmsNumbers.fromCellphonenumber(
                    new Cellphonenumber.Builder()
                        .number("10-digit mobile number")
                        .carrier("mobile service provider")
                        .build()
                )
            ))
            .reminder(true)
            .severity("Notice")
            .build())
        .active(Active.ENUM_TRUE)
        .build()
);

updatePricePlanTriggersApi.updateTriggerRulesAsync(body).thenAccept(result -> {
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

