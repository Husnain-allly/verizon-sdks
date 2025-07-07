
# Session Reset Password Request

Request to a new, randomly generated password for the current username.

*This model accepts additional fields of type array.*

## Structure

`SessionResetPasswordRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `oldPassword` | `string` | Required | The current password for the username. | getOldPassword(): string | setOldPassword(string oldPassword): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

