
# Target Authentication Body Headers

Authentication headers.

*This model accepts additional fields of type Object.*

## Structure

`TargetAuthenticationBodyHeaders`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Authorization` | `String` | Optional | Authorization header. | String getAuthorization() | setAuthorization(String authorization) |
| `ContentType` | `String` | Optional | Content-Type header. | String getContentType() | setContentType(String contentType) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

## Example (as JSON)

```json
{
  "Authorization": "Basic RGFrqewfq2xpZW50QXBwVjI6YzM5YjqfqmI2LWI2MWQtNDRlZTQ5MmM1YTRk",
  "Content-Type": "application/x-www-form-urlencoded",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

