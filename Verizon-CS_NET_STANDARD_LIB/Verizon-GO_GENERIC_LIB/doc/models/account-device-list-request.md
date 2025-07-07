
# Account Device List Request

Request for listing account devices.

*This model accepts additional fields of type interface{}.*

## Structure

`AccountDeviceListRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountName` | `*string` | Optional | The billing account for which a list of devices is returned. If you don't specify an accountName, the list includes all devices to which you have access. |
| `DeviceId` | [`*models.DeviceId`](../../doc/models/device-id.md) | Optional | An identifier for a single device. |
| `Filter` | [`*models.AccountDeviceListFilter`](../../doc/models/account-device-list-filter.md) | Optional | Filter for a list of devices. |
| `CurrentState` | `*string` | Optional | The name of a device state, to only include devices in that state. |
| `CustomFields` | [`[]models.CustomFields`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. |
| `Earliest` | `*string` | Optional | Only include devices that were added after this date and time. |
| `GroupName` | `*string` | Optional | Only include devices that are in this device group. |
| `Latest` | `*string` | Optional | Only include devices that were added before this date and time. |
| `ServicePlan` | `*string` | Optional | Only include devices that have this service plan. |
| `MaxNumberOfDevices` | `*int` | Optional | **Constraints**: `>= 0`, `<= 100` |
| `LargestDeviceIdSeen` | `*int64` | Optional | **Constraints**: `>= 0`, `<= 100` |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "accountName": "0786890242-00001",
  "filter": {
    "deviceIdentifierFilters": [
      {
        "kind": "iccid",
        "contains": "4259",
        "startswith": "startswith8",
        "endswith": "endswith0",
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
  },
  "deviceId": null,
  "currentState": "currentState0",
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
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

