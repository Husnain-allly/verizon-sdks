
# V3 License Device

Device IMEI.

*This model accepts additional fields of type Object.*

## Structure

`V3LicenseDevice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `device_id` | `String` | Required | Device IMEI. |
| `assignment_time` | `String` | Optional | License assignment time. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

