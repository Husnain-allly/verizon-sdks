
# Device Logging Request

Device logging information.

*This model accepts additional fields of type Object.*

## Structure

`DeviceLoggingRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceIds` | `List<String>` | Required | List of device IMEI identifiers. | List<String> getDeviceIds() | setDeviceIds(List<String> deviceIds) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceIds": [
    "990013907835573",
    "991124018926684",
    "992234129057795",
    "998891785613351",
    "990013907835573"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

