
# Notification Group Name Trigger Attribute

Notification group name trigger attribute.

*This model accepts additional fields of type Object.*

## Structure

`NotificationGroupNameTriggerAttribute`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Key` | `String` | Optional | If present, the NotificationGroupName will be listed here. | String getKey() | setKey(String key) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

