
# Carrier

*This model accepts additional fields of type interface{}.*

## Structure

`Carrier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Carriers` | `*string` | Optional | The list of carriers with active or available profiles<br><br>**Constraints**: *Minimum Length*: `3`, *Maximum Length*: `32`, *Pattern*: `^[0-9]{3,32}$` |
| `AdditionalProperties` | `map[string]interface{}` | Optional | - |

## Example (as JSON)

```json
{
  "carriers": "carriers0",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

