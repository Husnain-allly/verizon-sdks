
# Firmware Upgrade Device List Item

A JSON object for each device that was included in the upgrade, showing the device IMEI, the status of the upgrade, and additional information about the status.

*This model accepts additional fields of type object.*

## Structure

`FirmwareUpgradeDeviceListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Optional | Device IMEI. |
| `Status` | `string` | Optional | The status of the upgrade for this device. |
| `ResultReason` | `string` | Optional | Additional details about the status. Not included when status='Request Pending.' |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

