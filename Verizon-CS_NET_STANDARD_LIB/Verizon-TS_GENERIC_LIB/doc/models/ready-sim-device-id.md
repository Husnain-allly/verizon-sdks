
# Ready Sim Device Id

*This model accepts additional fields of type unknown.*

## Structure

`ReadySimDeviceId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `kind` | `string \| undefined` | Optional | - |
| `id` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "kind": "iccid",
  "id": "20-digit iccid",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

