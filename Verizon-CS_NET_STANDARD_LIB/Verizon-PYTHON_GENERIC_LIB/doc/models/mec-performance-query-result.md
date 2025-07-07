
# Mec Performance Query Result

Result of the query for obtaining MEC performance metrics.

*This model accepts additional fields of type Any.*

## Structure

`MecPerformanceQueryResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `str` | Optional | Name of the parameter. |
| `data` | `List[str]` | Optional | Parameter values. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

