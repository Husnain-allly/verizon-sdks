
# Custom Fields

Custom data that can be included using key-value pairs.

*This model accepts additional fields of type unknown.*

## Structure

`CustomFields`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `key` | `string` | Required | The key for an extended attribute. |
| `value` | `string` | Required | The value of an extended attribute. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

