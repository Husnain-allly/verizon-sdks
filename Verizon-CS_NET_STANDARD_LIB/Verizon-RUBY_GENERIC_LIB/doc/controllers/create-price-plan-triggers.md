# Create Price Plan Triggers

```ruby
create_price_plan_triggers_api = client.create_price_plan_triggers
```

## Class Name

`CreatePricePlanTriggersApi`


# Create Trigger Rules

Create a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```ruby
def create_trigger_rules(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [accountLevelCreateTriggerRequest](../../doc/models/account-level-create-trigger-request.md) \| [accountLevelObject](../../doc/models/account-level-object.md) \| [deviceLevelCreateTriggerRequest](../../doc/models/device-level-create-trigger-request.md) \| [accountGroupShareCreateTriggerRequest](../../doc/models/account-group-share-create-trigger-request.md) \| [accountShareCreateTriggerRequest](../../doc/models/account-share-create-trigger-request.md) \| [payAsYouGoCreateTriggerRequest](../../doc/models/pay-as-you-go-create-trigger-request.md) \| [createtriggerchunk](../../doc/models/createtriggerchunk.md) | Body, Required | This is a container for any-of cases. |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`TriggerResponse`](../../doc/models/trigger-response.md).

## Example Usage

```ruby
body = AccountLevelObject.new(
  additional_properties: {
    'triggerName' => JSON.parse('"name of the trigger"'),
    'ecpdId' => JSON.parse('"Verizon profile ID"'),
    'triggerCategory' => JSON.parse('"AccountUsage"'),
    'dataTrigger' => JSON.parse('{"accountLevel":{"filterCriteria":{"separateOrCombined":"Separate","accountNames":{"accountNameList":["0000123456-00001"]}},"condition":{"comparator":"gt","threshold":100,"thresholdUnit":"KB","cycleType":"Daily"},"action":{"suspend":true,"suspendDetails":{"suspendFromAccounts":["0000123456-00001"],"suspendDuration":"90","suspendOption":"withBilling","threshold":50,"thresholdUnit":"KB"}}}}'),
    'notification' => JSON.parse('{"notificationType":"PerEvent","callback":true,"emailNotification":false,"notificationGroupName":"NotificationGroupName","notificationFrequencyFactor":3,"notificationFrequencyInterval":"Daily","externalEmailRecipients":"ExternalEmailRecipients","smsNotification":true,"smsNumbers":[{"number":"10-digit mobile number","carrier":"mobile service provider"},{"number":"10-digit mobile number","carrier":"mobile service provider"}],"reminder":true,"severity":"Notice"}'),
    'active' => JSON.parse('"true"')
  }
)

result = create_price_plan_triggers_api.create_trigger_rules(body)

if result.success?
  puts result.data
elsif result.error?
  warn result.errors
end
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

