
# V3 Device List Item

Device changed.

*This model accepts additional fields of type unknown.*

## Structure

`V3DeviceListItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceId` | `string \| undefined` | Optional | Device IMEI. |
| `status` | `string \| undefined` | Optional | Success or failure. |
| `reason` | `string \| undefined` | Optional | Result reason. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

