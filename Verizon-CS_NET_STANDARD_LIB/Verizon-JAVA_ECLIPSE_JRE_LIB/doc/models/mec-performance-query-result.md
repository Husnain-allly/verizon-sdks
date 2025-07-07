
# Mec Performance Query Result

Result of the query for obtaining MEC performance metrics.

*This model accepts additional fields of type Object.*

## Structure

`MecPerformanceQueryResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Name` | `String` | Optional | Name of the parameter. | String getName() | setName(String name) |
| `Data` | `List<String>` | Optional | Parameter values. | List<String> getData() | setData(List<String> data) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

