
# Device Service Information

Device service information.

*This model accepts additional fields of type interface{}.*

## Structure

`DeviceServiceInformation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResponseType` | [`*models.ApiResponseCode`](../../doc/models/api-response-code.md) | Optional | ResponseCode and/or a message indicating success or failure of the request. |
| `Imei` | `string` | Required | The International Mobile Equipment Identifier of the device. |
| `BullseyeEnable` | `bool` | Required | Shows if Hyper Precise is enabled (true) or disabled (false). |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "imei": "709312034493372",
  "BullseyeEnable": true,
  "responseType": {
    "responseCode": "INTERNAL_ERROR",
    "message": "message8",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

