
# Add Devices Result

Contains the device identifiers and a success or failure response for each device in the request.

*This model accepts additional fields of type Object.*

## Structure

`AddDevicesResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_ids` | [`Array<DeviceId>`](../../doc/models/device-id.md) | Optional | Identifiers for the device. |
| `response` | `String` | Optional | The success message or error message for the current device. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceIds": [
    {
      "id": "89148000000800784259",
      "kind": "iccid",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "response": "Success",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

