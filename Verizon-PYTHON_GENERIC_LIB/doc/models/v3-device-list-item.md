
# V3 Device List Item

Device changed.

*This model accepts additional fields of type Any.*

## Structure

`V3DeviceListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_id` | `str` | Optional | Device IMEI. |
| `status` | `str` | Optional | Success or failure. |
| `reason` | `str` | Optional | Result reason. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "status": "AddDeviceSucceed",
  "Reason": "Device added Successfully",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

