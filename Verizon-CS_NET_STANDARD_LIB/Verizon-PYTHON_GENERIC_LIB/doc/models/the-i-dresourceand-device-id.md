
# The I Dresourceand Device Id

*This model accepts additional fields of type Any.*

## Structure

`TheIDresourceandDeviceId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `str` | Optional | UUID of the user record, assigned at creation |
| `deviceid` | `str` | Optional | This is a UUID value of the device created when the device is onboarded |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

