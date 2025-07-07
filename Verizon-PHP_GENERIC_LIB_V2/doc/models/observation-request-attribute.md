
# Observation Request Attribute

Streaming RF parameter that you want to observe.

*This model accepts additional fields of type array.*

## Structure

`ObservationRequestAttribute`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | [`?string(AttributeIdentifier)`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. | getName(): ?string | setName(?string name): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "name": "RADIO_SIGNAL_STRENGTH",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

