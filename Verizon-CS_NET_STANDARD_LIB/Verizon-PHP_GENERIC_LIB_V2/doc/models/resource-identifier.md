
# Resource Identifier

The ID of the target to delete, in the format {"id": "dd1682d3-2d80-cefc-f3ee-25154800beff"}.

*This model accepts additional fields of type array.*

## Structure

`ResourceIdentifier`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `id` | `?string` | Optional | Target ID. | getId(): ?string | setId(?string id): void |
| `imei` | `?string` | Optional | Device IMEI. | getImei(): ?string | setImei(?string imei): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "id": "2e61a17d-8fd1-6816-e995-e4c2528bf535",
  "imei": "imei8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

