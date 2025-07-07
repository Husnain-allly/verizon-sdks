# Create Price Plan Triggers

```python
create_price_plan_triggers_api = client.create_price_plan_triggers
```

## Class Name

`CreatePricePlanTriggersApi`


# Create Trigger Rules

Create a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```python
def create_trigger_rules(self,
                        body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V2TriggersRequest`](../../doc/models/v2-triggers-request.md) | Body, Required | Create a trigger |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `body` property of this instance returns the response data which is of type [`TriggerResponse`](../../doc/models/trigger-response.md).

## Example Usage

```python
body = V2TriggersRequest(
    additional_properties=None,
    trigger_name='name of the trigger',
    ecpd_id='Verizon profile ID',
    trigger_category=TriggerCategory.DEVICEGROUPUSAGE,
    data_trigger=DataTrigger4(
        additional_properties={
            'condition': jsonpickle.decode('{"comparator":"gt","threshold":100,"thresholdUnit":"KB","cycleType":"Daily"}')
        },
        device_group=DeviceGroupFilterCriteria(
            additional_properties=None,
            filter_criteria=DeviceGroupFilter(
                additional_properties=None,
                device_group_name='User defined group name',
                individual_or_combined='Combined',
                account_name='0000123456-00001'
            )
        ),
        action=Actionobject(
            additional_properties=None,
            suspend=True,
            suspend_details=Suspenddetailsobject(
                additional_properties=None,
                suspend_duration=90,
                suspend_option='withBilling',
                threshold=50,
                threshold_unit=ThresholdUnit.KB
            )
        )
    ),
    notification=Notificationarray(
        additional_properties=None,
        notification_type='PerEvent',
        callback=True,
        email_notification=False,
        notification_group_name='NotificationGroupName',
        notification_frequency_factor=3,
        notification_frequency_interval='Daily',
        external_email_recipients='ExternalEmailRecipients',
        sms_notification=True,
        sms_numbers=[
            Cellphonenumber(
                additional_properties=None,
                number='10-digit mobile number',
                carrier='mobile service provider'
            ),
            Cellphonenumber(
                additional_properties=None,
                number='10-digit mobile number',
                carrier='mobile service provider'
            )
        ],
        reminder=True,
        severity='Notice'
    ),
    active=Active.TRUE
)

result = create_price_plan_triggers_api.create_trigger_rules(body)

if result.is_success():
    print(result.body)
elif result.is_error():
    print(result.errors)
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

