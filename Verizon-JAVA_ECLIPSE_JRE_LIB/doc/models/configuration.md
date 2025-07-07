
# Configuration

List of the field names and values to set.

*This model accepts additional fields of type Object.*

## Structure

`Configuration`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Frequency` | `String` | Optional | - | String getFrequency() | setFrequency(String frequency) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "frequency": "Low",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

