
# Onboarding

*This model accepts additional fields of type interface{}.*

## Structure

`Onboarding`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Sensoridentifier` | `*string` | Optional | the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "sensoridentifier": "The unique EUI64 address of the device",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

