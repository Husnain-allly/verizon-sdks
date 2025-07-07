
# Condition

*This model accepts additional fields of type Any.*

## Structure

`Condition`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `condition` | [`List[Keyschunk2]`](../../doc/models/keyschunk-2.md) | Optional | - |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

