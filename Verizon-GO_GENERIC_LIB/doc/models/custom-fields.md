
# Custom Fields

Custom data that can be included using key-value pairs.

*This model accepts additional fields of type interface{}.*

## Structure

`CustomFields`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | `string` | Required | The key for an extended attribute. |
| `Value` | `string` | Required | The value of an extended attribute. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

