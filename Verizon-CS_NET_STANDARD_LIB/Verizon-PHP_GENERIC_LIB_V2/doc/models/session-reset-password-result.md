
# Session Reset Password Result

Response to a new, randomly generated password for the current username.

*This model accepts additional fields of type array.*

## Structure

`SessionResetPasswordResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `newPassword` | `?string` | Optional | The new password for the username. | getNewPassword(): ?string | setNewPassword(?string newPassword): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

