
# Device Group Object

*This model accepts additional fields of type unknown.*

## Structure

`DeviceGroupObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `deviceGroup` | [`DeviceGroupFilterCriteria \| undefined`](../../doc/models/device-group-filter-criteria.md) | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "deviceGroup": {
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
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

