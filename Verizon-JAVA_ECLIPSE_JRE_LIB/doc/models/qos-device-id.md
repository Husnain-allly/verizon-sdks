
# Qos Device Id

*This model accepts additional fields of type Object.*

## Structure

`QosDeviceId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Optional | - | String getId() | setId(String id) |
| `Kind` | `String` | Optional | - | String getKind() | setKind(String kind) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "id": "10-digit phone number",
  "kind": "mdn",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

