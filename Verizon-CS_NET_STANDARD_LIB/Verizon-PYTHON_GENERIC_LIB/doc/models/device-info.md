
# Device Info

The devices that you want to locate. The array cannot contain more than 20 devices.

*This model accepts additional fields of type Any.*

## Structure

`DeviceInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `str` | Required | Device identifier. |
| `kind` | `str` | Required | Device identifier kind. |
| `mdn` | `str` | Required | Device MDN. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

