
# Ready Sim Device Id

*This model accepts additional fields of type Object.*

## Structure

`ReadySimDeviceId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Kind` | `String` | Optional | - | String getKind() | setKind(String kind) |
| `Id` | `String` | Optional | - | String getId() | setId(String id) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "kind": "iccid",
  "id": "20-digit iccid",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

