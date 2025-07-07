
# M 5G Biactivate Request

*This model accepts additional fields of type unknown.*

## Structure

`M5GBiactivateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountName` | `string \| undefined` | Optional | - |
| `servicePlan` | `string \| undefined` | Optional | - |
| `deviceListWithServiceAddress` | [`DeviceListWithServiceAddress1[] \| undefined`](../../doc/models/device-list-with-service-address-1.md) | Optional | - |
| `publicIpRestriction` | `string \| undefined` | Optional | - |
| `carrierName` | `string \| undefined` | Optional | - |
| `mdnZipCode` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

