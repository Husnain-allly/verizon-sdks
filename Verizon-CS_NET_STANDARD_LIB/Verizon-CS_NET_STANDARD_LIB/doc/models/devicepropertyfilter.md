
# Devicepropertyfilter

*This model accepts additional fields of type object.*

## Structure

`Devicepropertyfilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MSelection` | [`Devicepropertyselection`](../../doc/models/devicepropertyselection.md) | Optional | - |
| `MQuerytotalcount` | `bool?` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

