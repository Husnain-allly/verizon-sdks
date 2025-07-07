
# Qos Device Info

*This model accepts additional fields of type interface{}.*

## Structure

`QosDeviceInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | [`models.QosDeviceId`](../../doc/models/qos-device-id.md) | Required | - |
| `DeviceIPv6Addr` | `*string` | Optional | - |
| `FlowInfo` | [`[]models.FlowInfo`](../../doc/models/flow-info.md) | Required | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

