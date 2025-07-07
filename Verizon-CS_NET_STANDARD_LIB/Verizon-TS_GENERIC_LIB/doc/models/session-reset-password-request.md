
# Session Reset Password Request

Request to a new, randomly generated password for the current username.

*This model accepts additional fields of type unknown.*

## Structure

`SessionResetPasswordRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `oldPassword` | `string` | Required | The current password for the username. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

