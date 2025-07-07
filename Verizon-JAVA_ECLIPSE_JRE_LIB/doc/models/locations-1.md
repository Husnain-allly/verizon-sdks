
# Locations 1

*This model accepts additional fields of type Object.*

## Structure

`Locations1`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `CoordinatesList` | [`List<Coordinates>`](../../doc/models/coordinates.md) | Optional | - | List<Coordinates> getCoordinatesList() | setCoordinatesList(List<Coordinates> coordinatesList) |
| `AddressList` | [`List<AddressItem>`](../../doc/models/address-item.md) | Optional | **Constraints**: *Maximum Items*: `100` | List<AddressItem> getAddressList() | setAddressList(List<AddressItem> addressList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "coordinatesList": [
    {
      "latitude": "latitude6",
      "longitude": "longitude4"
    },
    {
      "latitude": "latitude6",
      "longitude": "longitude4"
    },
    {
      "latitude": "latitude6",
      "longitude": "longitude4"
    }
  ],
  "addressList": [
    {
      "addressLine1": "addressLine10",
      "addressLine2": "addressLine28",
      "city": "city8",
      "state": "state4",
      "country": "country2"
    },
    {
      "addressLine1": "addressLine10",
      "addressLine2": "addressLine28",
      "city": "city8",
      "state": "state4",
      "country": "country2"
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

