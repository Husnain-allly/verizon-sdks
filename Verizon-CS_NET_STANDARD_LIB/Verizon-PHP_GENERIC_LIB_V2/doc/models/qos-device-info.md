
# Qos Device Info

*This model accepts additional fields of type array.*

## Structure

`QosDeviceInfo`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceId` | [`QosDeviceId`](../../doc/models/qos-device-id.md) | Required | - | getDeviceId(): QosDeviceId | setDeviceId(QosDeviceId deviceId): void |
| `deviceIPv6Addr` | `?string` | Optional | - | getDeviceIPv6Addr(): ?string | setDeviceIPv6Addr(?string deviceIPv6Addr): void |
| `flowInfo` | [`FlowInfo[]`](../../doc/models/flow-info.md) | Required | - | getFlowInfo(): array | setFlowInfo(array flowInfo): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

