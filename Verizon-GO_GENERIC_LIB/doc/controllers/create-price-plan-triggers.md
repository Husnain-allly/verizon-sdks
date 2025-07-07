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
    body models.V2TriggersRequest) (
    models.ApiResponse[models.TriggerResponse],
    error)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`models.V2TriggersRequest`](../../doc/models/v2-triggers-request.md) | Body, Required | Create a trigger |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [models.TriggerResponse](../../doc/models/trigger-response.md).

## Example Usage

```go
ctx := context.Background()

body := models.V2TriggersRequest{
    TriggerName:                   models.ToPointer("name of the trigger"),
    EcpdId:                        models.ToPointer("Verizon profile ID"),
    TriggerCategory:               models.ToPointer(models.TriggerCategory_Devicegroupusage),
    DataTrigger:                   models.ToPointer(models.DataTrigger4{
        DeviceGroup:           models.ToPointer(models.DeviceGroupFilterCriteria{
            FilterCriteria:        models.ToPointer(models.DeviceGroupFilter{
                DeviceGroupName:       models.ToPointer("User defined group name"),
                IndividualOrCombined:  models.ToPointer("Combined"),
                AccountName:           models.ToPointer("0000123456-00001"),
            }),
        }),
        Action:                models.ToPointer(models.Actionobject{
            Suspend:               models.ToPointer(true),
            SuspendDetails:        models.ToPointer(models.Suspenddetailsobject{
                SuspendDuration:       models.ToPointer(90),
                SuspendOption:         models.ToPointer("withBilling"),
                Threshold:             models.ToPointer(50),
                ThresholdUnit:         models.ToPointer(models.ThresholdUnit_Kb),
            }),
        }),
        AdditionalProperties:  map[string]interface{}{
            "condition": interface{}("[comparator, gt][threshold, 100][thresholdUnit, KB][cycleType, Daily]"),
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
        SmsNumbers:                    []models.Cellphonenumber{
            models.Cellphonenumber{
                Number:                models.ToPointer("10-digit mobile number"),
                Carrier:               models.ToPointer("mobile service provider"),
            },
            models.Cellphonenumber{
                Number:                models.ToPointer("10-digit mobile number"),
                Carrier:               models.ToPointer("mobile service provider"),
            },
        },
        Reminder:                      models.ToPointer(true),
        Severity:                      models.ToPointer("Notice"),
    }),
    Active:                        models.ToPointer(models.Active_True),
}

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

