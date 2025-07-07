
# V3 Device Status

Device status.

*This model accepts additional fields of type Object.*

## Structure

`V3DeviceStatus`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | `String` | Required | Device IMEI. | String getDeviceId() | setDeviceId(String deviceId) |
| `Status` | `String` | Required | Success or failure. | String getStatus() | setStatus(String status) |
| `ResultReason` | `String` | Optional | Result reason. | String getResultReason() | setResultReason(String resultReason) |
| `UpdatedTime` | `LocalDateTime` | Optional | Updated Time. | LocalDateTime getUpdatedTime() | setUpdatedTime(LocalDateTime updatedTime) |
| `RecentAttemptTime` | `LocalDateTime` | Optional | The most recent attempt time. | LocalDateTime getRecentAttemptTime() | setRecentAttemptTime(LocalDateTime recentAttemptTime) |
| `NextAttemptTime` | `LocalDateTime` | Optional | Next attempt time. | LocalDateTime getNextAttemptTime() | setNextAttemptTime(LocalDateTime nextAttemptTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "status": "UpgradePending",
  "resultReason": "Upgrade pending, the device upgrade is estimated to be scheduled for 06 Oct 22 18:05 UTC",
  "updatedTime": "2022-08-05T21:05:27.129Z",
  "recentAttemptTime": "2022-10-05T21:05:01.19Z",
  "nextAttemptTime": "2022-10-06T18:35:00Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

