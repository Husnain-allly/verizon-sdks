
# Dto Sensor on Board Status Request

## Structure

`DtoSensorOnBoardStatusRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountname` | `string \| undefined` | Optional | The numeric account name, which must include leading zeros |
| `gatewayidentifier` | [`Gatewayidentifier \| undefined`](../../doc/models/gatewayidentifier.md) | Optional | - |
| `onboarding` | [`Onboarding \| undefined`](../../doc/models/onboarding.md) | Optional | - |

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
  "onboarding": {
    "sensoridentifier": "sensoridentifier4",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

