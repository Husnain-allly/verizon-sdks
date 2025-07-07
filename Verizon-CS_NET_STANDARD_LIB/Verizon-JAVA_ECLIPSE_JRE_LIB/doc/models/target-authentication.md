
# Target Authentication

OAuth 2 token and refresh token for TS to stream events to Target.

*This model accepts additional fields of type Object.*

## Structure

`TargetAuthentication`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Body` | [`TargetAuthenticationBody`](../../doc/models/target-authentication-body.md) | Optional | - | TargetAuthenticationBody getBody() | setBody(TargetAuthenticationBody body) |
| `Version` | `String` | Optional | - | String getVersion() | setVersion(String version) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "body": {
    "grant_type": "refresh_token",
    "refresh_token": "qfeqVjZTYzMmUtZWMzZqfq4ZDUtNzFhZWVkYTlmMjk1",
    "headers": {
      "Authorization": "Basic RGFrqewfq2xpZW50QXBwVjI6YzM5YjqfqmI2LWI2MWQtNDRlZTQ5MmM1YTRk",
      "Content-Type": "application/x-www-form-urlencoded",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "host": {
      "hostandpath": "https:// myhost.com:1825",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "scope": "scope6",
    "exampleAdditionalProperty": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "version": "1.0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

