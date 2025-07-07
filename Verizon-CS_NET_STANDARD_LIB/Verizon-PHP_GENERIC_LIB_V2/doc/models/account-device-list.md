
# Account Device List

A list of deviceId objects to use when requesting information from multiple devices.

*This model accepts additional fields of type array.*

## Structure

`AccountDeviceList`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceIds` | [`DeviceId[]`](../../doc/models/device-id.md) | Required | All identifiers for the device. | getDeviceIds(): array | setDeviceIds(array deviceIds): void |
| `ipaddress` | `?string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9].[0-9].[0-9].[0-9]{3,32}$` | getIpaddress(): ?string | setIpaddress(?string ipaddress): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceIds": [
    {
      "kind": "imei",
      "id": "990013907835573",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "kind": "iccid",
      "id": "89141390780800784259",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "ipAddress": "ipAddress2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

