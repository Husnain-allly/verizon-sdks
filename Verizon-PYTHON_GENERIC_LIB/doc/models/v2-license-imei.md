
# V2 License Imei

IMEIs of the devices to assign or remove licenses.

*This model accepts additional fields of type Any.*

## Structure

`V2LicenseImei`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `str` | Optional | Account name. |
| `device_list` | `List[str]` | Required | Device IMEI list. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

