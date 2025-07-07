
# The I Dresourceand Device Id

*This model accepts additional fields of type Object.*

## Structure

`TheIDresourceandDeviceId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `String` | Optional | UUID of the user record, assigned at creation |
| `deviceid` | `String` | Optional | This is a UUID value of the device created when the device is onboarded |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "deviceid": "The UUID of the device",
  "id": "id6",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

