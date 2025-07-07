
# Account Share Filter Criteria 1

*This model accepts additional fields of type array.*

## Structure

`AccountShareFilterCriteria1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `carrierServicePlanCode` | `?string` | Optional | - | getCarrierServicePlanCode(): ?string | setCarrierServicePlanCode(?string carrierServicePlanCode): void |
| `accountNameList` | `?(string[])` | Optional | An array of account names | getAccountNameList(): ?array | setAccountNameList(?array accountNameList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "carrierServicePlanCode": "Service plan code value",
  "accountNameList": [
    "accountNameList7",
    "accountNameList8"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

