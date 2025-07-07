
# Billing Cycle

*This model accepts additional fields of type Object.*

## Structure

`BillingCycle`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Year` | `String` | Optional | - | String getYear() | setYear(String year) |
| `Month` | `String` | Optional | - | String getMonth() | setMonth(String month) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "year": "2020",
  "month": "3",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

