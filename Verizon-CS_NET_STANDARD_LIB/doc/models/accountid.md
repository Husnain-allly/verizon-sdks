
# Accountid

*This model accepts additional fields of type object.*

## Structure

`Accountid`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Optional | The numeric name of the account and must include leading zeroes |
| `MtasAccountNumber` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

