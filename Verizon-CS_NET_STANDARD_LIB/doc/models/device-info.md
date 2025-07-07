
# Device Info

The devices that you want to locate. The array cannot contain more than 20 devices.

*This model accepts additional fields of type object.*

## Structure

`DeviceInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | Device identifier. |
| `Kind` | `string` | Required | Device identifier kind. |
| `Mdn` | `string` | Required | Device MDN. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "id": "980003420535573",
  "kind": "imei",
  "mdn": "7892345678",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

