
# Billedusage List Request

Information required to associate a usage segmentation label with a device to retrieve billing.

*This model accepts additional fields of type array.*

## Structure

`BilledusageListRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | - | getAccountName(): string | setAccountName(string accountName): void |
| `labels` | [`?LabelsList`](../../doc/models/labels-list.md) | Optional | - | getLabels(): ?LabelsList | setLabels(?LabelsList labels): void |
| `deviceIds` | [`?(DeviceList[])`](../../doc/models/device-list.md) | Optional | - | getDeviceIds(): ?array | setDeviceIds(?array deviceIds): void |
| `billingCycle` | [`?BillingCycle`](../../doc/models/billing-cycle.md) | Optional | - | getBillingCycle(): ?BillingCycle | setBillingCycle(?BillingCycle billingCycle): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

