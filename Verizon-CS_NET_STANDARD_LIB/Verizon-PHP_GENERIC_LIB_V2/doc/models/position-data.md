
# Position Data

Position data.

*This model accepts additional fields of type array.*

## Structure

`PositionData`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `time` | `?string` | Optional | Time location obtained. | getTime(): ?string | setTime(?string time): void |
| `utcoffset` | `?string` | Optional | UTC offset of time. | getUtcoffset(): ?string | setUtcoffset(?string utcoffset): void |
| `x` | `?string` | Optional | X coordinate of location. | getX(): ?string | setX(?string x): void |
| `y` | `?string` | Optional | Y coordinate of location. | getY(): ?string | setY(?string y): void |
| `radius` | `?string` | Optional | Radius of the location in meters. | getRadius(): ?string | setRadius(?string radius): void |
| `qos` | `?bool` | Optional | Whether requested accurary is met or not. | getQos(): ?bool | setQos(?bool qos): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "qos": false,
  "radius": "5571",
  "time": "20170520004421",
  "x": "33.45324",
  "y": "-84.59621",
  "utcoffset": "utcoffset0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

