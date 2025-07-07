
# V1 Device List Item

A JSON object for each device that was included in the request, showing the device IMEI, the status of the addition or removal, and additional information about the status.

*This model accepts additional fields of type array.*

## Structure

`V1DeviceListItem`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceId` | `?string` | Optional | Device IMEI. | getDeviceId(): ?string | setDeviceId(?string deviceId): void |
| `status` | `?string` | Optional | Whether the device was successfully added or removed from the campaign. | getStatus(): ?string | setStatus(?string status): void |
| `reason` | `?string` | Optional | Additional details about the status. | getReason(): ?string | setReason(?string reason): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceId": "900000000000001",
  "status": "LicenseAssignSuccess",
  "Reason": "Success",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

