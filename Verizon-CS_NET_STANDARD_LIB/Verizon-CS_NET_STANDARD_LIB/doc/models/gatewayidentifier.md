
# Gatewayidentifier

*This model accepts additional fields of type object.*

## Structure

`Gatewayidentifier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Deviceid` | `string` | Optional | a unique parent deviceid used to group all Lora sensors. Sensors need parent gateway for connection |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

