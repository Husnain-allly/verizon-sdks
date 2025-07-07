# Update Price Plan Triggers

```php
$updatePricePlanTriggersApi = $client->getUpdatePricePlanTriggersApi();
```

## Class Name

`UpdatePricePlanTriggersApi`


# Update Trigger Rules

Updates a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```php
function updateTriggerRules(V2TriggersRequest1 $body): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V2TriggersRequest1`](../../doc/models/v2-triggers-request-1.md) | Body, Required | Update a trigger |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`TriggerResponse`](../../doc/models/trigger-response.md).

## Example Usage

```php
$body = V2TriggersRequest1Builder::init()
    ->triggerId('b9cc1da6-ffff-eeee-gggg-7eba8859ab5e')
    ->triggerName('name of the trigger')
    ->ecpdId('Verizon profile ID')
    ->triggerCategory(TriggerCategory::ACCOUNTUSAGE)
    ->dataTrigger(
        DataTrigger5Builder::init()
            ->additionalProperty('accountLevel', ApiHelper::deserialize('{"filterCriteria":{"separateOrCombined":"Separate","accountNames":{"accountNameList":["0000123456-00001"]}},"condition":{"comparator":"gt","threshold":100,"thresholdUnit":"KB","cycleType":"Daily"},"action":{"suspend":true,"suspendDetails":{"suspendFromAccounts":["0000123456-00001"],"suspendDuration":"90","suspendOption":"withBilling","threshold":50,"thresholdUnit":"KB"}}}'))
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

$apiResponse = $updatePricePlanTriggersApi->updateTriggerRules($body);
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

