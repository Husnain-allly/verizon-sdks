
# Payload

*This model accepts additional fields of type array.*

## Structure

`Payload`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `addsensor` | [`?ResourceOnBoardSensor`](../../doc/models/resource-on-board-sensor.md) | Optional | - | getAddsensor(): ?ResourceOnBoardSensor | setAddsensor(?ResourceOnBoardSensor addsensor): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "addsensor": {
    "deveui": "deveui6",
    "appeui": "appeui0",
    "appkey": "appkey0",
    "class": "class4",
    "kind": "kind8",
    "description": "description0",
    "name": "name0",
    "customdata": {
      "key0": {
        "key1": "val1",
        "key2": "val2"
      },
      "key1": {
        "key1": "val1",
        "key2": "val2"
      },
      "key2": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

