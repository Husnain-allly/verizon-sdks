
# Connectivity Management Success Result

Response to successful request.

*This model accepts additional fields of type Any.*

## Structure

`ConnectivityManagementSuccessResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `success` | `bool` | Optional | A value of “true” indicates that the device group was created successfully. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "success": true,
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

