
# Dto Off Board Sensor Request

## Structure

`DtoOffBoardSensorRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `configuration` | [`?Sensorinsightsconfig`](../../doc/models/sensorinsightsconfig.md) | Optional | The configuration of the remove request | getConfiguration(): ?Sensorinsightsconfig | setConfiguration(?Sensorinsightsconfig configuration): void |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "configuration": {
    "removesensor": {
      "deveui": "deveui6"
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

