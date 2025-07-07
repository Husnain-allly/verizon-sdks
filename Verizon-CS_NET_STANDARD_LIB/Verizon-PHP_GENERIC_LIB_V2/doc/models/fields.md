
# Fields

List of fields affected by the event.

*This model accepts additional fields of type array.*

## Structure

`Fields`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `configuration` | [`?Configuration`](../../doc/models/configuration.md) | Optional | List of the field names and values to set. | getConfiguration(): ?Configuration | setConfiguration(?Configuration configuration): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "configuration": {
    "frequency": "Low",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

