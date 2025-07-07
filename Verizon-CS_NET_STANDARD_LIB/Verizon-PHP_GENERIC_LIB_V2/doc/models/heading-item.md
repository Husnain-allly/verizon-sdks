
# Heading Item

Heading limitation provides minimum and maximum value for road user heading in unit of degrees. If the road user's heading value is between the given minimum and maximum value and the TriggerConditions are also met the message will be sent out.

The heading minimum value can be bigger than the maximum value as negative number are not supported. For example, the +/- 10 degrees around the north (0 degrees) can be defined as 350 (min) to 10 (max) degrees.

*This model accepts additional fields of type array.*

## Structure

`HeadingItem`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `heading` | [`?Heading`](../../doc/models/heading.md) | Required | - | getHeading(): ?Heading | setHeading(?Heading heading): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "heading": {
    "min": 70.7,
    "max": 144.12
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

