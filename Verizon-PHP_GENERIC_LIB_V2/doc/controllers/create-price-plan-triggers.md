# Create Price Plan Triggers

```php
$createPricePlanTriggersApi = $client->getCreatePricePlanTriggersApi();
```

## Class Name

`CreatePricePlanTriggersApi`


# Create Trigger Rules

Create a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```php
function createTriggerRules(V2TriggersRequest $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V2TriggersRequest`](../../doc/models/v2-triggers-request.md) | Body, Required | Create a trigger |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`TriggerResponse`](../../doc/models/trigger-response.md).

## Example Usage

```php
$body = V2TriggersRequestBuilder::init()
    ->triggerName('name of the trigger')
    ->ecpdId('Verizon profile ID')
    ->triggerCategory(TriggerCategory::DEVICEGROUPUSAGE)
    ->dataTrigger(
        DataTrigger4Builder::init()
            ->deviceGroup(
                DeviceGroupFilterCriteriaBuilder::init()
                    ->filterCriteria(
                        DeviceGroupFilterBuilder::init()
                            ->deviceGroupName('User defined group name')
                            ->individualOrCombined('Combined')
                            ->accountName('0000123456-00001')
                            ->build()
                    )
                    ->build()
            )
            ->action(
                ActionobjectBuilder::init()
                    ->suspend(true)
                    ->suspendDetails(
                        SuspenddetailsobjectBuilder::init()
                            ->suspendDuration(90)
                            ->suspendOption('withBilling')
                            ->threshold(50)
                            ->thresholdUnit(ThresholdUnit::KB)
                            ->build()
                    )
                    ->build()
            )
            ->additionalProperty('condition', ApiHelper::deserialize('{"comparator":"gt","threshold":100,"thresholdUnit":"KB","cycleType":"Daily"}'))
            ->build()
    )
    ->notification(
        NotificationarrayBuilder::init()
            ->notificationType('PerEvent')
            ->callback(true)
            ->emailNotification(false)
            ->notificationGroupName('NotificationGroupName')
            ->notificationFrequencyFactor(3)
            ->notificationFrequencyInterval('Daily')
            ->externalEmailRecipients('ExternalEmailRecipients')
            ->smsNotification(true)
            ->smsNumbers(
                [
                    CellphonenumberBuilder::init()
                        ->number('10-digit mobile number')
                        ->carrier('mobile service provider')
                        ->build(),
                    CellphonenumberBuilder::init()
                        ->number('10-digit mobile number')
                        ->carrier('mobile service provider')
                        ->build()
                ]
            )
            ->reminder(true)
            ->severity('Notice')
            ->build()
    )
    ->active(Active::TRUE)
    ->build();

$apiResponse = $createPricePlanTriggersApi->createTriggerRules($body);
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

