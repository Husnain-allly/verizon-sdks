
# Target Authentication Body Headers

Authentication headers.

*This model accepts additional fields of type Any.*

## Structure

`TargetAuthenticationBodyHeaders`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `str` | Optional | Authorization header. |
| `content_type` | `str` | Optional | Content-Type header. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

