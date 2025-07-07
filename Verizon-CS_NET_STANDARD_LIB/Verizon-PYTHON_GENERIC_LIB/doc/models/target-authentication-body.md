
# Target Authentication Body

*This model accepts additional fields of type Any.*

## Structure

`TargetAuthenticationBody`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `grant_type` | `str` | Optional | Authentication grant type. |
| `refresh_token` | `str` | Optional | Refresh token. |
| `scope` | `str` | Optional | Authentication scopes. |
| `headers` | [`TargetAuthenticationBodyHeaders`](../../doc/models/target-authentication-body-headers.md) | Optional | Authentication headers. |
| `host` | [`TargetAuthenticationBodyHost`](../../doc/models/target-authentication-body-host.md) | Optional | Host information. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

