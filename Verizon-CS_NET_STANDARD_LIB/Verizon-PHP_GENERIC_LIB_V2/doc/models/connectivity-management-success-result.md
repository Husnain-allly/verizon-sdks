
# Connectivity Management Success Result

Response to successful request.

*This model accepts additional fields of type array.*

## Structure

`ConnectivityManagementSuccessResult`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `success` | `?bool` | Optional | A value of “true” indicates that the device group was created successfully. | getSuccess(): ?bool | setSuccess(?bool success): void |
| `additionalProperties` | `array<string, array>` | Optional | - | findAdditionalProperty(string key): array | additionalProperty(string key, array value): void |

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

