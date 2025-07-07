
# Device Logging Status

Device logging status information.

*This model accepts additional fields of type Object.*

## Structure

`DeviceLoggingStatus`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | `String` | Required | Device IMEI. | String getDeviceId() | setDeviceId(String deviceId) |
| `ExpiryDate` | `LocalDate` | Required | The date when device logging expires. | LocalDate getExpiryDate() | setExpiryDate(LocalDate expiryDate) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": "990013907835573",
  "expiryDate": "2020-10-19",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

