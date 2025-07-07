
# Accountnames

*This model accepts additional fields of type unknown.*

## Structure

`Accountnames`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountNameList` | `string[] \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

