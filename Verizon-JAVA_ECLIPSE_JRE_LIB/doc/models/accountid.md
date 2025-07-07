
# Accountid

*This model accepts additional fields of type Object.*

## Structure

`Accountid`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | The numeric name of the account and must include leading zeroes | String getAccountName() | setAccountName(String accountName) |
| `MtasAccountNumber` | `String` | Optional | - | String getMtasAccountNumber() | setMtasAccountNumber(String mtasAccountNumber) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "mtasAccountNumber": "0000123456-00001",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

