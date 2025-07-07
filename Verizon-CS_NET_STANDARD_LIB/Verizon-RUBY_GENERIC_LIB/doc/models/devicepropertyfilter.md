
# Devicepropertyfilter

*This model accepts additional fields of type Object.*

## Structure

`Devicepropertyfilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `m_selection` | [`Devicepropertyselection`](../../doc/models/devicepropertyselection.md) | Optional | - |
| `m_querytotalcount` | `TrueClass \| FalseClass` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

