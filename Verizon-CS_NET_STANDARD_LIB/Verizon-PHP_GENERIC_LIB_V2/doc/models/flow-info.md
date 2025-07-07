
# Flow Info

*This model accepts additional fields of type array.*

## Structure

`FlowInfo`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `flowServer` | `?string` | Optional | - | getFlowServer(): ?string | setFlowServer(?string flowServer): void |
| `flowDevice` | `?string` | Optional | - | getFlowDevice(): ?string | setFlowDevice(?string flowDevice): void |
| `flowDirection` | `?string` | Optional | - | getFlowDirection(): ?string | setFlowDirection(?string flowDirection): void |
| `flowProtocol` | `?string` | Optional | - | getFlowProtocol(): ?string | setFlowProtocol(?string flowProtocol): void |
| `qciOption` | `?string` | Optional | - | getQciOption(): ?string | setQciOption(?string qciOption): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

