
# Notification Group Name Trigger Attribute

Notification group name trigger attribute.

*This model accepts additional fields of type array.*

## Structure

`NotificationGroupNameTriggerAttribute`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `key` | `?string` | Optional | If present, the NotificationGroupName will be listed here. | getKey(): ?string | setKey(?string key): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

## Example (as JSON)

```json
{
  "key": "NotificationGroupName",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

