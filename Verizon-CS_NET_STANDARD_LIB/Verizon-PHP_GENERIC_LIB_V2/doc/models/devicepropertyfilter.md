
# Devicepropertyfilter

*This model accepts additional fields of type array.*

## Structure

`Devicepropertyfilter`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `mSelection` | [`?Devicepropertyselection`](../../doc/models/devicepropertyselection.md) | Optional | - | getMSelection(): ?Devicepropertyselection | setMSelection(?Devicepropertyselection mSelection): void |
| `mQuerytotalcount` | `?bool` | Optional | - | getMQuerytotalcount(): ?bool | setMQuerytotalcount(?bool mQuerytotalcount): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "$querytotalcount": true,
  "$selection": {
    "modelid": "modelid0",
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

