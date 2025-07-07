
# Account Share Filter Criteria 1

*This model accepts additional fields of type interface{}.*

## Structure

`AccountShareFilterCriteria1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CarrierServicePlanCode` | `*string` | Optional | - |
| `AccountNameList` | `[]string` | Optional | An array of account names |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

