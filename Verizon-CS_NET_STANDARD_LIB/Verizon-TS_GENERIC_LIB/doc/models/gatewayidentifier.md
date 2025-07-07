
# Gatewayidentifier

*This model accepts additional fields of type unknown.*

## Structure

`Gatewayidentifier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceid` | `string \| undefined` | Optional | a unique parent deviceid used to group all Lora sensors. Sensors need parent gateway for connection |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

