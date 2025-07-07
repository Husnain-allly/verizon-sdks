
# The I Dresourceand Device Id

*This model accepts additional fields of type interface{}.*

## Structure

`TheIDresourceandDeviceId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `*string` | Optional | UUID of the user record, assigned at creation |
| `Deviceid` | `*string` | Optional | This is a UUID value of the device created when the device is onboarded |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

