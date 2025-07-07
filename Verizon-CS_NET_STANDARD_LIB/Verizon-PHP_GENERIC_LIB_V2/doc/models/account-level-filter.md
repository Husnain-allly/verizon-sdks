
# Account Level Filter

*This model accepts additional fields of type array.*

## Structure

`AccountLevelFilter`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `separateOrCombined` | `?string` | Optional | Determines whether or not to aggregate usage of multiple accounts together, or separate by account. If this is null or not present, then the trigger will be for an individual line. | getSeparateOrCombined(): ?string | setSeparateOrCombined(?string separateOrCombined): void |
| `accountNames` | [`?Accountnames`](../../doc/models/accountnames.md) | Optional | - | getAccountNames(): ?Accountnames | setAccountNames(?Accountnames accountNames): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

