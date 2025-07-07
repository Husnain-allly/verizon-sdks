
# Device List With Service Address

*This model accepts additional fields of type Object.*

## Structure

`DeviceListWithServiceAddress`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceId` | [`List<M5GBideviceId1>`](../../doc/models/m-5g-bidevice-id-1.md) | Optional | - | List<M5GBideviceId1> getDeviceId() | setDeviceId(List<M5GBideviceId1> deviceId) |
| `PrimaryPlaceofuse` | [`M5GBiaddressAndcustomerinfo`](../../doc/models/m-5g-biaddress-andcustomerinfo.md) | Optional | - | M5GBiaddressAndcustomerinfo getPrimaryPlaceofuse() | setPrimaryPlaceofuse(M5GBiaddressAndcustomerinfo primaryPlaceofuse) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "deviceId": [
    {
      "id": "id0",
      "kind": "kind8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "primaryPlaceofuse": {
    "primaryPlaceofuse": {
      "address": {
        "addressLine1": "addressLine18",
        "city": "city6",
        "state": "state2",
        "zip": "zip0",
        "zip+4": "zip+48",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "customerName": {
        "firstName": "firstName4",
        "lastName": "lastName4",
        "middleName": "middleName8",
        "title": "title4",
        "suffex": "suffex4",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

