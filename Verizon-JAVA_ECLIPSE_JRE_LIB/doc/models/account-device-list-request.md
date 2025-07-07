
# Account Device List Request

Request for listing account devices.

*This model accepts additional fields of type Object.*

## Structure

`AccountDeviceListRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountName` | `String` | Optional | The billing account for which a list of devices is returned. If you don't specify an accountName, the list includes all devices to which you have access. | String getAccountName() | setAccountName(String accountName) |
| `DeviceId` | [`DeviceId`](../../doc/models/device-id.md) | Optional | An identifier for a single device. | DeviceId getDeviceId() | setDeviceId(DeviceId deviceId) |
| `Filter` | [`AccountDeviceListFilter`](../../doc/models/account-device-list-filter.md) | Optional | Filter for a list of devices. | AccountDeviceListFilter getFilter() | setFilter(AccountDeviceListFilter filter) |
| `CurrentState` | `String` | Optional | The name of a device state, to only include devices in that state. | String getCurrentState() | setCurrentState(String currentState) |
| `CustomFields` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. | List<CustomFields> getCustomFields() | setCustomFields(List<CustomFields> customFields) |
| `Earliest` | `String` | Optional | Only include devices that were added after this date and time. | String getEarliest() | setEarliest(String earliest) |
| `GroupName` | `String` | Optional | Only include devices that are in this device group. | String getGroupName() | setGroupName(String groupName) |
| `Latest` | `String` | Optional | Only include devices that were added before this date and time. | String getLatest() | setLatest(String latest) |
| `ServicePlan` | `String` | Optional | Only include devices that have this service plan. | String getServicePlan() | setServicePlan(String servicePlan) |
| `MaxNumberOfDevices` | `Integer` | Optional | **Constraints**: `>= 0`, `<= 100` | Integer getMaxNumberOfDevices() | setMaxNumberOfDevices(Integer maxNumberOfDevices) |
| `LargestDeviceIdSeen` | `Long` | Optional | **Constraints**: `>= 0`, `<= 100` | Long getLargestDeviceIdSeen() | setLargestDeviceIdSeen(Long largestDeviceIdSeen) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

