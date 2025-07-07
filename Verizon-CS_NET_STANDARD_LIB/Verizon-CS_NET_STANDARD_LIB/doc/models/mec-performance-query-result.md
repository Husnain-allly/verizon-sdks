
# Mec Performance Query Result

Result of the query for obtaining MEC performance metrics.

*This model accepts additional fields of type object.*

## Structure

`MecPerformanceQueryResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | Name of the parameter. |
| `Data` | `List<string>` | Optional | Parameter values. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "name": "NetworkAvailability",
  "data": [
    "100",
    "percent",
    "high"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

