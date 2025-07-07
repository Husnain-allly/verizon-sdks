
# Device Suspension Status Request

Request to return service suspension information about one or more devices.

*This model accepts additional fields of type Object.*

## Structure

`DeviceSuspensionStatusRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `DeviceIds` | [`List<DeviceId>`](../../doc/models/device-id.md) | Optional | The devices that you want to include in the request, specified by device identifier. You only need to provide one identifier per device. | List<DeviceId> getDeviceIds() | setDeviceIds(List<DeviceId> deviceIds) |
| `Filter` | [`DeviceFilterWithoutAccount`](../../doc/models/device-filter-without-account.md) | Optional | Filter for devices without account. | DeviceFilterWithoutAccount getFilter() | setFilter(DeviceFilterWithoutAccount filter) |
| `AccountName` | `String` | Optional | The name of a billing account. | String getAccountName() | setAccountName(String accountName) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "filter": {
    "groupName": "suspended devices",
    "servicePlan": "servicePlan6",
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
  },
  "accountName": "1223334444-00001",
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
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

