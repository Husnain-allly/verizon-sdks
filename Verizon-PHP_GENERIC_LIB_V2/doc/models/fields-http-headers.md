
# Fields Http Headers

*This model accepts additional fields of type array.*

## Structure

`FieldsHttpHeaders`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `authorization` | `?string` | Optional | - | getAuthorization(): ?string | setAuthorization(?string authorization): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "Authorization": "SharedAccessSignature sr=d1f9b6bf-1380-41f6-b757-d9805e48392b&sig=EF5tnXClw3MWkb84OkIOUhMH%2FaS1DRD2nXT69QR8RD8%3D&skn=TSCCtoken&se=1648827260410",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

