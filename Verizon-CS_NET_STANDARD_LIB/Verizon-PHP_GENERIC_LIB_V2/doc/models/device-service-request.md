
# Device Service Request

Device information.

*This model accepts additional fields of type array.*

## Structure

`DeviceServiceRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `imei` | `string` | Required | International Mobile Equipment Identifier. The unique ID of a device.<br><br>**Constraints**: *Pattern*: `^[0-9]{15}$` | getImei(): string | setImei(string imei): void |
| `bullseyeEnable` | `bool` | Required | Set to Enable (true) or Disable (false). | getBullseyeEnable(): bool | setBullseyeEnable(bool bullseyeEnable): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "imei": "354658090356210",
  "BullseyeEnable": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

