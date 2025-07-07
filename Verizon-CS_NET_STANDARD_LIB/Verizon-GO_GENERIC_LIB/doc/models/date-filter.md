
# Date Filter

Filter out the dates.

*This model accepts additional fields of type interface{}.*

## Structure

`DateFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Earliest` | `string` | Required | Only include devices that were added after this date and time. |
| `Latest` | `string` | Required | Only include devices that were added before this date and time. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "earliest": "2020-05-01T15:00:00-08:00Z",
  "latest": "2020-07-30T15:00:00-08:00Z",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

