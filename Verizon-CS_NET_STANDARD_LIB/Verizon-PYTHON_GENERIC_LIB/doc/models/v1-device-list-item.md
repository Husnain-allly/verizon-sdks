
# V1 Device List Item

A JSON object for each device that was included in the request, showing the device IMEI, the status of the addition or removal, and additional information about the status.

*This model accepts additional fields of type Any.*

## Structure

`V1DeviceListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_id` | `str` | Optional | Device IMEI. |
| `status` | `str` | Optional | Whether the device was successfully added or removed from the campaign. |
| `reason` | `str` | Optional | Additional details about the status. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "900000000000001",
  "status": "LicenseAssignSuccess",
  "Reason": "Success",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

