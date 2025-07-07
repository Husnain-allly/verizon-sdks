
# Target Authentication Body

*This model accepts additional fields of type unknown.*

## Structure

`TargetAuthenticationBody`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `grantType` | `string \| undefined` | Optional | Authentication grant type. |
| `refreshToken` | `string \| undefined` | Optional | Refresh token. |
| `scope` | `string \| undefined` | Optional | Authentication scopes. |
| `headers` | [`TargetAuthenticationBodyHeaders \| undefined`](../../doc/models/target-authentication-body-headers.md) | Optional | Authentication headers. |
| `host` | [`TargetAuthenticationBodyHost \| undefined`](../../doc/models/target-authentication-body-host.md) | Optional | Host information. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

