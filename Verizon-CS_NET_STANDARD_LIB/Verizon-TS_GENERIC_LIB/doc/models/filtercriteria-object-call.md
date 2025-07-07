
# Filtercriteria Object Call

*This model accepts additional fields of type unknown.*

## Structure

`FiltercriteriaObjectCall`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filterCriteria` | [`FilterCriteria1 \| undefined`](../../doc/models/filter-criteria-1.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "filterCriteria": {
    "carrierServicePlanCode": "carrierServicePlanCode4",
    "accountNameList": [
      "accountNameList7",
      "accountNameList8"
    ],
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

