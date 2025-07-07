
# Billedusage List Request

Information required to associate a usage segmentation label with a device to retrieve billing.

*This model accepts additional fields of type interface{}.*

## Structure

`BilledusageListRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `string` | Required | - |
| `Labels` | [`*models.LabelsList`](../../doc/models/labels-list.md) | Optional | - |
| `DeviceIds` | [`[]models.DeviceList`](../../doc/models/device-list.md) | Optional | - |
| `BillingCycle` | [`*models.BillingCycle`](../../doc/models/billing-cycle.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

