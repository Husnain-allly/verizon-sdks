
# Session Reset Password Result

Response to a new, randomly generated password for the current username.

*This model accepts additional fields of type Any.*

## Structure

`SessionResetPasswordResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `new_password` | `str` | Optional | The new password for the username. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "newPassword": "Wh0a1545a84d",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

