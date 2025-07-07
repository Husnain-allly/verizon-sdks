
# Callback Created

*This model accepts additional fields of type array.*

## Structure

`CallbackCreated`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `aname` | `string` | Required | The billing account number for which callback messages will be sent. | getAname(): string | setAname(string aname): void |
| `name` | `string` | Required | The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. | getName(): string | setName(string name): void |
| `url` | `?string` | Optional | The address of the callback listening service where the ThingSpace Platform will send callback messages for the service type. | getUrl(): ?string | setUrl(?string url): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "aname": "0844021539-00001",
  "name": "BullseyeReporting",
  "url": "https://tsustgtests.mocklab.io/notifications/bullseye",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

