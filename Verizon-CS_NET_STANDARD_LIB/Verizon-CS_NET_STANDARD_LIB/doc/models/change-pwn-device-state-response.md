
# Change Pwn Device State Response

Response to change PWN device state

*This model accepts additional fields of type object.*

## Structure

`ChangePwnDeviceStateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `RequestId` | `string` | Optional | A unique string that associates the request with the results that are sent via a callback service. |
| `AdditionalProperties` | `object this[string key]` | Optional | - |

## Example (as JSON)

```json
{
  "requestId": "24da9f9a-d110-4a54-86b4-93fb76aab83c",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

