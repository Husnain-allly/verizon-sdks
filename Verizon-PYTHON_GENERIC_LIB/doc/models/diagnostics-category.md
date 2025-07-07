
# Diagnostics Category

Various types of information about the device, grouped into categories. Each category object contains the category name and a list of Extended Attribute objects as key-value pairs.

*This model accepts additional fields of type Any.*

## Structure

`DiagnosticsCategory`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `category_name` | `str` | Optional | The name of the category. |
| `extended_attributes` | [`List[CustomFields]`](../../doc/models/custom-fields.md) | Optional | A list of Extended Attribute objects as key-value pairs. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "categoryName": "Connectivity",
  "extendedAttributes": [
    {
      "key": "Connected",
      "value": "false",
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

