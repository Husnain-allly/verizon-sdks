
# Service Plan Update Request

Request to update service plan.

*This model accepts additional fields of type interface{}.*

## Structure

`ServicePlanUpdateRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServicePlan` | `string` | Required | The service plan code that you want to assign to all specified devices. |
| `AccountName` | `*string` | Optional | The name of a billing account. |
| `CurrentServicePlan` | `*string` | Optional | The name of a service plan, if you want to only include devices that have that service plan. |
| `CustomFields` | [`[]models.CustomFields`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. |
| `Devices` | [`[]models.AccountDeviceList`](../../doc/models/account-device-list.md) | Optional | A list of the devices that you want to change, specified by device identifier. |
| `GroupName` | `*string` | Optional | The name of a device group, if you want to restore service for all devices in that group. |
| `CarrierIpPoolName` | `*string` | Optional | **Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `TakeEffect` | `*time.Time` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "devices": [
    {
      "deviceIds": [
        {
          "id": "A100003685E561",
          "kind": "meid",
          "exampleAdditionalProperty": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      ],
      "ipAddress": "ipAddress4",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "servicePlan": "new_service_plan_code",
  "accountName": "accountName4",
  "currentServicePlan": "currentServicePlan6",
  "customFields": [
    {
      "key": "key0",
      "value": "value2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "key": "key0",
      "value": "value2",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "groupName": "groupName0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

