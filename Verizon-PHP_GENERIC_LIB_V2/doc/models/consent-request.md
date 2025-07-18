
# Consent Request

*This model accepts additional fields of type array.*

## Structure

`ConsentRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `string` | Required | Account identifier in "##########-#####". | getAccountName(): string | setAccountName(string accountName): void |
| `allDevice` | `?bool` | Optional | Exclude all devices or not. | getAllDevice(): ?bool | setAllDevice(?bool allDevice): void |
| `type` | `?string` | Optional | The change to make: append or replace. | getType(): ?string | setType(?string type): void |
| `exclusion` | `?(string[])` | Optional | Device ID list. | getExclusion(): ?array | setExclusion(?array exclusion): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "1234567890-00001",
  "type": "replace",
  "allDevice": false,
  "exclusion": [
    "980003420535573",
    "375535024300089",
    "A100003861E585"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

