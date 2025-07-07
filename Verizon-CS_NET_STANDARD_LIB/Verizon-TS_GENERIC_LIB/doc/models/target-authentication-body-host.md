
# Target Authentication Body Host

Host information.

*This model accepts additional fields of type unknown.*

## Structure

`TargetAuthenticationBodyHost`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `hostandpath` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

