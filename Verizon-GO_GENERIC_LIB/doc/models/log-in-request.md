
# Log in Request

Request to initiate a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.

*This model accepts additional fields of type interface{}.*

## Structure

`LogInRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Username` | `string` | Required | The username for authentication. |
| `Password` | `string` | Required | The password for authentication. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

