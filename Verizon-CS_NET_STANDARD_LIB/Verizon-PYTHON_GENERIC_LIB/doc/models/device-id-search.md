
# Device Id Search

Search by device id.

*This model accepts additional fields of type Any.*

## Structure

`DeviceIdSearch`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contains` | `str` | Required | The string appears anywhere in the identifer. |
| `startswith` | `str` | Optional | The identifer must start with the specified string. |
| `endswith` | `str` | Optional | The identifier must end with the specified string. |
| `kind` | `str` | Required | The type of the device identifier. Valid types of identifiers are:ESN (decimal),EID,ICCID (up to 20 digits),IMEI (up to 16 digits),MDN,MEID (hexadecimal),MSISDN. |
| `additional_properties` | `Dict[str, Any]` | Optional | - |

## Example (as JSON)

```json
{
  "kind": "iccid",
  "contains": "4259",
  "startswith": "startswith2",
  "endswith": "endswith4",
  "exampleAdditionalProperty": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

