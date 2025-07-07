
# Log Out Request

Request to end a Connectivity Management session.

*This model accepts additional fields of type object.*

## Structure

`LogOutRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SessionToken` | `string` | Optional | The session token is returned to confirm that it was invalidated. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "sessionToken": "bcce3ea6-fe4f-4952-bacf-eadd80718e83",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

