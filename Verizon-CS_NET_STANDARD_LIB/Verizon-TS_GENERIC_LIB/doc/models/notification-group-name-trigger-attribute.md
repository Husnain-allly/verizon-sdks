
# Notification Group Name Trigger Attribute

Notification group name trigger attribute.

*This model accepts additional fields of type unknown.*

## Structure

`NotificationGroupNameTriggerAttribute`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `key` | `string \| undefined` | Optional | If present, the NotificationGroupName will be listed here. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

