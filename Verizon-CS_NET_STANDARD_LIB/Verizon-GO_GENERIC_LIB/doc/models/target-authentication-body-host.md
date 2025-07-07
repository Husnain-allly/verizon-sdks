
# Target Authentication Body Host

Host information.

*This model accepts additional fields of type interface{}.*

## Structure

`TargetAuthenticationBodyHost`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Hostandpath` | `*string` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "hostandpath": "https:// myhost.com:1825",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

