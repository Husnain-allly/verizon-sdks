
# Accountnames

*This model accepts additional fields of type Object.*

## Structure

`Accountnames`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AccountNameList` | `List<String>` | Optional | - | List<String> getAccountNameList() | setAccountNameList(List<String> accountNameList) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

