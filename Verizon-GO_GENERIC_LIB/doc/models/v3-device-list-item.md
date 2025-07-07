
# V3 Device List Item

Device changed.

*This model accepts additional fields of type interface{}.*

## Structure

`V3DeviceListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `*string` | Optional | Device IMEI. |
| `Status` | `*string` | Optional | Success or failure. |
| `Reason` | `*string` | Optional | Result reason. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "status": "AddDeviceSucceed",
  "Reason": "Device added Successfully",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

