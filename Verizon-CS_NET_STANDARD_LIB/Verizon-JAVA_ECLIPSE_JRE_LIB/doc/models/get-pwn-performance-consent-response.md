
# Get Pwn Performance Consent Response

PWN Performance Consent Response

*This model accepts additional fields of type Object.*

## Structure

`GetPwnPerformanceConsentResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Consent` | `String` | Optional | PWN Performance Consent Response. | String getConsent() | setConsent(String consent) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

