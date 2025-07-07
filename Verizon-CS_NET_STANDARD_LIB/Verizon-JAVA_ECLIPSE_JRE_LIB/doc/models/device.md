
# Device

Identifies a particular IoT device.

*This model accepts additional fields of type Object.*

## Structure

`Device`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Required | Device identifier. | String getId() | setId(String id) |
| `Kind` | `String` | Required | Device kind identifier. | String getKind() | setKind(String kind) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "id": "864508030026238",
  "kind": "IMEI",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

