
# Log Out Request

Request to end a Connectivity Management session.

*This model accepts additional fields of type array.*

## Structure

`LogOutRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `sessionToken` | `?string` | Optional | The session token is returned to confirm that it was invalidated. | getSessionToken(): ?string | setSessionToken(?string sessionToken): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "sessionToken": "bcce3ea6-fe4f-4952-bacf-eadd80718e83",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

