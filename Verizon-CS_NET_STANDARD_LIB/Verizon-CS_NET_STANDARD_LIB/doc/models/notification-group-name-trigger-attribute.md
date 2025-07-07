
# Notification Group Name Trigger Attribute

Notification group name trigger attribute.

*This model accepts additional fields of type object.*

## Structure

`NotificationGroupNameTriggerAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Key` | `string` | Optional | If present, the NotificationGroupName will be listed here. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

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

