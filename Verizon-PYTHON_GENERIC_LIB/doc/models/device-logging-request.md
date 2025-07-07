
# Device Logging Request

Device logging information.

*This model accepts additional fields of type Any.*

## Structure

`DeviceLoggingRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_ids` | `List[str]` | Required | List of device IMEI identifiers. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

