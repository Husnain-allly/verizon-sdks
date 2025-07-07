
# M500 Management Error Exception

*This model accepts additional fields of type interface{}.*

## Structure

`M500ManagementErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Error` | `*string` | Optional | - |
| `ErrorDescription` | `*string` | Optional | **Constraints**: *Maximum Length*: `1000` |
| `Cause` | `*string` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "error": "Error name or code",
  "error_description": "A longer error description.",
  "cause": "A cause for the error",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

