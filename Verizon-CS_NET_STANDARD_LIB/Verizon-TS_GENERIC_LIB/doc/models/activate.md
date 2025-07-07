
# Activate

*This model accepts additional fields of type unknown.*

## Structure

`Activate`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `profile` | `string` | Required | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "profile": "HSS EsmProfile Enterprise 5G",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

