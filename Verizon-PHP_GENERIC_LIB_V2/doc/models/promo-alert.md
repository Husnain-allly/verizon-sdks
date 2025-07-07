
# Promo Alert

*This model accepts additional fields of type array.*

## Structure

`PromoAlert`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `filterCriteria` | [`?(ReadySimServicePlan[])`](../../doc/models/ready-sim-service-plan.md) | Optional | - | getFilterCriteria(): ?array | setFilterCriteria(?array filterCriteria): void |
| `condition` | [`?(Keyschunk2[])`](../../doc/models/keyschunk-2.md) | Optional | - | getCondition(): ?array | setCondition(?array condition): void |
| `enablePromoExp` | `?bool` | Optional | - | getEnablePromoExp(): ?bool | setEnablePromoExp(?bool enablePromoExp): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "enablePromoExp": true,
  "filterCriteria": [
    {
      "servicePlan": "servicePlan4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "servicePlan": "servicePlan4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "condition": [
    {
      "dataPercentage50": false,
      "dataPercentage75": false,
      "dataPercentage90": false,
      "dataPercentage100": false,
      "smsPercentage50": false,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "dataPercentage50": false,
      "dataPercentage75": false,
      "dataPercentage90": false,
      "dataPercentage100": false,
      "smsPercentage50": false,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "dataPercentage50": false,
      "dataPercentage75": false,
      "dataPercentage90": false,
      "dataPercentage100": false,
      "smsPercentage50": false,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

