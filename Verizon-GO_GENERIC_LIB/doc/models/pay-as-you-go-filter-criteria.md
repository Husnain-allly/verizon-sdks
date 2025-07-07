
# Pay as You Go Filter Criteria

*This model accepts additional fields of type interface{}.*

## Structure

`PayAsYouGoFilterCriteria`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FilterCriteria` | [`*models.PayAsYouGoFilterCriteria1`](../../doc/models/pay-as-you-go-filter-criteria-1.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

