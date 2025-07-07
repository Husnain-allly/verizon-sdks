# Create Price Plan Triggers

```go
createPricePlanTriggersApi := client.CreatePricePlanTriggersApi()
```

## Class Name

`CreatePricePlanTriggersApi`


# Create Trigger Rules

Create a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```go
CreateTriggerRules(
    ctx context.Context,
    body models.CreateTriggerRulesBody) (
    models.ApiResponse[models.TriggerResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.CreateTriggerRulesBody`](../../doc/models/containers/create-trigger-rules-body.md) | Body, Required | This is a container for any-of cases. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.TriggerResponse](../../doc/models/trigger-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.CreateTriggerRulesBodyContainer.FromAccountLevelObject(models.AccountLevelObject{
    AdditionalProperties:  map[string]interface{}{
        "triggerName": interface{}("name of the trigger"),
        "ecpdId": interface{}("Verizon profile ID"),
        "triggerCategory": interface{}("AccountUsage"),
        "dataTrigger": interface{}("[accountLevel, DotLiquid.Hash]"),
        "notification": interface{}("[notificationType, PerEvent][callback, True][emailNotification, False][notificationGroupName, NotificationGroupName][notificationFrequencyFactor, 3][notificationFrequencyInterval, Daily][externalEmailRecipients, ExternalEmailRecipients][smsNotification, True][smsNumbers, System.Object[]][reminder, True][severity, Notice]"),
        "active": interface{}("true"),
    },
})

apiResponse, err := createPricePlanTriggersApi.CreateTriggerRules(ctx, body)
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
  "triggerId": "be1b5958-ffff-eeee-gggg-b1b7618c0035"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`RuleRestErrorResponseException`](../../doc/models/rule-rest-error-response-exception.md) |

