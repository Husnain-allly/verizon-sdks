
# M 5G Biattribute 2

*This model accepts additional fields of type object.*

## Structure

`M5GBiattribute2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | `string` | Optional | - |
| `MValue` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "key": "PrimaryPlaceOfUseFirstName",
  "value": "string",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

