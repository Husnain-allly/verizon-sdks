
# Accountnames

*This model accepts additional fields of type array.*

## Structure

`Accountnames`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountNameList` | `?(string[])` | Optional | - | getAccountNameList(): ?array | setAccountNameList(?array accountNameList): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountNameList": [
    "accountNameList1",
    "accountNameList2",
    "accountNameList3"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

