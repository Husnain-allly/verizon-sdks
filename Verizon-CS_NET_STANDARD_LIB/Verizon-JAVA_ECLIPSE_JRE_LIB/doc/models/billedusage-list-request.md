
# Billedusage List Request

Information required to associate a usage segmentation label with a device to retrieve billing.

*This model accepts additional fields of type Object.*

## Structure

`BilledusageListRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Required | - | String getAccountName() | setAccountName(String accountName) |
| `Labels` | [`LabelsList`](../../doc/models/labels-list.md) | Optional | - | LabelsList getLabels() | setLabels(LabelsList labels) |
| `DeviceIds` | [`List<DeviceList>`](../../doc/models/device-list.md) | Optional | - | List<DeviceList> getDeviceIds() | setDeviceIds(List<DeviceList> deviceIds) |
| `BillingCycle` | [`BillingCycle`](../../doc/models/billing-cycle.md) | Optional | - | BillingCycle getBillingCycle() | setBillingCycle(BillingCycle billingCycle) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "accountName": "9231221278-99990",
  "labels": {
    "deviceIds": [
      {
        "name": "name0",
        "value": "value2",
        "exampleAdditionalProperty": {
          "key1": "val1",
          "key2": "val2"
        }
      }
    ]
  },
  "deviceIds": [
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "id": "id0",
          "kind": "kind8",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    },
    {
      "deviceIds": [
        {
          "id": "id0",
          "kind": "kind8",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        },
        {
          "id": "id0",
          "kind": "kind8",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ]
    }
  ],
  "billingCycle": {
    "year": "year6",
    "month": "month4",
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

