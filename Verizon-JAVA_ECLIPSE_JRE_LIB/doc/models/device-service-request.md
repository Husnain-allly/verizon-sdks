
# Device Service Request

Device information.

*This model accepts additional fields of type Object.*

## Structure

`DeviceServiceRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Imei` | `String` | Required | International Mobile Equipment Identifier. The unique ID of a device.<br><br>**Constraints**: *Pattern*: `^[0-9]{15}$` | String getImei() | setImei(String imei) |
| `BullseyeEnable` | `boolean` | Required | Set to Enable (true) or Disable (false). | boolean getBullseyeEnable() | setBullseyeEnable(boolean bullseyeEnable) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "imei": "354658090356210",
  "BullseyeEnable": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

