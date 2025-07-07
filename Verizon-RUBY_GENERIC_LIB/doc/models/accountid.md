
# Accountid

*This model accepts additional fields of type Object.*

## Structure

`Accountid`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `account_name` | `String` | Optional | The numeric name of the account and must include leading zeroes |
| `mtas_account_number` | `String` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

