
# Device Service Request

Device information.

*This model accepts additional fields of type interface{}.*

## Structure

`DeviceServiceRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Imei` | `string` | Required | International Mobile Equipment Identifier. The unique ID of a device.<br><br>**Constraints**: *Pattern*: `^[0-9]{15}$` |
| `BullseyeEnable` | `bool` | Required | Set to Enable (true) or Disable (false). |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

