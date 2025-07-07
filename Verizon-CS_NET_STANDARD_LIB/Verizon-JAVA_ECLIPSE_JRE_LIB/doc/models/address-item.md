
# Address Item

Address details.

## Structure

`AddressItem`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AddressLine1` | `String` | Optional | Street Address.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ,]{3,32}$` | String getAddressLine1() | setAddressLine1(String addressLine1) |
| `AddressLine2` | `String` | Optional | Optional address information.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ,]{3,32}$` | String getAddressLine2() | setAddressLine2(String addressLine2) |
| `City` | `String` | Optional | Name of the city.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9 ]{3,32}$` | String getCity() | setCity(String city) |
| `State` | `String` | Optional | State code.<br><br>**Constraints**: *Minimum Length*: `2`, *Maximum Length*: `3`, *Pattern*: `^[A-Za-z]{2,3}$` | String getState() | setState(String state) |
| `Country` | `String` | Optional | Country.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `3`, *Pattern*: `^[A-Za-z]{3,3}$` | String getCountry() | setCountry(String country) |
| `Zip` | `String` | Optional | Five digit zipcode.<br><br>**Constraints**: *Minimum Length*: `5`, *Maximum Length*: `5`, *Pattern*: `^[0-9]{5,5}$` | String getZip() | setZip(String zip) |
| `Zip4` | `String` | Optional | Four digit zip code.<br><br>**Constraints**: *Minimum Length*: `4`, *Maximum Length*: `4`, *Pattern*: `^[0-9]{4,4}$` | String getZip4() | setZip4(String zip4) |

## Example (as JSON)

```json
{
  "addressLine1": "street number and name",
  "addressLine2": "optional address information",
  "city": "name of the city",
  "state": "NY",
  "country": "USA",
  "zip": "10001",
  "zip4": "0727"
}
```

