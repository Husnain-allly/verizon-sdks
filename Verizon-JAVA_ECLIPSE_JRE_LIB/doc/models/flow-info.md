
# Flow Info

*This model accepts additional fields of type Object.*

## Structure

`FlowInfo`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FlowServer` | `String` | Optional | - | String getFlowServer() | setFlowServer(String flowServer) |
| `FlowDevice` | `String` | Optional | - | String getFlowDevice() | setFlowDevice(String flowDevice) |
| `FlowDirection` | `String` | Optional | - | String getFlowDirection() | setFlowDirection(String flowDirection) |
| `FlowProtocol` | `String` | Optional | - | String getFlowProtocol() | setFlowProtocol(String flowProtocol) |
| `QciOption` | `String` | Optional | - | String getQciOption() | setQciOption(String qciOption) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

