
# Qos Device Info

*This model accepts additional fields of type object.*

## Structure

`QosDeviceInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | [`QosDeviceId`](../../doc/models/qos-device-id.md) | Required | - |
| `DeviceIPv6Addr` | `string` | Optional | - |
| `FlowInfo` | [`List<FlowInfo>`](../../doc/models/flow-info.md) | Required | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

