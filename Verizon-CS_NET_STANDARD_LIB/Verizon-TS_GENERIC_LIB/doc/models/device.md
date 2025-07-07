
# Device

Identifies a particular IoT device.

*This model accepts additional fields of type unknown.*

## Structure

`Device`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Required | Device identifier. |
| `kind` | `string` | Required | Device kind identifier. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

