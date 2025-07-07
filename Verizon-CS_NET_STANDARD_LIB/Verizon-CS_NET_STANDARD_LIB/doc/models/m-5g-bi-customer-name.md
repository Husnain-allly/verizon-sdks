
# M 5G Bi Customer Name

*This model accepts additional fields of type object.*

## Structure

`M5GBiCustomerName`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FirstName` | `string` | Optional | - |
| `LastName` | `string` | Optional | - |
| `MiddleName` | `string` | Optional | - |
| `Title` | `string` | Optional | - |
| `Suffex` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "firstName": "First name",
  "lastName": "Surname or Last Name",
  "middleName": "middle name or initial",
  "title": "Mr. or Ms.",
  "suffex": "Dr or Esq",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

