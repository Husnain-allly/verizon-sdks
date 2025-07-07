# Update Price Plan Triggers

```ts
const updatePricePlanTriggersApi = new UpdatePricePlanTriggersApi(client);
```

## Class Name

`UpdatePricePlanTriggersApi`


# Update Trigger Rules

Updates a usage trigger at the account level, device level or a price plan trigger for all devices on the account

```ts
async updateTriggerRules(
  body: V2TriggersRequest1,
  requestOptions?: RequestOptions
): Promise<ApiResponse<TriggerResponse>>
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V2TriggersRequest1`](../../doc/models/v2-triggers-request-1.md) | Body, Required | Update a trigger |
| `requestOptions` | `RequestOptions \| undefined` | Optional | Pass additional request options. |

## Response Type

This method returns an [`ApiResponse`](../../doc/api-response.md) instance. The `result` property of this instance returns the response data which is of type [TriggerResponse](../../doc/models/trigger-response.md).

## Example Usage

```ts
const body: V2TriggersRequest1 = {
  triggerId: 'b9cc1da6-ffff-eeee-gggg-7eba8859ab5e',
  triggerName: 'name of the trigger',
  ecpdId: 'Verizon profile ID',
  triggerCategory: TriggerCategory.AccountUsage,
  dataTrigger: {
    additionalProperties: {
      'accountLevel': { 'filterCriteria': { 'separateOrCombined': 'Separate', 'accountNames': { 'accountNameList': ['0000123456-00001'] } }, 'condition': { 'comparator': 'gt', 'threshold': 100, 'thresholdUnit': 'KB', 'cycleType': 'Daily' }, 'action': { 'suspend': true, 'suspendDetails': { 'suspendFromAccounts': ['0000123456-00001'], 'suspendDuration': '90', 'suspendOption': 'withBilling', 'threshold': 50, 'thresholdUnit': 'KB' } } }
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
  const { result, ...httpResponse } = await updatePricePlanTriggersApi.updateTriggerRules(body);
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

