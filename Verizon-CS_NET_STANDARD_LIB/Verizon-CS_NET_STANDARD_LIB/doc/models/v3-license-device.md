
# V3 License Device

Device IMEI.

*This model accepts additional fields of type object.*

## Structure

`V3LicenseDevice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | `string` | Required | Device IMEI. |
| `AssignmentTime` | `string` | Optional | License assignment time. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "15-digit IMEI",
  "assignmentTime": "2017-11-29 20:15:42.738 +0000 UTC",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

