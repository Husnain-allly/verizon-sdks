
# Devicepropertyfilter

*This model accepts additional fields of type Any.*

## Structure

`Devicepropertyfilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `m_selection` | [`Devicepropertyselection`](../../doc/models/devicepropertyselection.md) | Optional | - |
| `m_querytotalcount` | `bool` | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

