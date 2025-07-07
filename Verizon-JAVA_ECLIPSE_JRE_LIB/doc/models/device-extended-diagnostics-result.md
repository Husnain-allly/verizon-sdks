
# Device Extended Diagnostics Result

Result for a request to obtain device extended diagnostics.

*This model accepts additional fields of type Object.*

## Structure

`DeviceExtendedDiagnosticsResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Categories` | [`List<DiagnosticsCategory>`](../../doc/models/diagnostics-category.md) | Optional | The response includes various types of information about the device, grouped into categories. Each category object contains the category name and a list of Extended Attribute objects as key-value pairs. | List<DiagnosticsCategory> getCategories() | setCategories(List<DiagnosticsCategory> categories) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "categories": [
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
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

