
# Target Authentication Body Headers

Authentication headers.

*This model accepts additional fields of type array.*

## Structure

`TargetAuthenticationBodyHeaders`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `authorization` | `?string` | Optional | Authorization header. | getAuthorization(): ?string | setAuthorization(?string authorization): void |
| `contentType` | `?string` | Optional | Content-Type header. | getContentType(): ?string | setContentType(?string contentType): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

