
# V3 License Imei

List of devices.

*This model accepts additional fields of type interface{}.*

## Structure

`V3LicenseImei`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceList` | `[]string` | Required | Device IMEI list. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "deviceList": [
    "15-digit IMEI",
    "15-digit IMEI"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

