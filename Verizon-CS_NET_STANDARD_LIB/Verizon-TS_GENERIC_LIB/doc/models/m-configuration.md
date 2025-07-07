
# M Configuration

List of the field names and values to set.

*This model accepts additional fields of type unknown.*

## Structure

`MConfiguration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `frequency` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "frequency": "Low",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

