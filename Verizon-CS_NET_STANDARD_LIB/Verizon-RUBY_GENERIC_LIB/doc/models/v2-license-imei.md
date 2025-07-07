
# V2 License Imei

IMEIs of the devices to assign or remove licenses.

*This model accepts additional fields of type Object.*

## Structure

`V2LicenseImei`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Optional | Account name. |
| `device_list` | `Array<String>` | Required | Device IMEI list. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceList": [
    "990003425730524",
    "990000473475967"
  ],
  "accountName": "accountName8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

