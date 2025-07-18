
# Fota V1 Callback Registration Result

Registered callback account name and service name.

*This model accepts additional fields of type array.*

## Structure

`FotaV1CallbackRegistrationResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `accountName` | `?string` | Optional | The name of the billing account for which callback messages will be sent. | getAccountName(): ?string | setAccountName(?string accountName): void |
| `serviceName` | `?string` | Optional | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. This will be 'Fota' for the Software Management Services callback. | getServiceName(): ?string | setServiceName(?string serviceName): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "accountName": "0204563412-00001",
  "serviceName": "Fota",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

