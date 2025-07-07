# Create Price Plan Triggers

```csharp
CreatePricePlanTriggersApi createPricePlanTriggersApi = client.CreatePricePlanTriggersApi;
```

## Class Name

`CreatePricePlanTriggersApi`


# Create Trigger Rules

Create a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```csharp
CreateTriggerRulesAsync(
    CreateTriggerRulesBody body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreateTriggerRulesBody`](../../doc/models/containers/create-trigger-rules-body.md) | Body, Required | This is a container for any-of cases. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TriggerResponse](../../doc/models/trigger-response.md).

## Example Usage

```csharp
CreateTriggerRulesBody body = CreateTriggerRulesBody.FromAccountLevelObject(
    new AccountLevelObject
    {
        ["triggerName"] = ApiHelper.JsonDeserialize<object>("\"name of the trigger\""),
        ["ecpdId"] = ApiHelper.JsonDeserialize<object>("\"Verizon profile ID\""),
        ["triggerCategory"] = ApiHelper.JsonDeserialize<object>("\"AccountUsage\""),
        ["dataTrigger"] = ApiHelper.JsonDeserialize<object>("{\"accountLevel\":{\"filterCriteria\":{\"separateOrCombined\":\"Separate\",\"accountNames\":{\"accountNameList\":[\"0000123456-00001\"]}},\"condition\":{\"comparator\":\"gt\",\"threshold\":100,\"thresholdUnit\":\"KB\",\"cycleType\":\"Daily\"},\"action\":{\"suspend\":true,\"suspendDetails\":{\"suspendFromAccounts\":[\"0000123456-00001\"],\"suspendDuration\":\"90\",\"suspendOption\":\"withBilling\",\"threshold\":50,\"thresholdUnit\":\"KB\"}}}}"),
        ["notification"] = ApiHelper.JsonDeserialize<object>("{\"notificationType\":\"PerEvent\",\"callback\":true,\"emailNotification\":false,\"notificationGroupName\":\"NotificationGroupName\",\"notificationFrequencyFactor\":3,\"notificationFrequencyInterval\":\"Daily\",\"externalEmailRecipients\":\"ExternalEmailRecipients\",\"smsNotification\":true,\"smsNumbers\":[{\"number\":\"10-digit mobile number\",\"carrier\":\"mobile service provider\"},{\"number\":\"10-digit mobile number\",\"carrier\":\"mobile service provider\"}],\"reminder\":true,\"severity\":\"Notice\"}"),
        ["active"] = ApiHelper.JsonDeserialize<object>("\"true\""),
    }
);

try
{
    ApiResponse<TriggerResponse> result = await createPricePlanTriggersApi.CreateTriggerRulesAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
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

