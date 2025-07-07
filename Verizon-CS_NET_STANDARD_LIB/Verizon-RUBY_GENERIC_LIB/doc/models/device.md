
# Device

Identifies a particular IoT device.

*This model accepts additional fields of type Object.*

## Structure

`Device`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `String` | Required | Device identifier. |
| `kind` | `String` | Required | Device kind identifier. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

