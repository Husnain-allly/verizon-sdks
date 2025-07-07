
# Account License Device List Item

The list of devices that have licenses assigned, including the date and time of when each license was assigned.

*This model accepts additional fields of type Object.*

## Structure

`AccountLicenseDeviceListItem`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | `String` | Optional | Device IMEI. | String getDeviceId() | setDeviceId(String deviceId) |
| `AssignmentTime` | `LocalDateTime` | Optional | Timestamp of when a license was assigned to the device. | LocalDateTime getAssignmentTime() | setAssignmentTime(LocalDateTime assignmentTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": "990003425730535",
  "assignmentTime": "2017-11-29T16:03:42.000Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

