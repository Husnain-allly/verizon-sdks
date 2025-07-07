# Update Triggers

```php
$updateTriggersApi = $client->getUpdateTriggersApi();
```

## Class Name

`UpdateTriggersApi`


# Update All Available Triggers

Updates the promotional triggers for pseudo-MDN.

```php
function updateAllAvailableTriggers(?RequestTrigger $body = null): ApiResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`?RequestTrigger`](../../doc/models/request-trigger.md) | Body, Optional | Update the triggers |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `getResult()` method on this instance returns the response data which is of type [`Success`](../../doc/models/success.md).

## Example Usage

```php
$body = RequestTriggerBuilder::init()
    ->triggerId('2874DEC7-26CF-4797-9C6A-B5A2AC72D526')
    ->triggerName('PromoAlerts_0000000000-00001_23456789')
    ->accountName('0000123456-000001')
    ->organizationName('Optional group name')
    ->triggerCategory('PromoAlerts')
    ->build();

$apiResponse = $updateTriggersApi->updateAllAvailableTriggers($body);
```

## Example Response *(as JSON)*

```json
{
  "status": "Success"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Error response | [`ReadySimRestErrorResponseException`](../../doc/models/ready-sim-rest-error-response-exception.md) |

