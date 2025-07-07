
# Device Info

The devices that you want to locate. The array cannot contain more than 20 devices.

*This model accepts additional fields of type Object.*

## Structure

`DeviceInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `String` | Required | Device identifier. |
| `kind` | `String` | Required | Device identifier kind. |
| `mdn` | `String` | Required | Device MDN. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

