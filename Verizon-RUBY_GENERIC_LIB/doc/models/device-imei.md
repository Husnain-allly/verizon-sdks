
# Device Imei

Device IMEI list.

*This model accepts additional fields of type Object.*

## Structure

`DeviceImei`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_list` | `Array<String>` | Required | Device IMEI list. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

