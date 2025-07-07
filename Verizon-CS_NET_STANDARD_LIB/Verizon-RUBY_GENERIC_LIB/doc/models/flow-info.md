
# Flow Info

*This model accepts additional fields of type Object.*

## Structure

`FlowInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `flow_server` | `String` | Optional | - |
| `flow_device` | `String` | Optional | - |
| `flow_direction` | `String` | Optional | - |
| `flow_protocol` | `String` | Optional | - |
| `qci_option` | `String` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

