
# Cellphonenumber

*This model accepts additional fields of type unknown.*

## Structure

`Cellphonenumber`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `number` | `string \| undefined` | Optional | - |
| `carrier` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

