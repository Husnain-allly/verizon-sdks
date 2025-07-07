# Update Price Plan Triggers

```go
updatePricePlanTriggersApi := client.UpdatePricePlanTriggersApi()
```

## Class Name

`UpdatePricePlanTriggersApi`


# Update Trigger Rules

Updates a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```go
UpdateTriggerRules(
    ctx context.Context,
    body models.UpdateTriggerRulesBody) (
    models.ApiResponse[models.TriggerResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.UpdateTriggerRulesBody`](../../doc/models/containers/update-trigger-rules-body.md) | Body, Required | This is a container for any-of cases. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.TriggerResponse](../../doc/models/trigger-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.UpdateTriggerRulesBodyContainer.FromAccountLevelUpdateTriggerRequest(models.AccountLevelUpdateTriggerRequest{
    TriggerId:                     models.ToPointer("b9cc1da6-ffff-eeee-gggg-7eba8859ab5e"),
    TriggerName:                   models.ToPointer("name of the trigger"),
    EcpdId:                        models.ToPointer("Verizon profile ID"),
    TriggerCategory:               models.ToPointer(models.TriggerCategory_Accountusage),
    DataTrigger:                   models.ToPointer(models.DataTrigger1{
        ConditionType:         models.ToPointer(models.ConditionType_Aging),
        AdditionalProperties:  map[string]interface{}{
            "accountLevel": interface{}("[filterCriteria, DotLiquid.Hash][condition, DotLiquid.Hash][action, DotLiquid.Hash]"),
        },
    }),
    Notification:                  models.ToPointer(models.Notificationarray{
        NotificationType:              models.ToPointer("PerEvent"),
        Callback:                      models.ToPointer(true),
        EmailNotification:             models.ToPointer(false),
        NotificationGroupName:         models.ToPointer("NotificationGroupName"),
        NotificationFrequencyFactor:   models.ToPointer(3),
        NotificationFrequencyInterval: models.ToPointer("Daily"),
        ExternalEmailRecipients:       models.ToPointer("ExternalEmailRecipients"),
        SmsNotification:               models.ToPointer(true),
        SmsNumbers:                    []models.NotificationarraySmsNumbers{
            models.NotificationarraySmsNumbersContainer.FromCellphonenumber(models.Cellphonenumber{
                Number:                models.ToPointer("10-digit mobile number"),
                Carrier:               models.ToPointer("mobile service provider"),
            }),
            models.NotificationarraySmsNumbersContainer.FromCellphonenumber(models.Cellphonenumber{
                Number:                models.ToPointer("10-digit mobile number"),
                Carrier:               models.ToPointer("mobile service provider"),
            }),
        },
        Reminder:                      models.ToPointer(true),
        Severity:                      models.ToPointer("Notice"),
    }),
    Active:                        models.ToPointer(models.Active_True),
})

apiResponse, err := updatePricePlanTriggersApi.UpdateTriggerRules(ctx, body)
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

