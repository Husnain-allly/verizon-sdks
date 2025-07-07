
# App Config Response Error Exception

error response structure

*This model accepts additional fields of type array.*

## Structure

`AppConfigResponseErrorException`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `error` | `string` | Required | The short summary of the error<br><br>**Constraints**: *Minimum Length*: `0`, *Maximum Length*: `1024`, *Pattern*: ``^[\w~\+\-!@#$%^&*()\`\[\]{=};\"':,.\\\/<>?\|\s]*$`` | getError(): string | setError(string error): void |
| `description` | `string` | Required | The detailed description of the error<br><br>**Constraints**: *Minimum Length*: `0`, *Maximum Length*: `8192`, *Pattern*: ``^[\w~\+\-!@#$%^&*()\`\[\]{=};\"':,.\\\/<>?\|\s]*$`` | getDescription(): string | setDescription(string description): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "error": "Error Summary",
  "description": "Error Description",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

