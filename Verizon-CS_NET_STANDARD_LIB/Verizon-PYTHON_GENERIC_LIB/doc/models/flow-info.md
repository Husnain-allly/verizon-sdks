
# Flow Info

*This model accepts additional fields of type Any.*

## Structure

`FlowInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `flow_server` | `str` | Optional | - |
| `flow_device` | `str` | Optional | - |
| `flow_direction` | `str` | Optional | - |
| `flow_protocol` | `str` | Optional | - |
| `qci_option` | `str` | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

