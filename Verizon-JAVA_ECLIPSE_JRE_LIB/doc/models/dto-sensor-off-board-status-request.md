
# Dto Sensor Off Board Status Request

## Structure

`DtoSensorOffBoardStatusRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Accountname` | `String` | Optional | The numeric account name, which must include leading zeros | String getAccountname() | setAccountname(String accountname) |
| `Gatewayidentifier` | [`Gatewayidentifier`](../../doc/models/gatewayidentifier.md) | Optional | - | Gatewayidentifier getGatewayidentifier() | setGatewayidentifier(Gatewayidentifier gatewayidentifier) |
| `Offboarding` | [`Offboarding`](../../doc/models/offboarding.md) | Optional | - | Offboarding getOffboarding() | setOffboarding(Offboarding offboarding) |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "gatewayidentifier": {
    "deviceid": "deviceid0",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "offboarding": {
    "sensoridentifier": "sensoridentifier8",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

