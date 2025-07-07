
# Sensorinsightsconfig

The configuration of the remove request

*This model accepts additional fields of type array.*

## Structure

`Sensorinsightsconfig`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `removesensor` | [`?DtoOffBoardSensor`](../../doc/models/dto-off-board-sensor.md) | Optional | The EUI64 address of the device being removed | getRemovesensor(): ?DtoOffBoardSensor | setRemovesensor(?DtoOffBoardSensor removesensor): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

