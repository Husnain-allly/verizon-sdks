
# Connectivity Management Success Result

Response to successful request.

*This model accepts additional fields of type Object.*

## Structure

`ConnectivityManagementSuccessResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `success` | `TrueClass \| FalseClass` | Optional | A value of “true” indicates that the device group was created successfully. |
| `additional_properties` | `Hash[String, Object]` | Optional | - |

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

