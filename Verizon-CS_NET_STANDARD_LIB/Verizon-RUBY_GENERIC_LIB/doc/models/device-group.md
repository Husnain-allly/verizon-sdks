
# Device Group

Returns a list of all device groups in a specified account.

*This model accepts additional fields of type Object.*

## Structure

`DeviceGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `description` | `String` | Optional | The description of the device group. |
| `extended_attributes` | [`Array<CustomFields>`](../../doc/models/custom-fields.md) | Optional | Any extended attributes for the device group, as Key and Value pairs. |
| `is_default_group` | `TrueClass \| FalseClass` | Optional | Identifies the default device group. |
| `name` | `String` | Optional | The name of the device group. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

