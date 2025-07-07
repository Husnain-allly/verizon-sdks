
# V3 Device List Item

Device changed.

*This model accepts additional fields of type Object.*

## Structure

`V3DeviceListItem`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | `String` | Optional | Device IMEI. | String getDeviceId() | setDeviceId(String deviceId) |
| `Status` | `String` | Optional | Success or failure. | String getStatus() | setStatus(String status) |
| `Reason` | `String` | Optional | Result reason. | String getReason() | setReason(String reason) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

