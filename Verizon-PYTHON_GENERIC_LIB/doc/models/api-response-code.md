
# Api Response Code

ResponseCode and/or a message indicating success or failure of the request.

*This model accepts additional fields of type Any.*

## Structure

`ApiResponseCode`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `response_code` | [`ResponseCode`](../../doc/models/response-code.md) | Required | Possible response codes. |
| `message` | `str` | Required | More details about the responseCode received. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "responseCode": "INVALID_ACCESS",
  "message": "message4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

