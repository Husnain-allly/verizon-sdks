
# Dto on Board Sensor Request

## Structure

`DtoOnBoardSensorRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountname` | `str` | Optional | The numeric account name, which must include leading zeros |
| `payload` | [`Payload`](../../doc/models/payload.md) | Optional | - |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "payload": {
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
}
```

