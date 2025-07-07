
# Callback Summary

Registered callback information.

*This model accepts additional fields of type interface{}.*

## Structure

`CallbackSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `*string` | Optional | Callback URL for an subscribed service. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "url": "http://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

