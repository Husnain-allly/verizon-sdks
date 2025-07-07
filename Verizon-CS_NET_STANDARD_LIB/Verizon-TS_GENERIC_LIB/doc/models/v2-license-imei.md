
# V2 License Imei

IMEIs of the devices to assign or remove licenses.

*This model accepts additional fields of type unknown.*

## Structure

`V2LicenseImei`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string \| undefined` | Optional | Account name. |
| `deviceList` | `string[]` | Required | Device IMEI list. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

