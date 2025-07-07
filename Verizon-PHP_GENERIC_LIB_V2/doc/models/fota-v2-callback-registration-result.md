
# Fota V2 Callback Registration Result

Callback listener URL.

*This model accepts additional fields of type array.*

## Structure

`FotaV2CallbackRegistrationResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `url` | `?string` | Optional | Callback URL. | getUrl(): ?string | setUrl(?string url): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "url": "https://255.255.11.135:50559/CallbackListener/FirmwareServiceMessages.asmx",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

