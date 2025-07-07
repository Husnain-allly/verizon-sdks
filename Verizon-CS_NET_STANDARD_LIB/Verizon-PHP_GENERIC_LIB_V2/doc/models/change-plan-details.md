
# Change Plan Details

The service plan code to switch to

*This model accepts additional fields of type array.*

## Structure

`ChangePlanDetails`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `toCarrierServicePlanCode` | `?string` | Optional | - | getToCarrierServicePlanCode(): ?string | setToCarrierServicePlanCode(?string toCarrierServicePlanCode): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "toCarrierServicePlanCode": "toCarrierServicePlanCode2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

