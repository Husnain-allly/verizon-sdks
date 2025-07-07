
# Custom Fields

Custom data that can be included using key-value pairs.

*This model accepts additional fields of type array.*

## Structure

`CustomFields`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `key` | `string` | Required | The key for an extended attribute. | getKey(): string | setKey(string key): void |
| `value` | `string` | Required | The value of an extended attribute. | getValue(): string | setValue(string value): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "key": "CustomField2",
  "value": "SuperVend",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

