
# M 5G Bichange Request

*This model accepts additional fields of type array.*

## Structure

`M5GBichangeRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | - | getAccountName(): ?string | setAccountName(?string accountName): void |
| `servicePlan` | `?string` | Optional | - | getServicePlan(): ?string | setServicePlan(?string servicePlan): void |
| `deviceListWithServiceAddress` | [`?(DeviceListWithServiceAddress[])`](../../doc/models/device-list-with-service-address.md) | Optional | - | getDeviceListWithServiceAddress(): ?array | setDeviceListWithServiceAddress(?array deviceListWithServiceAddress): void |
| `currentServicePlan` | `?string` | Optional | - | getCurrentServicePlan(): ?string | setCurrentServicePlan(?string currentServicePlan): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0000123456-00001",
  "servicePlan": "5G BI service plan name being changed to",
  "currentServicePlan": "Name of the plan being changed from",
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
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

