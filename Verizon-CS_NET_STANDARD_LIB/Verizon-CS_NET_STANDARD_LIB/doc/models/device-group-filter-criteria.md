
# Device Group Filter Criteria

*This model accepts additional fields of type object.*

## Structure

`DeviceGroupFilterCriteria`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FilterCriteria` | [`DeviceGroupFilter`](../../doc/models/device-group-filter.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

