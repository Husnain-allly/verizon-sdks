
# Pay as You Go Filter Criteria 1

*This model accepts additional fields of type array.*

## Structure

`PayAsYouGoFilterCriteria1`

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
    "accountNameList1",
    "accountNameList2"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

