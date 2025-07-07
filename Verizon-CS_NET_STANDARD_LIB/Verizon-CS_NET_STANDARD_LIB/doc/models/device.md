
# Device

Identifies a particular IoT device.

*This model accepts additional fields of type object.*

## Structure

`Device`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Device identifier. |
| `Kind` | `string` | Required | Device kind identifier. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

