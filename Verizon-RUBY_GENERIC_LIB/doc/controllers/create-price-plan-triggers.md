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
| `body` | [`V2TriggersRequest`](../../doc/models/v2-triggers-request.md) | Body, Required | Create a trigger |

## Server

`Server::THINGSPACE`

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `data` property of this instance returns the response data which is of type [`TriggerResponse`](../../doc/models/trigger-response.md).

## Example Usage

```ruby
body = V2TriggersRequest.new(
  trigger_name: 'name of the trigger',
  ecpd_id: 'Verizon profile ID',
  trigger_category: TriggerCategory::DEVICEGROUPUSAGE,
  data_trigger: DataTrigger4.new(
    device_group: DeviceGroupFilterCriteria.new(
      filter_criteria: DeviceGroupFilter.new(
        device_group_name: 'User defined group name',
        individual_or_combined: 'Combined',
        account_name: '0000123456-00001'
      )
    ),
    action: Actionobject.new(
      suspend: true,
      suspend_details: Suspenddetailsobject.new(
        suspend_duration: 90,
        suspend_option: 'withBilling',
        threshold: 50,
        threshold_unit: ThresholdUnit::KB
      )
    ),
    additional_properties: {
      'condition' => JSON.parse('{"comparator":"gt","threshold":100,"thresholdUnit":"KB","cycleType":"Daily"}')
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

