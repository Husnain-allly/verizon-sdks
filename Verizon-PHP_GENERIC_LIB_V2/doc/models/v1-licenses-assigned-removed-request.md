
# V1 Licenses Assigned Removed Request

IMEIs of the devices to assign licenses to.

*This model accepts additional fields of type array.*

## Structure

`V1LicensesAssignedRemovedRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceList` | `string[]` | Required | The IMEIs of the devices. | getDeviceList(): array | setDeviceList(array deviceList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceList": [
    "900000000000001",
    "900000000000998",
    "900000000000999"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

