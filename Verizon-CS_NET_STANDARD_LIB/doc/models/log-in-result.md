
# Log in Result

Response to initiate a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.

*This model accepts additional fields of type object.*

## Structure

`LogInResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SessionToken` | `string` | Optional | The identifier for the session that was created by the request. Store the sessionToken for use in the header of all other API requests. |
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

