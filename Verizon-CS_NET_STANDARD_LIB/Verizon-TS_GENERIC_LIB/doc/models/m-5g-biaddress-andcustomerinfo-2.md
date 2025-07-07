
# M 5G Biaddress Andcustomerinfo 2

*This model accepts additional fields of type unknown.*

## Structure

`M5GBiaddressAndcustomerinfo2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `primaryPlaceofuse` | [`M5GBiaddressAndcustomerinfo \| undefined`](../../doc/models/m-5g-biaddress-andcustomerinfo.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "primaryPlaceofuse": {
    "address": {
      "addressLine1": "street number and name",
      "city": "city of the address",
      "state": "2-letter state ID (conforms to ISO 3166-2)",
      "zip": "5-digit zip code",
      "zip+4": "the +4 digits used for zip codes"
    },
    "customerName": {
      "firstNname": "First name",
      "lastName": "Surname or Last Name"
    },
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
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

