
# Condition

*This model accepts additional fields of type object.*

## Structure

`Condition`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Condition` | [`List<Keyschunk2>`](../../doc/models/keyschunk-2.md) | Optional | - |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "condition": [
    {
      "dataPercentage50": false,
      "dataPercentage75": false,
      "dataPercentage90": false,
      "dataPercentage100": false,
      "smsPercentage50": false,
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

