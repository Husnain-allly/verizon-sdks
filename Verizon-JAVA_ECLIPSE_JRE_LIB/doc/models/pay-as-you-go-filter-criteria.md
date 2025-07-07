
# Pay as You Go Filter Criteria

*This model accepts additional fields of type Object.*

## Structure

`PayAsYouGoFilterCriteria`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FilterCriteria` | [`PayAsYouGoFilterCriteria1`](../../doc/models/pay-as-you-go-filter-criteria-1.md) | Optional | - | PayAsYouGoFilterCriteria1 getFilterCriteria() | setFilterCriteria(PayAsYouGoFilterCriteria1 filterCriteria) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

