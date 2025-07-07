
# V3 License Device

Device IMEI.

*This model accepts additional fields of type Object.*

## Structure

`V3LicenseDevice`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | `String` | Required | Device IMEI. | String getDeviceId() | setDeviceId(String deviceId) |
| `AssignmentTime` | `String` | Optional | License assignment time. | String getAssignmentTime() | setAssignmentTime(String assignmentTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "assignmentTime": "2017-11-29 20:15:42.738 +0000 UTC",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

