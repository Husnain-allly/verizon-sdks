
# Dto Device Command

*This model accepts additional fields of type array.*

## Structure

`DtoDeviceCommand`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountName(): ?string | setAccountName(?string accountName): void |
| `configuration` | [`?Rbstiltconfig`](../../doc/models/rbstiltconfig.md) | Optional | - | getConfiguration(): ?Rbstiltconfig | setConfiguration(?Rbstiltconfig configuration): void |
| `resourceidentifier` | [`?DtoResourceidentifier`](../../doc/models/dto-resourceidentifier.md) | Optional | - | getResourceidentifier(): ?DtoResourceidentifier | setResourceidentifier(?DtoResourceidentifier resourceidentifier): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "configuration": {
    "RbsHighPrecisionTiltConfig": {
      "mode": "reportOnChange",
      "periodic-reporting": {
        "unit": "minutes",
        "hours": 250,
        "minutes": 232,
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "hold-time": 62,
      "angle-away": 90,
      "angle-toward": 30,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "resourceidentifier": {
    "id": "id4"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

