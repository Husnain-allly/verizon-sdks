
# Account Share Filter Criteria

*This model accepts additional fields of type Object.*

## Structure

`AccountShareFilterCriteria`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FilterCriteria` | [`AccountShareFilterCriteria1`](../../doc/models/account-share-filter-criteria-1.md) | Optional | - | AccountShareFilterCriteria1 getFilterCriteria() | setFilterCriteria(AccountShareFilterCriteria1 filterCriteria) |
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

