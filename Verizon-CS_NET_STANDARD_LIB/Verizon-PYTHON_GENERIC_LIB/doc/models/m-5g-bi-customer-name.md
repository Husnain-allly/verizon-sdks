
# M 5G Bi Customer Name

*This model accepts additional fields of type Any.*

## Structure

`M5GBiCustomerName`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `first_name` | `str` | Optional | - |
| `last_name` | `str` | Optional | - |
| `middle_name` | `str` | Optional | - |
| `title` | `str` | Optional | - |
| `suffex` | `str` | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

