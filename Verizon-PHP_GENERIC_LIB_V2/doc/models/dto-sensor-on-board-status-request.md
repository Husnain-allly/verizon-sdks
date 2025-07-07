
# Dto Sensor on Board Status Request

## Structure

`DtoSensorOnBoardStatusRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountname` | `?string` | Optional | The numeric account name, which must include leading zeros | getAccountname(): ?string | setAccountname(?string accountname): void |
| `gatewayidentifier` | [`?Gatewayidentifier`](../../doc/models/gatewayidentifier.md) | Optional | - | getGatewayidentifier(): ?Gatewayidentifier | setGatewayidentifier(?Gatewayidentifier gatewayidentifier): void |
| `onboarding` | [`?Onboarding`](../../doc/models/onboarding.md) | Optional | - | getOnboarding(): ?Onboarding | setOnboarding(?Onboarding onboarding): void |

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

