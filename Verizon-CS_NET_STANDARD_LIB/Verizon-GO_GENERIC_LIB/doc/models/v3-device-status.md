
# V3 Device Status

Device status.

*This model accepts additional fields of type interface{}.*

## Structure

`V3DeviceStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Required | Device IMEI. |
| `Status` | `string` | Required | Success or failure. |
| `ResultReason` | `*string` | Optional | Result reason. |
| `UpdatedTime` | `*time.Time` | Optional | Updated Time. |
| `RecentAttemptTime` | `*time.Time` | Optional | The most recent attempt time. |
| `NextAttemptTime` | `*time.Time` | Optional | Next attempt time. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

