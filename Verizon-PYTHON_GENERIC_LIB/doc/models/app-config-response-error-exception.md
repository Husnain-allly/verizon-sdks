
# App Config Response Error Exception

error response structure

*This model accepts additional fields of type Any.*

## Structure

`AppConfigResponseErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `error` | `str` | Required | The short summary of the error<br><br>**Constraints**: *Minimum Length*: `0`, *Maximum Length*: `1024`, *Pattern*: ``^[\w~\+\-!@#$%^&*()\`\[\]{=};\"':,.\\\/<>?\|\s]*$`` |
| `description` | `str` | Required | The detailed description of the error<br><br>**Constraints**: *Minimum Length*: `0`, *Maximum Length*: `8192`, *Pattern*: ``^[\w~\+\-!@#$%^&*()\`\[\]{=};\"':,.\\\/<>?\|\s]*$`` |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

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

