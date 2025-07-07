
# Target Authentication Body

*This model accepts additional fields of type Object.*

## Structure

`TargetAuthenticationBody`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `GrantType` | `String` | Optional | Authentication grant type. | String getGrantType() | setGrantType(String grantType) |
| `RefreshToken` | `String` | Optional | Refresh token. | String getRefreshToken() | setRefreshToken(String refreshToken) |
| `Scope` | `String` | Optional | Authentication scopes. | String getScope() | setScope(String scope) |
| `Headers` | [`TargetAuthenticationBodyHeaders`](../../doc/models/target-authentication-body-headers.md) | Optional | Authentication headers. | TargetAuthenticationBodyHeaders getHeaders() | setHeaders(TargetAuthenticationBodyHeaders headers) |
| `Host` | [`TargetAuthenticationBodyHost`](../../doc/models/target-authentication-body-host.md) | Optional | Host information. | TargetAuthenticationBodyHost getHost() | setHost(TargetAuthenticationBodyHost host) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
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
  "scope": "scope0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

