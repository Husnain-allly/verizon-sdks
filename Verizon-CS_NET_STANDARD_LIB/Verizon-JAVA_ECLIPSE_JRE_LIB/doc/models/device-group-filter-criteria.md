
# Device Group Filter Criteria

*This model accepts additional fields of type Object.*

## Structure

`DeviceGroupFilterCriteria`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `FilterCriteria` | [`DeviceGroupFilter`](../../doc/models/device-group-filter.md) | Optional | - | DeviceGroupFilter getFilterCriteria() | setFilterCriteria(DeviceGroupFilter filterCriteria) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "filterCriteria": {
    "deviceGroupName": "deviceGroupName4",
    "IndividualOrCombined": "IndividualOrCombined4",
    "accountName": "accountName0",
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

