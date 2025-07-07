
# Log in Result

Response to initiate a Connectivity Management session and returns a VZ-M2M session token that is required in subsequent API requests.

*This model accepts additional fields of type Object.*

## Structure

`LogInResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `session_token` | `String` | Optional | The identifier for the session that was created by the request. Store the sessionToken for use in the header of all other API requests. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

