
# Notification Report Request

*This model accepts additional fields of type Object.*

## Structure

`NotificationReportRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | - | String getAccountName() | setAccountName(String accountName) |
| `RequestType` | `String` | Required | - | String getRequestType() | setRequestType(String requestType) |
| `Devices` | [`List<DeviceList>`](../../doc/models/device-list.md) | Required | - | List<DeviceList> getDevices() | setDevices(List<DeviceList> devices) |
| `MonitorExpirationTime` | `String` | Required | - | String getMonitorExpirationTime() | setMonitorExpirationTime(String monitorExpirationTime) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0242072320-00001",
  "requestType": "REACHABLE_FOR_DATA",
  "devices": [
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    }
  ],
  "monitorExpirationTime": "2019-12-02T15:00:00-08:00Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

