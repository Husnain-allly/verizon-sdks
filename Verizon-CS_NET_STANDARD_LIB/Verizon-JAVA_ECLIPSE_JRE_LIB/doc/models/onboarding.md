
# Onboarding

*This model accepts additional fields of type Object.*

## Structure

`Onboarding`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Sensoridentifier` | `String` | Optional | the IEEE EUI64 address space used to identify a device. It is supplied by the device manufacturer | String getSensoridentifier() | setSensoridentifier(String sensoridentifier) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

