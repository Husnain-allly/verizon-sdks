
# Activeindicator

*This model accepts additional fields of type array.*

## Structure

`Activeindicator`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `active` | [`?string(Active)`](../../doc/models/active.md) | Optional | A flag to indicate of the trigger is active, true, or not, false | getActive(): ?string | setActive(?string active): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "active": "true",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

