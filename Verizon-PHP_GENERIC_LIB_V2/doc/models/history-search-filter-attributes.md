
# History Search Filter Attributes

Streaming RF parameters for which you want to retrieve history data.

*This model accepts additional fields of type array.*

## Structure

`HistorySearchFilterAttributes`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | [`?string(AttributeIdentifier)`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. | getName(): ?string | setName(?string name): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "name": "LINK_QUALITY",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

