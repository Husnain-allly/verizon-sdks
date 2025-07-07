
# Cellphonenumber

*This model accepts additional fields of type object.*

## Structure

`Cellphonenumber`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Number` | `string` | Optional | - |
| `Carrier` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "number": "10-digit mobile number",
  "carrier": "mobile service provider",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

