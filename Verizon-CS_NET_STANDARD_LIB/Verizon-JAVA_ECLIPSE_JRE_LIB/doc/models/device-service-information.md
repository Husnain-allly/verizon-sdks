
# Device Service Information

Device service information.

*This model accepts additional fields of type Object.*

## Structure

`DeviceServiceInformation`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `ResponseType` | [`ApiResponseCode`](../../doc/models/api-response-code.md) | Optional | ResponseCode and/or a message indicating success or failure of the request. | ApiResponseCode getResponseType() | setResponseType(ApiResponseCode responseType) |
| `Imei` | `String` | Required | The International Mobile Equipment Identifier of the device. | String getImei() | setImei(String imei) |
| `BullseyeEnable` | `boolean` | Required | Shows if Hyper Precise is enabled (true) or disabled (false). | boolean getBullseyeEnable() | setBullseyeEnable(boolean bullseyeEnable) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

