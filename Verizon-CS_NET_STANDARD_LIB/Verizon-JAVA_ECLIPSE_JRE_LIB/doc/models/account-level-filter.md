
# Account Level Filter

*This model accepts additional fields of type Object.*

## Structure

`AccountLevelFilter`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `SeparateOrCombined` | `String` | Optional | Determines whether or not to aggregate usage of multiple accounts together, or separate by account. If this is null or not present, then the trigger will be for an individual line. | String getSeparateOrCombined() | setSeparateOrCombined(String separateOrCombined) |
| `AccountNames` | [`Accountnames`](../../doc/models/accountnames.md) | Optional | - | Accountnames getAccountNames() | setAccountNames(Accountnames accountNames) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

