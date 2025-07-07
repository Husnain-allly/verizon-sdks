
# Qos Device Info

*This model accepts additional fields of type Object.*

## Structure

`QosDeviceInfo`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | [`QosDeviceId`](../../doc/models/qos-device-id.md) | Required | - | QosDeviceId getDeviceId() | setDeviceId(QosDeviceId deviceId) |
| `DeviceIPv6Addr` | `String` | Optional | - | String getDeviceIPv6Addr() | setDeviceIPv6Addr(String deviceIPv6Addr) |
| `FlowInfo` | [`List<FlowInfo>`](../../doc/models/flow-info.md) | Required | - | List<FlowInfo> getFlowInfo() | setFlowInfo(List<FlowInfo> flowInfo) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": {
    "id": "10-digit phone number",
    "kind": "mdn",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "deviceIPv6Addr": "IPv6 address",
  "flowInfo": [
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
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

