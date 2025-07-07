
# Session Reset Password Result

Response to a new, randomly generated password for the current username.

*This model accepts additional fields of type interface{}.*

## Structure

`SessionResetPasswordResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NewPassword` | `*string` | Optional | The new password for the username. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

