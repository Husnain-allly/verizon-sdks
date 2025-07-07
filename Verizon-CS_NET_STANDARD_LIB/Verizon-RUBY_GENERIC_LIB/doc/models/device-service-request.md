
# Device Service Request

Device information.

*This model accepts additional fields of type Object.*

## Structure

`DeviceServiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `imei` | `String` | Required | International Mobile Equipment Identifier. The unique ID of a device.<br><br>**Constraints**: *Pattern*: `^[0-9]{15}$` |
| `bullseye_enable` | `TrueClass \| FalseClass` | Required | Set to Enable (true) or Disable (false). |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

