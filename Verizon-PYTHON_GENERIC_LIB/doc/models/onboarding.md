
# Onboarding

*This model accepts additional fields of type Any.*

## Structure

`Onboarding`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sensoridentifier` | `str` | Optional | the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

