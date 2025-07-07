
# Billing Cycle

*This model accepts additional fields of type unknown.*

## Structure

`BillingCycle`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `year` | `string \| undefined` | Optional | - |
| `month` | `string \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

