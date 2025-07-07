
# History Attribute Value

Streaming RF parameter for which you want to retrieve history data.

*This model accepts additional fields of type array.*

## Structure

`HistoryAttributeValue`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | [`?string(AttributeIdentifier)`](../../doc/models/attribute-identifier.md) | Optional | Attribute identifier. | getName(): ?string | setName(?string name): void |
| `value` | `?string` | Optional | Attribute value. | getValue(): ?string | setValue(?string value): void |
| `createdOn` | `?DateTime` | Optional | Date and time the request was created. | getCreatedOn(): ?\DateTime | setCreatedOn(?\DateTime createdOn): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "createdOn": "2022-02-10T16:02:21.406Z",
  "name": "LINK_QUALITY",
  "value": "47",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

