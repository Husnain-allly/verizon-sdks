
# Filtercriteria Object Call

*This model accepts additional fields of type Object.*

## Structure

`FiltercriteriaObjectCall`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filter_criteria` | [`FilterCriteria1`](../../doc/models/filter-criteria-1.md) | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

