
# Device Filter Without Account

Filter for devices without account.

*This model accepts additional fields of type Object.*

## Structure

`DeviceFilterWithoutAccount`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `GroupName` | `String` | Optional | Only include devices that are in this device group. | String getGroupName() | setGroupName(String groupName) |
| `ServicePlan` | `String` | Optional | Only include devices that have this service plan. | String getServicePlan() | setServicePlan(String servicePlan) |
| `CustomFields` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. | List<CustomFields> getCustomFields() | setCustomFields(List<CustomFields> customFields) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "groupName": "suspended devices",
  "servicePlan": "servicePlan4",
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

