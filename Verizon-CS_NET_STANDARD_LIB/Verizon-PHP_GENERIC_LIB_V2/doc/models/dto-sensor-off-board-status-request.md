
# Dto Sensor Off Board Status Request

## Structure

`DtoSensorOffBoardStatusRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `gatewayidentifier` | [`?Gatewayidentifier`](../../doc/models/gatewayidentifier.md) | Optional | - | getGatewayidentifier(): ?Gatewayidentifier | setGatewayidentifier(?Gatewayidentifier gatewayidentifier): void |
| `offboarding` | [`?Offboarding`](../../doc/models/offboarding.md) | Optional | - | getOffboarding(): ?Offboarding | setOffboarding(?Offboarding offboarding): void |

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

