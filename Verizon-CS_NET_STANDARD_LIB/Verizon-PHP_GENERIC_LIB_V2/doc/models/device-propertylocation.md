
# Device Propertylocation

*This model accepts additional fields of type array.*

## Structure

`DevicePropertylocation`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `latitude` | `?string` | Optional | - | getLatitude(): ?string | setLatitude(?string latitude): void |
| `longitude` | `?string` | Optional | - | getLongitude(): ?string | setLongitude(?string longitude): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "latitude": "37.2314796",
  "longitude": "-119.4692153",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

