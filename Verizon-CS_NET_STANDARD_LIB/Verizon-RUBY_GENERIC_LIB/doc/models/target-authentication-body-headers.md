
# Target Authentication Body Headers

Authentication headers.

*This model accepts additional fields of type Object.*

## Structure

`TargetAuthenticationBodyHeaders`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `String` | Optional | Authorization header. |
| `content_type` | `String` | Optional | Content-Type header. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

