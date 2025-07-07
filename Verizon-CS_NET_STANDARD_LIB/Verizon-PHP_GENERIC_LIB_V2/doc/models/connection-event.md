
# Connection Event

Network connection events for a device during a specified time period.

*This model accepts additional fields of type array.*

## Structure

`ConnectionEvent`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `connectionEventAttributes` | [`?(CustomFields[])`](../../doc/models/custom-fields.md) | Optional | The attributes that describe the connection event. | getConnectionEventAttributes(): ?array | setConnectionEventAttributes(?array connectionEventAttributes): void |
| `extendedAttributes` | [`?(CustomFields[])`](../../doc/models/custom-fields.md) | Optional | Currently not used. | getExtendedAttributes(): ?array | setExtendedAttributes(?array extendedAttributes): void |
| `occurredAt` | `?string` | Optional | The date and time when the connection event occured. | getOccurredAt(): ?string | setOccurredAt(?string occurredAt): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "connectionEventAttributes": [
    {
      "key": "BytesUsed",
      "value": "0",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    {
      "key": "Event",
      "value": "Start",
      "exampleAdditionalProperty": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  ],
  "extendedAttributes": [],
  "occurredAt": "2015-12-17T14:12:36-05:00",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

