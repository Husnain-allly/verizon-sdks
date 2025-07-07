
# Target Authentication Body Headers

Authentication headers.

*This model accepts additional fields of type object.*

## Structure

`TargetAuthenticationBodyHeaders`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Authorization` | `string` | Optional | Authorization header. |
| `ContentType` | `string` | Optional | Content-Type header. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

