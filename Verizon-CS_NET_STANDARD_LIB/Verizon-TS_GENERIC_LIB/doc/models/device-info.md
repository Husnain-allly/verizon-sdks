
# Device Info

The devices that you want to locate. The array cannot contain more than 20 devices.

*This model accepts additional fields of type unknown.*

## Structure

`DeviceInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string` | Required | Device identifier. |
| `kind` | `string` | Required | Device identifier kind. |
| `mdn` | `string` | Required | Device MDN. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

