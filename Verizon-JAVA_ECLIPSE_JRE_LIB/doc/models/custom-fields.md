
# Custom Fields

Custom data that can be included using key-value pairs.

*This model accepts additional fields of type Object.*

## Structure

`CustomFields`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Key` | `String` | Required | The key for an extended attribute. | String getKey() | setKey(String key) |
| `Value` | `String` | Required | The value of an extended attribute. | String getValue() | setValue(String value) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "key": "CustomField2",
  "value": "SuperVend",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

