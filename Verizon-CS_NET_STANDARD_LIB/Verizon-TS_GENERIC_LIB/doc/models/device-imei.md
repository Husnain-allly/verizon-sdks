
# Device Imei

Device IMEI list.

*This model accepts additional fields of type unknown.*

## Structure

`DeviceImei`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceList` | `string[]` | Required | Device IMEI list. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "deviceList": [
    "15-digit IMEI"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

