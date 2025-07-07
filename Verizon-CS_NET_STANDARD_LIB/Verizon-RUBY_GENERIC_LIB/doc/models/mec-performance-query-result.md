
# Mec Performance Query Result

Result of the query for obtaining MEC performance metrics.

*This model accepts additional fields of type Object.*

## Structure

`MecPerformanceQueryResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `String` | Optional | Name of the parameter. |
| `data` | `Array<String>` | Optional | Parameter values. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

