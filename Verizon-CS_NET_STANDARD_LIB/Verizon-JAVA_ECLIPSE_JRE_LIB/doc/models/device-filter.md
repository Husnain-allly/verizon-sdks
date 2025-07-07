
# Device Filter

Specify the kind of the device identifier, the type of match, and the string that you want to match.

*This model accepts additional fields of type Object.*

## Structure

`DeviceFilter`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Account` | `String` | Optional | The the billing account that the devices belong to. | String getAccount() | setAccount(String account) |
| `GroupName` | `String` | Optional | Only include devices that are in this device group. | String getGroupName() | setGroupName(String groupName) |
| `ServicePlan` | `String` | Optional | Only include devices that have this service plan. | String getServicePlan() | setServicePlan(String servicePlan) |
| `CustomFields` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Custom field names and values, if you want to only include devices that have matching values. | List<CustomFields> getCustomFields() | setCustomFields(List<CustomFields> customFields) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "groupName": "Short-Haul Trucks",
  "customFields": [
    {
      "key": "CustomField1",
      "value": "East Region Trucks",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "account": "account8",
  "servicePlan": "servicePlan2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

