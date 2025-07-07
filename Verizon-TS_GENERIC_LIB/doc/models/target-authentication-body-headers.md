
# Target Authentication Body Headers

Authentication headers.

*This model accepts additional fields of type unknown.*

## Structure

`TargetAuthenticationBodyHeaders`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `authorization` | `string \| undefined` | Optional | Authorization header. |
| `contentType` | `string \| undefined` | Optional | Content-Type header. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

