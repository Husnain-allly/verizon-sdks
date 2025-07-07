
# Session Report

Session report for a device.

*This model accepts additional fields of type Object.*

## Structure

`SessionReport`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Sessions` | [`List<DailyUsageItem>`](../../doc/models/daily-usage-item.md) | Optional | An object containing the start and end time of the session with the amount of data transferred. | List<DailyUsageItem> getSessions() | setSessions(List<DailyUsageItem> sessions) |
| `Id` | `String` | Required | The 10-digit ID of the device. | String getId() | setId(String id) |
| `Txid` | `String` | Required | A unique string that associates the request with the location report information that is sent in asynchronous callback message.ThingSpace will send a separate callback message for each device that was in the request. All of the callback messages will have the same txid. | String getTxid() | setTxid(String txid) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "id": "709312034493372",
  "txid": "60c07fff-470b-4d6d-afcc-75e6a7c238f6",
  "sessions": [
    {
      "startTime": "startTime4",
      "endTime": "endTime8",
      "numBytes": 106,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "startTime": "startTime4",
      "endTime": "endTime8",
      "numBytes": 106,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

