
# Pay as You Go Filter Criteria 1

*This model accepts additional fields of type interface{}.*

## Structure

`PayAsYouGoFilterCriteria1`

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
    "accountNameList1",
    "accountNameList2"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

