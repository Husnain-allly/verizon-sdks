
# Mec Platforms Additional Support Info Data

Data about additional service support information for the MEC platform.

*This model accepts additional fields of type array.*

## Structure

`MecPlatformsAdditionalSupportInfoData`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `additionalInfo` | `?string` | Optional | **Constraints**: *Maximum Length*: `32` | getAdditionalInfo(): ?string | setAdditionalInfo(?string additionalInfo): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "additionalInfo": "additionalInfo2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

