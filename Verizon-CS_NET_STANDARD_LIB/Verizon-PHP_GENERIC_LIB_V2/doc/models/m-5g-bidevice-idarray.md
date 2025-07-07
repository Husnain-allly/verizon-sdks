
# M 5G Bidevice Idarray

*This model accepts additional fields of type array.*

## Structure

`M5GBideviceIdarray`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceId` | [M5GBideviceId1](../../doc/models/m-5g-bidevice-id-1.md)[]\|null | Optional | This is Array of a container for any-of cases. | getDeviceId(): ?array | setDeviceId(?array deviceId): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "deviceId": [
    {
      "id": "id0",
      "kind": "kind8",
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

