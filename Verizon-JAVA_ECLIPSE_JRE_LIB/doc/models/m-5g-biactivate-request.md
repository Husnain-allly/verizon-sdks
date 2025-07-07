
# M 5G Biactivate Request

*This model accepts additional fields of type Object.*

## Structure

`M5GBiactivateRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | - | String getAccountName() | setAccountName(String accountName) |
| `ServicePlan` | `String` | Optional | - | String getServicePlan() | setServicePlan(String servicePlan) |
| `DeviceListWithServiceAddress` | [`List<DeviceListWithServiceAddress1>`](../../doc/models/device-list-with-service-address-1.md) | Optional | - | List<DeviceListWithServiceAddress1> getDeviceListWithServiceAddress() | setDeviceListWithServiceAddress(List<DeviceListWithServiceAddress1> deviceListWithServiceAddress) |
| `PublicIpRestriction` | `String` | Optional | - | String getPublicIpRestriction() | setPublicIpRestriction(String publicIpRestriction) |
| `CarrierName` | `String` | Optional | - | String getCarrierName() | setCarrierName(String carrierName) |
| `MdnZipCode` | `String` | Optional | - | String getMdnZipCode() | setMdnZipCode(String mdnZipCode) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "servicePlan": "service plan name",
  "publicIpRestriction": "Unrestricted",
  "carrierName": "Verizon Wireless",
  "mdnZipCode": "5-digit zip code",
  "deviceListWithServiceAddress": [
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
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

