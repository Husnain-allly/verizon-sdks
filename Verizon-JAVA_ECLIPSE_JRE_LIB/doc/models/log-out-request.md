
# Log Out Request

Request to end a Connectivity Management session.

*This model accepts additional fields of type Object.*

## Structure

`LogOutRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `SessionToken` | `String` | Optional | The session token is returned to confirm that it was invalidated. | String getSessionToken() | setSessionToken(String sessionToken) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

