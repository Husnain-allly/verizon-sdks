
# Session Reset Password Request

Request to a new, randomly generated password for the current username.

*This model accepts additional fields of type Object.*

## Structure

`SessionResetPasswordRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `OldPassword` | `String` | Required | The current password for the username. | String getOldPassword() | setOldPassword(String oldPassword) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

