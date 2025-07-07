
# Add Devices Result

Contains the device identifiers and a success or failure response for each device in the request.

*This model accepts additional fields of type interface{}.*

## Structure

`AddDevicesResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceIds` | [`[]models.DeviceId`](../../doc/models/device-id.md) | Optional | Identifiers for the device. |
| `Response` | `*string` | Optional | The success message or error message for the current device. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

