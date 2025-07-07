
# Intelligence Result Exception

An error occurred.

*This model accepts additional fields of type Object.*

## Structure

`IntelligenceResultException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error_code` | `String` | Optional | The 3-digit HTML error code.<br><br>**Constraints**: *Maximum Length*: `3`, *Pattern*: `^[0-9]{3}$` |
| `error_message` | `String` | Optional | Error Message.<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `1000`, *Pattern*: `^[A-Za-z0-9]{3,32}$` |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

