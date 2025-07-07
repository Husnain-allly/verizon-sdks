
# Account Share Filter Criteria 1

*This model accepts additional fields of type Object.*

## Structure

`AccountShareFilterCriteria1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `CarrierServicePlanCode` | `String` | Optional | - | String getCarrierServicePlanCode() | setCarrierServicePlanCode(String carrierServicePlanCode) |
| `AccountNameList` | `List<String>` | Optional | An array of account names | List<String> getAccountNameList() | setAccountNameList(List<String> accountNameList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

