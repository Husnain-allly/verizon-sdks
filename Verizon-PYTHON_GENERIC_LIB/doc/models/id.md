
# Id

*This model accepts additional fields of type Any.*

## Structure

`Id`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `id` | `str` | Optional | The value of the device identifier. |
| `kind` | `str` | Optional | The type of the device identifier. Valid types of identifiers are:ESN (decimal),EID,ICCID (up to 20 digits),IMEI (up to 16 digits),MDN,MEID (hexadecimal),MSISDN. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "id": "990013907835573",
  "kind": "imei",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

