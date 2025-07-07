
# Fields 2

List of fields affected by the event.

*This model accepts additional fields of type array.*

## Structure

`Fields2`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `temperature` | `?string` | Optional | - | getTemperature(): ?string | setTemperature(?string temperature): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "temperature": "18.4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

