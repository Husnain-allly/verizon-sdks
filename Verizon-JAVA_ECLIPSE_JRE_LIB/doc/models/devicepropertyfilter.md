
# Devicepropertyfilter

*This model accepts additional fields of type Object.*

## Structure

`Devicepropertyfilter`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `MSelection` | [`Devicepropertyselection`](../../doc/models/devicepropertyselection.md) | Optional | - | Devicepropertyselection getMSelection() | setMSelection(Devicepropertyselection mSelection) |
| `MQuerytotalcount` | `Boolean` | Optional | - | Boolean getMQuerytotalcount() | setMQuerytotalcount(Boolean mQuerytotalcount) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

