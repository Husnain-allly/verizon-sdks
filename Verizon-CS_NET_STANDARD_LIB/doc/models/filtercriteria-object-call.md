
# Filtercriteria Object Call

*This model accepts additional fields of type object.*

## Structure

`FiltercriteriaObjectCall`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FilterCriteria` | [`FilterCriteria1`](../../doc/models/filter-criteria-1.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

