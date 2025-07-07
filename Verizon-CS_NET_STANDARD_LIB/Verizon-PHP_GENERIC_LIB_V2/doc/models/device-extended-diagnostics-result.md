
# Device Extended Diagnostics Result

Result for a request to obtain device extended diagnostics.

*This model accepts additional fields of type array.*

## Structure

`DeviceExtendedDiagnosticsResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `categories` | [`?(DiagnosticsCategory[])`](../../doc/models/diagnostics-category.md) | Optional | The response includes various types of information about the device, grouped into categories. Each category object contains the category name and a list of Extended Attribute objects as key-value pairs. | getCategories(): ?array | setCategories(?array categories): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

