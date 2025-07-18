
# Target Authentication Body

*This model accepts additional fields of type array.*

## Structure

`TargetAuthenticationBody`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `grantType` | `?string` | Optional | Authentication grant type. | getGrantType(): ?string | setGrantType(?string grantType): void |
| `refreshToken` | `?string` | Optional | Refresh token. | getRefreshToken(): ?string | setRefreshToken(?string refreshToken): void |
| `scope` | `?string` | Optional | Authentication scopes. | getScope(): ?string | setScope(?string scope): void |
| `headers` | [`?TargetAuthenticationBodyHeaders`](../../doc/models/target-authentication-body-headers.md) | Optional | Authentication headers. | getHeaders(): ?TargetAuthenticationBodyHeaders | setHeaders(?TargetAuthenticationBodyHeaders headers): void |
| `host` | [`?TargetAuthenticationBodyHost`](../../doc/models/target-authentication-body-host.md) | Optional | Host information. | getHost(): ?TargetAuthenticationBodyHost | setHost(?TargetAuthenticationBodyHost host): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

