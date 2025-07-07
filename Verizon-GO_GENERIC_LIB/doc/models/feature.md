
# Feature

*This model accepts additional fields of type interface{}.*

## Structure

`Feature`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Features` | `*string` | Optional | The calling and data features available for the account. **Note:** for Global IoT Orchestrator, the features `eUICC Verizon as Lead` and `Global eSim Billing` will always be present.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "features": "features4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

