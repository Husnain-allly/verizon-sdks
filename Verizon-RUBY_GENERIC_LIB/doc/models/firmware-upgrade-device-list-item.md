
# Firmware Upgrade Device List Item

A JSON object for each device that was included in the upgrade, showing the device IMEI, the status of the upgrade, and additional information about the status.

*This model accepts additional fields of type Object.*

## Structure

`FirmwareUpgradeDeviceListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_id` | `String` | Optional | Device IMEI. |
| `status` | `String` | Optional | The status of the upgrade for this device. |
| `result_reason` | `String` | Optional | Additional details about the status. Not included when status='Request Pending.' |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "900000000000002",
  "status": "Device Accepted",
  "resultReason": "success",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

