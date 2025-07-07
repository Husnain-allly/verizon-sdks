
# Custom Fields

Custom data that can be included using key-value pairs.

*This model accepts additional fields of type Any.*

## Structure

`CustomFields`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `key` | `str` | Required | The key for an extended attribute. |
| `value` | `str` | Required | The value of an extended attribute. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

