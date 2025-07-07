
# Ready Sim Device Id

*This model accepts additional fields of type interface{}.*

## Structure

`ReadySimDeviceId`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | `*string` | Optional | - |
| `Id` | `*string` | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

