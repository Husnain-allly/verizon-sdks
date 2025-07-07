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
    Models.V2TriggersRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V2TriggersRequest`](../../doc/models/v2-triggers-request.md) | Body, Required | Create a trigger |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `Data` property of this instance returns the response data which is of type [Models.TriggerResponse](../../doc/models/trigger-response.md).

## Example Usage

```csharp
V2TriggersRequest body = new V2TriggersRequest
{
    TriggerName = "name of the trigger",
    EcpdId = "Verizon profile ID",
    TriggerCategory = TriggerCategory.DeviceGroupUsage,
    DataTrigger = new DataTrigger4
    {
        DeviceGroup = new DeviceGroupFilterCriteria
        {
            FilterCriteria = new DeviceGroupFilter
            {
                DeviceGroupName = "User defined group name",
                IndividualOrCombined = "Combined",
                AccountName = "0000123456-00001",
            },
        },
        Action = new Actionobject
        {
            Suspend = true,
            SuspendDetails = new Suspenddetailsobject
            {
                SuspendDuration = 90,
                SuspendOption = "withBilling",
                Threshold = 50,
                ThresholdUnit = ThresholdUnit.Kb,
            },
        },
        ["condition"] = ApiHelper.JsonDeserialize<object>("{\"comparator\":\"gt\",\"threshold\":100,\"thresholdUnit\":\"KB\",\"cycleType\":\"Daily\"}"),
    },
    Notification = new Notificationarray
    {
        NotificationType = "PerEvent",
        Callback = true,
        EmailNotification = false,
        NotificationGroupName = "NotificationGroupName",
        NotificationFrequencyFactor = 3,
        NotificationFrequencyInterval = "Daily",
        ExternalEmailRecipients = "ExternalEmailRecipients",
        SmsNotification = true,
        SmsNumbers = new List<Cellphonenumber>
        {
            new Cellphonenumber
            {
                Number = "10-digit mobile number",
                Carrier = "mobile service provider",
            },
            new Cellphonenumber
            {
                Number = "10-digit mobile number",
                Carrier = "mobile service provider",
            },
        },
        Reminder = true,
        Severity = "Notice",
    },
    Active = Active.True,
};

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

