
# Session Reset Password Result

Response to a new, randomly generated password for the current username.

*This model accepts additional fields of type unknown.*

## Structure

`SessionResetPasswordResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `newPassword` | `string \| undefined` | Optional | The new password for the username. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

