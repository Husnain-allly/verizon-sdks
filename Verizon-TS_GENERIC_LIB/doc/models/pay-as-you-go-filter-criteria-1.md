
# Pay as You Go Filter Criteria 1

*This model accepts additional fields of type unknown.*

## Structure

`PayAsYouGoFilterCriteria1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `carrierServicePlanCode` | `string \| undefined` | Optional | - |
| `accountNameList` | `string[] \| undefined` | Optional | An array of account names |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

