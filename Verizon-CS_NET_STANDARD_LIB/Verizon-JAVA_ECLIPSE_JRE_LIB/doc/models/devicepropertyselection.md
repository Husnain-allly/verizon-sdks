
# Devicepropertyselection

*This model accepts additional fields of type Object.*

## Structure

`Devicepropertyselection`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Modelid` | `String` | Optional | - | String getModelid() | setModelid(String modelid) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

