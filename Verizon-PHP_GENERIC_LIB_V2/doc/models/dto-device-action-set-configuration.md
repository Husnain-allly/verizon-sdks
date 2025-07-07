
# Dto Device Action Set Configuration

*This model accepts additional fields of type array.*

## Structure

`DtoDeviceActionSetConfiguration`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceConfig` | [`?DtoDeviceConfig`](../../doc/models/dto-device-config.md) | Optional | - | getDeviceConfig(): ?DtoDeviceConfig | setDeviceConfig(?DtoDeviceConfig deviceConfig): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceConfig": {
    "ble": {
      "dataMode": 216,
      "manufacturerId": 180,
      "maxNumScan": 126,
      "minSigStr": 60,
      "monitorPeriod": 88,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

