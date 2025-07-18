
# Fota V1 Callback Registration Request

Callback endpoint information.

*This model accepts additional fields of type array.*

## Structure

`FotaV1CallbackRegistrationRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `name` | `string` | Required | The name of the callback service that you want to subscribe to, which must be 'Fota' for Software Management Services callbacks. | getName(): string | setName(string name): void |
| `url` | `string` | Required | The address on your server where you have enabled a listening service for Software Management Services callback messages. | getUrl(): string | setUrl(string url): void |
| `username` | `?string` | Optional | The user name that ThingSpace should return in the callback messages. | getUsername(): ?string | setUsername(?string username): void |
| `password` | `?string` | Optional | The password that ThingSpace should return in the callback messages. | getPassword(): ?string | setPassword(?string password): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "name": "Fota",
  "url": "https://10.120.102.183:50559/CallbackListener/FirmwareServiceMessages.asmx",
  "username": "username2",
  "password": "password2",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

