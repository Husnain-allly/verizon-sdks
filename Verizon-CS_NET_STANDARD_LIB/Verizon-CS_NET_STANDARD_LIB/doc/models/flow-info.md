
# Flow Info

*This model accepts additional fields of type object.*

## Structure

`FlowInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FlowServer` | `string` | Optional | - |
| `FlowDevice` | `string` | Optional | - |
| `FlowDirection` | `string` | Optional | - |
| `FlowProtocol` | `string` | Optional | - |
| `QciOption` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

