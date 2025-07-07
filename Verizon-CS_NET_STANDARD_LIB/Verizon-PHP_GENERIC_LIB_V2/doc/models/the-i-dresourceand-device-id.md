
# The I Dresourceand Device Id

*This model accepts additional fields of type array.*

## Structure

`TheIDresourceandDeviceId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `id` | `?string` | Optional | UUID of the user record, assigned at creation | getId(): ?string | setId(?string id): void |
| `deviceid` | `?string` | Optional | This is a UUID value of the device created when the device is onboarded | getDeviceid(): ?string | setDeviceid(?string deviceid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceid": "The UUID of the device",
  "id": "id6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

