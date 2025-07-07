
# Flow Info

*This model accepts additional fields of type unknown.*

## Structure

`FlowInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `flowServer` | `string \| undefined` | Optional | - |
| `flowDevice` | `string \| undefined` | Optional | - |
| `flowDirection` | `string \| undefined` | Optional | - |
| `flowProtocol` | `string \| undefined` | Optional | - |
| `qciOption` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "flowServer": "[IPv6 address]:port",
  "flowDevice": "[IPv6 address]:port",
  "flowDirection": "UPLINK",
  "flowProtocol": "UDP",
  "qciOption": "Premium",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

