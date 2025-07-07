# Create Price Plan Triggers

```ts
const createPricePlanTriggersApi = new CreatePricePlanTriggersApi(client);
```

## Class Name

`CreatePricePlanTriggersApi`


# Create Trigger Rules

Create a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```ts
async createTriggerRules(
  body: V2TriggersRequest,
  requestOptions?: RequestOptions
): Promise<ApiResponse<TriggerResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V2TriggersRequest`](../../doc/models/v2-triggers-request.md) | Body, Required | Create a trigger |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [TriggerResponse](../../doc/models/trigger-response.md).

## Example Usage

```ts
const body: V2TriggersRequest = {
  triggerName: 'name of the trigger',
  ecpdId: 'Verizon profile ID',
  triggerCategory: TriggerCategory.DeviceGroupUsage,
  dataTrigger: {
    additionalProperties: {
      'condition': { 'comparator': 'gt', 'threshold': 100, 'thresholdUnit': 'KB', 'cycleType': 'Daily' }
    },
    deviceGroup: {
      filterCriteria: {
        deviceGroupName: 'User defined group name',
        individualOrCombined: 'Combined',
        accountName: '0000123456-00001',
      },
    },
    action: {
      suspend: true,
      suspendDetails: {
        suspendDuration: 90,
        suspendOption: 'withBilling',
        threshold: 50,
        thresholdUnit: ThresholdUnit.Kb,
      },
    },
  },
  notification: {
    notificationType: 'PerEvent',
    callback: true,
    emailNotification: false,
    notificationGroupName: 'NotificationGroupName',
    notificationFrequencyFactor: 3,
    notificationFrequencyInterval: 'Daily',
    externalEmailRecipients: 'ExternalEmailRecipients',
    smsNotification: true,
    smsNumbers: [
      {
        number: '10-digit mobile number',
        carrier: 'mobile service provider',
      },
      {
        number: '10-digit mobile number',
        carrier: 'mobile service provider',
      }
    ],
    reminder: true,
    severity: 'Notice',
  },
  active: Active.True,
};

try {
  const { result, ...httpResponse } = await createPricePlanTriggersApi.createTriggerRules(body);
  // Get more response info...
  // const { statusCode, headers } = httpResponse;
} catch (error) {
  if (error instanceof ApiError) {
    const errors = error.result;
    // const { statusCode, headers } = error;
  }
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
| Default | Error response | [`RuleRestErrorResponseError`](../../doc/models/rule-rest-error-response-error.md) |

