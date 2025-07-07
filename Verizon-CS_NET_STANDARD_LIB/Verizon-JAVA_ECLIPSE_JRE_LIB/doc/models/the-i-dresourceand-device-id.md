
# The I Dresourceand Device Id

*This model accepts additional fields of type Object.*

## Structure

`TheIDresourceandDeviceId`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Optional | UUID of the user record, assigned at creation | String getId() | setId(String id) |
| `Deviceid` | `String` | Optional | This is a UUID value of the device created when the device is onboarded | String getDeviceid() | setDeviceid(String deviceid) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

