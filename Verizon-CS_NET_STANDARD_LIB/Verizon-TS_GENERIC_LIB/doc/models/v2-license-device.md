
# V2 License Device

Device IMEI list.

*This model accepts additional fields of type unknown.*

## Structure

`V2LicenseDevice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceId` | `string` | Required | Device IMEI. |
| `assignmentTime` | `string \| undefined` | Optional | License assignment time. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "deviceId": "990003425730535",
  "assignmentTime": "2017-11-29T16:03:42.000Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

