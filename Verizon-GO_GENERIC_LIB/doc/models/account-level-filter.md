
# Account Level Filter

*This model accepts additional fields of type interface{}.*

## Structure

`AccountLevelFilter`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SeparateOrCombined` | `*string` | Optional | Determines whether or not to aggregate usage of multiple accounts together, or separate by account. If this is null or not present, then the trigger will be for an individual line. |
| `AccountNames` | [`*models.Accountnames`](../../doc/models/accountnames.md) | Optional | - |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "separateOrCombined": "Separate",
  "accountNames": {
    "accountNameList": [
      "accountNameList7",
      "accountNameList8",
      "accountNameList9"
    ],
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

