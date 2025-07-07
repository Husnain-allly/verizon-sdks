
# Acceleration

*This model accepts additional fields of type array.*

## Structure

`Acceleration`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `x` | `?string` | Optional | - | getX(): ?string | setX(?string x): void |
| `y` | `?string` | Optional | - | getY(): ?string | setY(?string y): void |
| `z` | `?string` | Optional | - | getZ(): ?string | setZ(?string z): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "x": "0.0277",
  "y": "-1.0334",
  "z": "-0.0134",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

