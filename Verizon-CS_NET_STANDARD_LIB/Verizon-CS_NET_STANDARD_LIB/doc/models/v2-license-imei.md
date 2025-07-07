
# V2 License Imei

IMEIs of the devices to assign or remove licenses.

*This model accepts additional fields of type object.*

## Structure

`V2LicenseImei`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | Account name. |
| `DeviceList` | `List<string>` | Required | Device IMEI list. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

