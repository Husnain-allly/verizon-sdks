
# Gatewayidentifier

*This model accepts additional fields of type Object.*

## Structure

`Gatewayidentifier`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Deviceid` | `String` | Optional | a unique parent deviceid used to group all Lora sensors. Sensors need parent gateway for connection | String getDeviceid() | setDeviceid(String deviceid) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceid": "UUID of the Gateway device",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

