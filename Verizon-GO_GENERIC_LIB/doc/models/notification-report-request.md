
# Notification Report Request

*This model accepts additional fields of type interface{}.*

## Structure

`NotificationReportRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | - |
| `RequestType` | `string` | Required | - |
| `Devices` | [`[]models.DeviceList`](../../doc/models/device-list.md) | Required | - |
| `MonitorExpirationTime` | `string` | Required | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

