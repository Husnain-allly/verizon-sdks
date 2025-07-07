
# M 5G Bi Customer Name

*This model accepts additional fields of type Object.*

## Structure

`M5GBiCustomerName`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FirstName` | `String` | Optional | - | String getFirstName() | setFirstName(String firstName) |
| `LastName` | `String` | Optional | - | String getLastName() | setLastName(String lastName) |
| `MiddleName` | `String` | Optional | - | String getMiddleName() | setMiddleName(String middleName) |
| `Title` | `String` | Optional | - | String getTitle() | setTitle(String title) |
| `Suffex` | `String` | Optional | - | String getSuffex() | setSuffex(String suffex) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

