
# Device Imei

Device IMEI list.

*This model accepts additional fields of type object.*

## Structure

`DeviceImei`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceList` | `List<string>` | Required | Device IMEI list. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

