
# Pay as You Go Filter Criteria

*This model accepts additional fields of type array.*

## Structure

`PayAsYouGoFilterCriteria`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `filterCriteria` | [`?PayAsYouGoFilterCriteria1`](../../doc/models/pay-as-you-go-filter-criteria-1.md) | Optional | - | getFilterCriteria(): ?PayAsYouGoFilterCriteria1 | setFilterCriteria(?PayAsYouGoFilterCriteria1 filterCriteria): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "filterCriteria": {
    "carrierServicePlanCode": "carrierServicePlanCode4",
    "accountNameList": [
      "accountNameList7",
      "accountNameList8"
    ],
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

