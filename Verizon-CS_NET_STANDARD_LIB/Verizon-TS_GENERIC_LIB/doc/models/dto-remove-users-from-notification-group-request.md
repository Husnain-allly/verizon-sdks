
# Dto Remove Users From Notification Group Request

*This model accepts additional fields of type unknown.*

## Structure

`DtoRemoveUsersFromNotificationGroupRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountname` | `string \| undefined` | Optional | The numeric account name, which must include leading zeros |
| `id` | `string \| undefined` | Optional | UUID of the user record, assigned at creation |
| `userids` | `string[] \| undefined` | Optional | - |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

## Example (as JSON)

```json
{
  "accountname": "0000123456-00001",
  "id": "id0",
  "userids": [
    "userids2",
    "userids3",
    "userids4"
  ],
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

