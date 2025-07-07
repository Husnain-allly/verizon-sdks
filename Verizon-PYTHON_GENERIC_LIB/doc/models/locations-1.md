
# Locations 1

*This model accepts additional fields of type Any.*

## Structure

`Locations1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `coordinates_list` | [`List[Coordinates]`](../../doc/models/coordinates.md) | Optional | - |
| `address_list` | [`List[AddressItem]`](../../doc/models/address-item.md) | Optional | **Constraints**: *Maximum Items*: `100` |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

