
# Get Pwn Performance Consent Response

PWN Performance Consent Response

*This model accepts additional fields of type array.*

## Structure

`GetPwnPerformanceConsentResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `consent` | `?string` | Optional | PWN Performance Consent Response. | getConsent(): ?string | setConsent(?string consent): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "consent": "false",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

