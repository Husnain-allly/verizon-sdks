
# Edge Discovery Result Data

For cases where user input exceeds the boundary values an additional 'data' key will be returned with a relevant description.

*This model accepts additional fields of type array.*

## Structure

`EdgeDiscoveryResultData`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `additionalMessage` | `?string` | Optional | **Constraints**: *Maximum Length*: `32` | getAdditionalMessage(): ?string | setAdditionalMessage(?string additionalMessage): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "additionalMessage": "additionalMessage2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

