
# Device Group

Returns a list of all device groups in a specified account.

*This model accepts additional fields of type Object.*

## Structure

`DeviceGroup`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Description` | `String` | Optional | The description of the device group. | String getDescription() | setDescription(String description) |
| `ExtendedAttributes` | [`List<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the device group, as Key and Value pairs. | List<CustomFields> getExtendedAttributes() | setExtendedAttributes(List<CustomFields> extendedAttributes) |
| `IsDefaultGroup` | `Boolean` | Optional | Identifies the default device group. | Boolean getIsDefaultGroup() | setIsDefaultGroup(Boolean isDefaultGroup) |
| `Name` | `String` | Optional | The name of the device group. | String getName() | setName(String name) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "name": "Unassigned Devices",
  "description": "All devices that are not in another device group.",
  "isDefaultGroup": true,
  "extendedAttributes": [],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

