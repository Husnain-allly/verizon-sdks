
# Intelligence Result Exception

An error occurred.

*This model accepts additional fields of type interface{}.*

## Structure

`IntelligenceResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ErrorCode` | `*string` | Optional | The 3-digit HTML error code.<br><br>**Constraints**: *Maximum Length*: `3`, *Pattern*: `^[0-9]{3}$` |
| `ErrorMessage` | `*string` | Optional | Error Message.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `1000`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "errorCode": "errorCode6",
  "errorMessage": "errorMessage8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

