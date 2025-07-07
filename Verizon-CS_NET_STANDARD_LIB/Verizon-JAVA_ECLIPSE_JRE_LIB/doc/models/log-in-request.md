
# Log in Request

Request to initiate a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.

*This model accepts additional fields of type Object.*

## Structure

`LogInRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Username` | `String` | Required | The username for authentication. | String getUsername() | setUsername(String username) |
| `Password` | `String` | Required | The password for authentication. | String getPassword() | setPassword(String password) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

