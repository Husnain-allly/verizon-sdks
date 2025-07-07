# Update Price Plan Triggers

```ruby
update_price_plan_triggers_api = client.update_price_plan_triggers
```

## Class Name

`UpdatePricePlanTriggersApi`


# Update Trigger Rules

Updates a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```ruby
def update_trigger_rules(body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V2TriggersRequest1`](../../doc/models/v2-triggers-request-1.md) | Body, Required | Update a trigger |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`TriggerResponse`](../../doc/models/trigger-response.md).

## Example Usage

```ruby
body = V2TriggersRequest1.new(
  trigger_id: 'b9cc1da6-ffff-eeee-gggg-7eba8859ab5e',
  trigger_name: 'name of the trigger',
  ecpd_id: 'Verizon profile ID',
  trigger_category: TriggerCategory::ACCOUNTUSAGE,
  data_trigger: DataTrigger5.new(
    additional_properties: {
      'accountLevel' => JSON.parse('{"filterCriteria":{"separateOrCombined":"Separate","accountNames":{"accountNameList":["0000123456-00001"]}},"condition":{"comparator":"gt","threshold":100,"thresholdUnit":"KB","cycleType":"Daily"},"action":{"suspend":true,"suspendDetails":{"suspendFromAccounts":["0000123456-00001"],"suspendDuration":"90","suspendOption":"withBilling","threshold":50,"thresholdUnit":"KB"}}}')
    }
  ),
  notification: Notificationarray.new(
    notification_type: 'PerEvent',
    callback: true,
    email_notification: false,
    notification_group_name: 'NotificationGroupName',
    notification_frequency_factor: 3,
    notification_frequency_interval: 'Daily',
    external_email_recipients: 'ExternalEmailRecipients',
    sms_notification: true,
    sms_numbers: [
      Cellphonenumber.new(
        number: '10-digit mobile number',
        carrier: 'mobile service provider'
      ),
      Cellphonenumber.new(
        number: '10-digit mobile number',
        carrier: 'mobile service provider'
      )
    ],
    reminder: true,
    severity: 'Notice'
  ),
  active: Active::ENUM_TRUE
)

result = update_price_plan_triggers_api.update_trigger_rules(body)

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

