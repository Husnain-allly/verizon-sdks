
# Sensorinsightsconfig

The configuration of the remove request

*This model accepts additional fields of type Object.*

## Structure

`Sensorinsightsconfig`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Removesensor` | [`DtoOffBoardSensor`](../../doc/models/dto-off-board-sensor.md) | Optional | The EUI64 address of the device being removed | DtoOffBoardSensor getRemovesensor() | setRemovesensor(DtoOffBoardSensor removesensor) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

