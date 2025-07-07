
# Log in Request

Request to initiate a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.

*This model accepts additional fields of type array.*

## Structure

`LogInRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `username` | `string` | Required | The username for authentication. | getUsername(): string | setUsername(string username): void |
| `password` | `string` | Required | The password for authentication. | getPassword(): string | setPassword(string password): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "username": "zbeeblebrox",
  "password": "IMgr8",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

