
# V3 License Device

Device IMEI.

*This model accepts additional fields of type array.*

## Structure

`V3LicenseDevice`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceId` | `string` | Required | Device IMEI. | getDeviceId(): string | setDeviceId(string deviceId): void |
| `assignmentTime` | `?string` | Optional | License assignment time. | getAssignmentTime(): ?string | setAssignmentTime(?string assignmentTime): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "assignmentTime": "2017-11-29 20:15:42.738 +0000 UTC",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

