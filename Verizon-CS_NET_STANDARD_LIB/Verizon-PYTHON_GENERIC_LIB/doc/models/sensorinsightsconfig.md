
# Sensorinsightsconfig

The configuration of the remove request

*This model accepts additional fields of type Any.*

## Structure

`Sensorinsightsconfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `removesensor` | [`DtoOffBoardSensor`](../../doc/models/dto-off-board-sensor.md) | Optional | The EUI64 address of the device being removed |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "removesensor": {
    "deveui": "deveui6"
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

