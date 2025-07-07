
# Connectivity Management Success Result

Response to successful request.

*This model accepts additional fields of type Object.*

## Structure

`ConnectivityManagementSuccessResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Success` | `Boolean` | Optional | A value of “true” indicates that the device group was created successfully. | Boolean getSuccess() | setSuccess(Boolean success) |
| `AdditionalProperties` | `Map<String, Object>` | Optional | - | Object getAdditionalProperty(String key) | additionalProperty(String key, Object value) |

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

