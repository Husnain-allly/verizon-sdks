
# Account Group Share Filter

*This model accepts additional fields of type Object.*

## Structure

`AccountGroupShareFilter`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `RatePlanGroupId` | `Integer` | Optional | - | Integer getRatePlanGroupId() | setRatePlanGroupId(Integer ratePlanGroupId) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "ratePlanGroupId": 73,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

