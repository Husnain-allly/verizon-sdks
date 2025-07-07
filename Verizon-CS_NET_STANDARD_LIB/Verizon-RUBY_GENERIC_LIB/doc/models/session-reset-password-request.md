
# Session Reset Password Request

Request to a new, randomly generated password for the current username.

*This model accepts additional fields of type Object.*

## Structure

`SessionResetPasswordRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `old_password` | `String` | Required | The current password for the username. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "oldPassword": "grflbk",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

