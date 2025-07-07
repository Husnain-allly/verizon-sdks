
# Edge Discovery Result Data

For cases where user input exceeds the boundary values an additional 'data' key will be returned with a relevant description.

*This model accepts additional fields of type Any.*

## Structure

`EdgeDiscoveryResultData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `additional_message` | `str` | Optional | **Constraints**: *Maximum Length*: `32` |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "additionalMessage": "additionalMessage2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

