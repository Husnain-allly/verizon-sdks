
# Aggregate Usage

*This model accepts additional fields of type Object.*

## Structure

`AggregateUsage`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | [`GioDeviceId`](../../doc/models/gio-device-id.md) | Optional | - | GioDeviceId getDeviceId() | setDeviceId(GioDeviceId deviceId) |
| `AccountName` | `String` | Optional | The numeric name of the account, in the format "0000123456-00001". Leading zeros must be included.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getAccountName() | setAccountName(String accountName) |
| `StartTime` | `String` | Optional | The start date of the time period queried as "$datetime"<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getStartTime() | setStartTime(String startTime) |
| `EndTime` | `String` | Optional | The end date of the time period being queried as "$datetime"<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` | String getEndTime() | setEndTime(String endTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": {
    "kind": "kind8",
    "id": "id0"
  },
  "accountName": "accountName6",
  "startTime": "startTime8",
  "endTime": "endTime4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

