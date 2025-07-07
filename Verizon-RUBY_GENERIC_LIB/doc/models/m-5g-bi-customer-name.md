
# M 5G Bi Customer Name

*This model accepts additional fields of type Object.*

## Structure

`M5GBiCustomerName`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `first_name` | `String` | Optional | - |
| `last_name` | `String` | Optional | - |
| `middle_name` | `String` | Optional | - |
| `title` | `String` | Optional | - |
| `suffex` | `String` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

