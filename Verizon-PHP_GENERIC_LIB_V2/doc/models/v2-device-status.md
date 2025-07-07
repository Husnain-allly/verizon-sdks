
# V2 Device Status

Device with id in IMEI.

*This model accepts additional fields of type array.*

## Structure

`V2DeviceStatus`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceId` | `string` | Required | Device IMEI. | getDeviceId(): string | setDeviceId(string deviceId): void |
| `status` | `string` | Required | Success or failure. | getStatus(): string | setStatus(string status): void |
| `resultReason` | `?string` | Optional | Result reason. | getResultReason(): ?string | setResultReason(?string resultReason): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceId": "990000473475967",
  "status": "Failure",
  "resultReason": "Device does not exist.",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

