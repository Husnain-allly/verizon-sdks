
# Map Data Response Error Exception

error response structure

*This model accepts additional fields of type interface{}.*

## Structure

`MapDataResponseErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Error` | `string` | Required | The short summary of the error<br><br>**Constraints**: *Minimum Length*: `0`, *Maximum Length*: `1024`, *Pattern*: ``^[\w\s~\+\-!@#$%^&*()\`\[\]{=};"\'\:\.,\/<>?\|\s]+$`` |
| `Description` | `string` | Required | The detailed description of the error<br><br>**Constraints**: *Minimum Length*: `0`, *Maximum Length*: `4096`, *Pattern*: ``^[\w\s~\+\-!@#$%^&*()\`\[\]{=};"\'\:\.,\/<>?\|\s]*$`` |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "error": "Error Summary",
  "description": "Error Description",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

