
# Dto Add Users to Notification Group Request

*This model accepts additional fields of type Object.*

## Structure

`DtoAddUsersToNotificationGroupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountname` | `String` | Optional | The numeric account name, which must include leading zeros |
| `id` | `String` | Optional | UUID of the user record, assigned at creation |
| `userids` | `Array<String>` | Optional | - |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "id": "id4",
  "userids": [
    "userids2",
    "userids1"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

