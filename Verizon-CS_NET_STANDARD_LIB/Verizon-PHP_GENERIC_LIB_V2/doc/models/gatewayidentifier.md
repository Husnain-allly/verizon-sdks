
# Gatewayidentifier

*This model accepts additional fields of type array.*

## Structure

`Gatewayidentifier`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `deviceid` | `?string` | Optional | a unique parent deviceid used to group all Lora sensors. Sensors need parent gateway for connection | getDeviceid(): ?string | setDeviceid(?string deviceid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

