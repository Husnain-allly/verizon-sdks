
# Devicepropertyselection

*This model accepts additional fields of type array.*

## Structure

`Devicepropertyselection`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `modelid` | `?string` | Optional | - | getModelid(): ?string | setModelid(?string modelid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "modelid": "00000000-0000-0000-0000-000000000019",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

