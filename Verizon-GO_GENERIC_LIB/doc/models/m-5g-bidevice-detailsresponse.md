
# M 5G Bidevice Detailsresponse

*This model accepts additional fields of type interface{}.*

## Structure

`M5GBideviceDetailsresponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HasMoreData` | `*bool` | Optional | - |
| `Devices` | [`[]models.M5GBiaccountNameobject`](../../doc/models/m-5g-biaccount-nameobject.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "hasMoreData": false,
  "devices": [
    {
      "accountName": "accountName8",
      "billingCycleEndDate": "billingCycleEndDate4",
      "carrierInformation": [
        {
          "carrierName": "carrierName4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "carrierName": "carrierName4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "connected": false,
      "createdAt": "createdAt8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "accountName": "accountName8",
      "billingCycleEndDate": "billingCycleEndDate4",
      "carrierInformation": [
        {
          "carrierName": "carrierName4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "carrierName": "carrierName4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "connected": false,
      "createdAt": "createdAt8",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "accountName": "accountName8",
      "billingCycleEndDate": "billingCycleEndDate4",
      "carrierInformation": [
        {
          "carrierName": "carrierName4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "carrierName": "carrierName4",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "connected": false,
      "createdAt": "createdAt8",
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

