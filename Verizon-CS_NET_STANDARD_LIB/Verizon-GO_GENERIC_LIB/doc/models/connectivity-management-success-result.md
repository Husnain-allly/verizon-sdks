
# Connectivity Management Success Result

Response to successful request.

*This model accepts additional fields of type interface{}.*

## Structure

`ConnectivityManagementSuccessResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Success` | `*bool` | Optional | A value of “true” indicates that the device group was created successfully. |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

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

