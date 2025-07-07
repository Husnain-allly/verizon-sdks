
# Device Group Filter Criteria

*This model accepts additional fields of type interface{}.*

## Structure

`DeviceGroupFilterCriteria`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FilterCriteria` | [`*models.DeviceGroupFilter`](../../doc/models/device-group-filter.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

