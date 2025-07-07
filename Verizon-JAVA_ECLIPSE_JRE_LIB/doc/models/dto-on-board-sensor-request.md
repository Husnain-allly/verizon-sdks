
# Dto on Board Sensor Request

## Structure

`DtoOnBoardSensorRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountname` | `String` | Optional | The numeric account name, which must include leading zeros | String getAccountname() | setAccountname(String accountname) |
| `Payload` | [`Payload`](../../doc/models/payload.md) | Optional | - | Payload getPayload() | setPayload(Payload payload) |

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

