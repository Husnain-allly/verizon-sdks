
# Generate External Id Result

A new external ID.

*This model accepts additional fields of type array.*

## Structure

`GenerateExternalIdResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `externalid` | `?string` | Optional | Newly created security string. | getExternalid(): ?string | setExternalid(?string externalid): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "externalid": "ZlJnih8BfqsosZrEEkfPuR3aGOk2i-HIr6tXN275ioJF6bezIrQB9EbzpTRep8J7RmV7QH==",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

