
# M400 Management Error Exception

*This model accepts additional fields of type array.*

## Structure

`M400ManagementErrorException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `error` | `?string` | Optional | - | getError(): ?string | setError(?string error): void |
| `errorDescription` | `?string` | Optional | **Constraints**: *Maximum Length*: `1000` | getErrorDescription(): ?string | setErrorDescription(?string errorDescription): void |
| `cause` | `?string` | Optional | - | getCause(): ?string | setCause(?string cause): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "error": "Error name or code",
  "error_description": "A longer error description.",
  "cause": "A cause for the error",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

