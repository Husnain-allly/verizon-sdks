
# Action Object Call

*This model accepts additional fields of type Object.*

## Structure

`ActionObjectCall`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Action` | [`Actionobject`](../../doc/models/actionobject.md) | Optional | - | Actionobject getAction() | setAction(Actionobject action) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "action": {
    "suspend": false,
    "suspendDetails": {
      "suspendFromAccounts": [
        "suspendFromAccounts7"
      ],
      "suspendDuration": 152,
      "suspendOption": "suspendOption2",
      "threshold": 166,
      "thresholdUnit": "GB",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "changePlan": false,
    "changePlanDetails": {
      "toCarrierServicePlanCode": "toCarrierServicePlanCode2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

