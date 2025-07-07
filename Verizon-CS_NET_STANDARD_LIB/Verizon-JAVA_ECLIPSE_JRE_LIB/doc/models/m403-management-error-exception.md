
# M403 Management Error Exception

*This model accepts additional fields of type Object.*

## Structure

`M403ManagementErrorException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Error` | `String` | Optional | - | String getError() | setError(String error) |
| `ErrorDescription` | `String` | Optional | **Constraints**: *Maximum Length*: `1000` | String getErrorDescription() | setErrorDescription(String errorDescription) |
| `Cause` | `String` | Optional | - | String getCauseField() | setCauseField(String causeField) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "error": "Error name or code",
  "error_description": "A longer error description.",
  "cause": "A cause for the error",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

