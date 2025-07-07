
# Session Reset Password Result

Response to a new, randomly generated password for the current username.

*This model accepts additional fields of type Object.*

## Structure

`SessionResetPasswordResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `NewPassword` | `String` | Optional | The new password for the username. | String getNewPassword() | setNewPassword(String newPassword) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

