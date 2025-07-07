
# Sensorinsightsconfig

The configuration of the remove request

*This model accepts additional fields of type interface{}.*

## Structure

`Sensorinsightsconfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Removesensor` | [`*models.DtoOffBoardSensor`](../../doc/models/dto-off-board-sensor.md) | Optional | The EUI64 address of the device being removed |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

