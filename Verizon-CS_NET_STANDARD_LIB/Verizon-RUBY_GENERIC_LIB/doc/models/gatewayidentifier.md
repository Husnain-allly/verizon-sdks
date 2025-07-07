
# Gatewayidentifier

*This model accepts additional fields of type Object.*

## Structure

`Gatewayidentifier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceid` | `String` | Optional | a unique parent deviceid used to group all Lora sensors. Sensors need parent gateway for connection |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

