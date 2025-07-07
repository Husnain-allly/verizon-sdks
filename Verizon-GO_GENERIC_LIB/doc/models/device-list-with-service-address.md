
# Device List With Service Address

*This model accepts additional fields of type interface{}.*

## Structure

`DeviceListWithServiceAddress`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DeviceId` | [`[]models.M5GBideviceId1`](../../doc/models/m-5g-bidevice-id-1.md) | Optional | - |
| `PrimaryPlaceofuse` | [`*models.M5GBiaddressAndcustomerinfo`](../../doc/models/m-5g-biaddress-andcustomerinfo.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

