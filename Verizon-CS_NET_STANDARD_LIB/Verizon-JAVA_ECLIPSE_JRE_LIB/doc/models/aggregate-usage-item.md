
# Aggregate Usage Item

Contains usage information per device.

*This model accepts additional fields of type Object.*

## Structure

`AggregateUsageItem`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Imei` | `String` | Optional | International Mobile Equipment Identifier. This is the ID of the device reporting usage. | String getImei() | setImei(String imei) |
| `NumberOfSessions` | `Integer` | Optional | Number of sessions established by the device reporting usage. | Integer getNumberOfSessions() | setNumberOfSessions(Integer numberOfSessions) |
| `BytesTransferred` | `Integer` | Optional | The amount of data transferred by the device reporting usage, measured in Bytes. | Integer getBytesTransferred() | setBytesTransferred(Integer bytesTransferred) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "imei": "709312034493372",
  "numberOfSessions": 1,
  "bytesTransferred": 2057,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

