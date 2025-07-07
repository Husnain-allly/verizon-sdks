
# The I Dresourceand Device Id

*This model accepts additional fields of type unknown.*

## Structure

`TheIDresourceandDeviceId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `string \| undefined` | Optional | UUID of the user record, assigned at creation |
| `deviceid` | `string \| undefined` | Optional | This is a UUID value of the device created when the device is onboarded |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

