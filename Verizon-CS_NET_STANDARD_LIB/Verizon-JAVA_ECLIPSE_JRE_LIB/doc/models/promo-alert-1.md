
# Promo Alert 1

*This model accepts additional fields of type Object.*

## Structure

`PromoAlert1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FilterCriteria` | `List<Object>` | Optional | - | List<Object> getFilterCriteria() | setFilterCriteria(List<Object> filterCriteria) |
| `Condition` | [`List<Keyschunk2>`](../../doc/models/keyschunk-2.md) | Optional | - | List<Keyschunk2> getCondition() | setCondition(List<Keyschunk2> condition) |
| `EnablePromoExp` | `Boolean` | Optional | - | Boolean getEnablePromoExp() | setEnablePromoExp(Boolean enablePromoExp) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "enablePromoExp": true,
  "filterCriteria": [
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    }
  ],
  "condition": [
    {
      "dataPercentage50": false,
      "dataPercentage75": false,
      "dataPercentage90": false,
      "dataPercentage100": false,
      "smsPercentage50": false,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "dataPercentage50": false,
      "dataPercentage75": false,
      "dataPercentage90": false,
      "dataPercentage100": false,
      "smsPercentage50": false,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

