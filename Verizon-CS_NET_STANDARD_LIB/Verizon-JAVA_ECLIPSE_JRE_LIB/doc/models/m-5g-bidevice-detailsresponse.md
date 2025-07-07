
# M 5G Bidevice Detailsresponse

*This model accepts additional fields of type Object.*

## Structure

`M5GBideviceDetailsresponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `HasMoreData` | `Boolean` | Optional | - | Boolean getHasMoreData() | setHasMoreData(Boolean hasMoreData) |
| `Devices` | [`List<M5GBiaccountNameobject>`](../../doc/models/m-5g-biaccount-nameobject.md) | Optional | - | List<M5GBiaccountNameobject> getDevices() | setDevices(List<M5GBiaccountNameobject> devices) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

