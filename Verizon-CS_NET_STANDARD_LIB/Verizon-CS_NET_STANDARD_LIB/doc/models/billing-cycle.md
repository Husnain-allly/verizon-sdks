
# Billing Cycle

*This model accepts additional fields of type object.*

## Structure

`BillingCycle`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Year` | `string` | Optional | - |
| `Month` | `string` | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "year": "2020",
  "month": "3",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

