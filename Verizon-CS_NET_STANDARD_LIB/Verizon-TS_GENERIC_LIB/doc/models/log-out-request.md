
# Log Out Request

Request to end a Connectivity Management session.

*This model accepts additional fields of type unknown.*

## Structure

`LogOutRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sessionToken` | `string \| undefined` | Optional | The session token is returned to confirm that it was invalidated. |
| `additionalProperties` | `Record<string, unknown>` | Optional | - |

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

